using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegrador
{
    public partial class FormMenu : Form
    {
        public FormLogin formLogin;       
       
        public FormMenu(string bienvenida,FormLogin formLogin)
        {
            InitializeComponent();
            MostrarLibros(CargarListaLibros());
            CargarAutores();
            ValidarAdministrador(bienvenida);            
            labelMenuBienvenida.Text = "Bienvenido a la biblioteca " + bienvenida.ToUpper();
            this.formLogin = formLogin;
        }
               
        
        public List<Libro> listaLibros = new List<Libro>();
        List<Libro> listaActual = new List<Libro>();
        public int identificador;

        //CLASE Y CONSTRUCTOR LIBRO
        public class Libro
        {
            public int id;
            public string titulo;
            public string autor;
            public string rutaImg;
            public string rutaPdf;
            public string categoria;
            public DateTime fecha;
            public int lecturas;
            public Libro(int id, string titulo, string autor, string rutaImg, string rutaPdf, string categoria, DateTime fecha, int lecturas)
            {
                this.id = id;
                this.titulo = titulo;
                this.autor = autor;
                this.rutaImg = rutaImg;
                this.rutaPdf = rutaPdf;
                this.categoria = categoria;
                this.fecha = fecha;
                this.lecturas = lecturas;
            }
        }

        //METODO VALIDAR USUARIO ADMINISTRADOR
        private void ValidarAdministrador(string bienvenida)
        {
            if(bienvenida == "Admin")
            {
                iconoLibro.Visible = true;
            }
        }      

        //METODO CARGAR LISTA DE LIBROS DESDE ARCHIVO
        public List<Libro> CargarListaLibros()
        {         
            using (StreamReader reader = new StreamReader(Environment.CurrentDirectory + "\\Libros.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] campos = linea.Split(';');
                    // Verifica si hay suficientes campos para crear un libro
                    if (campos.Length >= 8)
                    {
                        int id = int.Parse(campos[0]);
                        string titulo = campos[1];
                        string autor = campos[2];
                        string rutaImg = campos[3];
                        string rutaPdf = campos[4];
                        string categoria = campos[5];
                        string fechaString = campos[6];
                        DateTime fecha = DateTime.ParseExact(fechaString, "dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                        int lecturas = int.Parse(campos[7]);

                        Libro nuevoLibro = new Libro(id, titulo, autor, rutaImg, rutaPdf, categoria, fecha, lecturas);
                        listaLibros.Add(nuevoLibro);
                        identificador++;

                    }
                    
                }
            }     
            return listaLibros;
        }

        //METODO PARA DIBUJAR LIBROS EN PANTALLA
        public void MostrarLibros(List<Libro> listaLibros)
        {
            panelLibros.Controls.Clear();        
            // Definimos las propiedades del PictureBox donde se mostraran los libros
            int anchoPictureBox = 130; 
            int altoPictureBox = 220;  
            int columnas = panelLibros.Width / (anchoPictureBox +15);
            int imagen = 0;
            //Recorremos la lista de libros
            foreach (var libro in listaLibros)
            {
                PictureBox pictureBox = new PictureBox() { Height = altoPictureBox, Width = anchoPictureBox };            

                if (libro.rutaImg.StartsWith("http"))
                {
                    try
                    {
                        pictureBox.Load(libro.rutaImg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen desde la web: {ex.Message}");            
                    }
                }
                else
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(libro.rutaImg); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen local: {ex.Message}");
                       
                    }
                }               
              
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = libro.rutaPdf; // Almacena la ruta del PDF en el Tag del PictureBox
                pictureBox.Click += PictureBox_Click;
                pictureBox.MouseHover += PictureBox_MouseHover;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
                TextBox tituloLibro = new TextBox() { Width = anchoPictureBox, Text = libro.titulo};                

                // Calcula la posición en función de la fila y columna
                int fila = imagen / columnas;
                int columna = imagen % columnas;
                int x = columna * (anchoPictureBox + 10)+10;
                int y = fila * (altoPictureBox + 30)+10;

                pictureBox.Location = new Point(x, y);
                tituloLibro.Location = new Point(x, (y + altoPictureBox));

                // Agrega el PictureBox al formulario
                panelLibros.Controls.Add(tituloLibro);
                panelLibros.Controls.Add(pictureBox);            

                imagen++;
            }
            panelLibros.Padding = new Padding(10, 0, 0, 0);
            panelLibros.AutoScroll = true;

            listaActual = listaLibros;
        }

        //METODO FILTRAR LIBROS POR GENERO
        private void MostrarLibrosGenero(List<Libro> listaLibros, string genero)
        {
            List<Libro> listaLibrosGenero = new List<Libro>();
            foreach (var libro in listaLibros)
            {
                if(libro.categoria == genero)
                {
                    listaLibrosGenero.Add(libro);
                }
            }
            listaActual = listaLibrosGenero;
            MostrarLibros(listaLibrosGenero);                
        }

        //METODO FILTRAR LIBROS POR AUTOR
        private void MostrarLibrosAutor(List<Libro> listaLibros, string autorseleccionado)
        {
            List<Libro> listaLibrosAutor = new List<Libro>();
            foreach (var libro in listaLibros)
            {
                if (libro.autor == autorseleccionado)
                {
                    listaLibrosAutor.Add(libro);
                }
            }
            listaActual = listaLibrosAutor;
            MostrarLibros(listaLibrosAutor);
        }

        //METODO FILTRAR LOS 10 ULTIMOS LIBROS AGREGADOS
        private void MostrarLibrosPorFecha(List<Libro> listaLibros)
        {
            List<Libro> librosOrdenadosPorFecha = listaLibros.OrderByDescending(libro => libro.fecha).ToList();
            List<Libro> losCincoMasRecientes = librosOrdenadosPorFecha.Take(10).ToList();

            listaActual = losCincoMasRecientes;
            MostrarLibros(losCincoMasRecientes);           
        }

        //METODO FILTRAR LOS 10 LIBROS MAS LEIDOS
        private void MostrarLibrosPorLecturas(List<Libro> listaLibros)
        {
           
            List<Libro> librosOrdenadosPorLecturas = listaLibros.OrderByDescending(libro => libro.lecturas).ToList();
            List<Libro> losCincoMasLeidos = librosOrdenadosPorLecturas.Take(10).ToList();

            listaActual = losCincoMasLeidos;
             MostrarLibros(losCincoMasLeidos);
        }

        //METODO CARGAR LOS AUTORES QUE EXISTAN EN LA LISTA EN LOS COMBOBOX
        private void CargarAutores()
        {
            // Crear una lista para almacenar los nombres de los autores únicos
            List<string> autores = new List<string>();
            
            // Recorrer la lista de libros para obtener los nombres de los autores únicos
            foreach (Libro libro in listaLibros)
            {
                // Verificar si el autor ya está en la lista, si no, agregarlo
                if (!autores.Contains(libro.autor))
                {
                    autores.Add(libro.autor);
                }
            }
            // Ordenar la lista de autores alfabéticamente
            autores.Sort();
            autores.Insert(0, "Autores");
            // Agregar los autores al ComboBox
            comboBoxAutores.DataSource = autores;            
        }

        //METODO PARA LIMPIAR LOS RADIO BUTTONS CUANDO NO SE ENCUENTRAN SELECCIONADOS
        private void LimpiarRadioButtons()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
        }

        //METODO PARA LIMPIAR LOS COMBOBOX CUANDO NO SE ENCUENTRAN SELECCIONADOS
        private void LimpiarCombobox()
        {
            comboBoxAutores.SelectedIndex = 0;
        }
        
        //EVENTO QUE ABRE LOS LIBROS CUANDO HACEMOS CLICK EN CADA IMAGEN DEL LIBRO - Abrirá tanto web como pdf local
        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is string nombreArchivo)
            {
                if (nombreArchivo.StartsWith("http"))
                {
                    try
                    {
                        Process.Start(nombreArchivo);
                    }
                    catch (System.ComponentModel.Win32Exception ex)
                    {
                        // Manejar la excepción si no se puede abrir el archivo
                        MessageBox.Show($"Error al abrir el archivo: {ex.Message}");
                    }
                }
                else
                {
                    // Construye la ruta completa al archivo PDF
                    string rutaPDF = Path.Combine(Application.StartupPath, nombreArchivo);

                    try
                    {
                        Process.Start(rutaPDF);
                    }
                    catch (System.ComponentModel.Win32Exception ex)
                    {
                        // Manejar la excepción si no se puede abrir el archivo
                        MessageBox.Show($"Error al abrir el archivo: {ex.Message}");
                    }
                }
            }
        }

        //EVENTO HOVER SOBRE LOS LIBROS PARA MOSTRARLOS PRESELECCIONADOS
        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.BackColor = Color.Blue;
                pictureBox.Width= 120;             
                pictureBox.Height = 210;
                pictureBox.Cursor = Cursors.Hand;            
            }               
        }

        //EVENTO PARA DEVOLVER PROPIEDADES AL RETIRAR EL MOUSE
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BorderStyle = BorderStyle.None;                
                pictureBox.Width = 130;
                pictureBox.Height = 220;
            }
        }

        //EVENTO SOBRE BOTON CATALOGO
        private void BtnMenuCatalogo_Click(object sender, EventArgs e)
        {
            LimpiarCombobox();
            LimpiarRadioButtons();
            MostrarLibros(listaLibros);
        }

        //EVENTO SOBRE BOTON ULTIMOS LIBROS CARGADOS
        private void BtnMenuUltimos_Click(object sender, EventArgs e)
        {
            LimpiarCombobox();
            LimpiarRadioButtons();
            MostrarLibrosPorFecha(listaLibros);
        }

        //EVENTO SOBRE BOTON LIBROS MAS LEIDOS
        private void BtnMenuLeidos_Click(object sender, EventArgs e)
        {
            LimpiarCombobox();
            LimpiarRadioButtons();
            MostrarLibrosPorLecturas(listaLibros);
        }

        //EVENTO QUE LLAMA AL METODO MOSTRAR LIBRO CADA VEZ QUE SE TERMINA DE REDIMENCIONAR EL FORMULARIO
        private void FormMenu_ResizeEnd(object sender, EventArgs e)
        {                       
             MostrarLibros(listaActual);                                 
        }

        //EVENTO QUE LLAMA AL METODO MOSTRAR LIBRO SI SE MAXIMIZA EL FORMULARIO     
        private void FormMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {               
                MostrarLibros(listaActual);
            }
        }

        //EVENTO QUE "CAMBIA" EL COLOR DEL ICONO AGREGAR LIBRO
        private void IconoLibro_MouseHover(object sender, EventArgs e)
        {
            iconoLibro.Visible = false;
            iconoLibro2.Visible = true;
        }

        //EVENTO QUE "REGRESA" EL COLOR AL ICONO AGREGAR LIBRO
        private void IconoLibro2_MouseLeave(object sender, EventArgs e)
        {
            iconoLibro.Visible = true;
            iconoLibro2.Visible = false;
        }    

        //EVENTO QUE ABRE FORMULARIO AL HACER CLICK EN EL ICONO AGREGAR LIBRO
        private void IconoLibro2_Click(object sender, EventArgs e)
        {
            FormAdministrador formAdministrador = new FormAdministrador(this);
            formAdministrador.Show();
            this.Hide();
        }

        //EVENTO QUE ACTUALIZA LOS LIBROS CUANDO CAMBIA LA SELECCION DE UN RADIO BUTTON
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                LimpiarCombobox();
                // Obtener el género del texto del RadioButton en minusculas
                string generoSeleccionado = radioButton.Text.ToLower();
                MostrarLibrosGenero(listaLibros, generoSeleccionado);
            }
        }

        //EVENTO QUE ACTUALIZA LOS LIBROS QUE SE MUESTRAN CUANDO SE SELECCIONA UN AUTOR
        private void ComboBoxAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el autor seleccionado en el ComboBox
            string autorSeleccionado = comboBoxAutores.Text;

            if (comboBoxAutores.Text != "Autores")
            {
                MostrarLibrosAutor(listaLibros, autorSeleccionado);
                LimpiarRadioButtons();
            }
            else
            {
                MostrarLibros(listaLibros);
                LimpiarRadioButtons();
            }
        }

        //EVENTO QUE CIERRA LA APP CUANDO SE CIERRA ESTE FORMULARIO
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.Close();
        }              
    }
}


