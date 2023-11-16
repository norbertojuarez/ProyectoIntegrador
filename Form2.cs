using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegrador
{
    public partial class FormMenu : Form
    {
        public FormMenu(string bienvenida)
        {
            InitializeComponent();            
            MostrarLibros(CrearLista());
            CargarAutores();
            labelMenuBienvenida.Text = "Bienvenido a la biblioteca " + bienvenida.ToUpper();
        }

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

        //Crear lista de libros
        List<Libro> listaLibros = new List<Libro>();
        List<Libro> listaActual = new List<Libro>();

        List<Libro> CrearLista()
        {
            

            //Crear los objetos libro
            Libro libro1 = new Libro(1, "Harry Potter y la piedra filosofal", "J.K. Rowling", "Image/harry_potter.jpg", "Pdf/harry_potter_piedra_filosofal.pdf", "novela", new DateTime(2023, 2, 22), 55);
            Libro libro2 = new Libro(2, "1984", "George Orwell", "Image/1984.jpg", "Pdf/1984.pdf", "novela", new DateTime(2014, 12, 20),9);
            Libro libro3 = new Libro(3, "Crónicas marcianas", "Ray Bradbury", "Image/cronicas_marcianas.jpg", "Pdf/cronicas_marcianas.pdf", "relato", new DateTime(2013, 6, 29),1);
            Libro libro4 = new Libro(4, "Don Quijote de la Mancha", "Miguel de Cervantes", "Image/don_quijote.jpg", "Pdf/don_quijote.pdf" , "novela", new DateTime(2023, 2, 2),90);
            Libro libro5 = new Libro(5, "El Hobbit", "J.R.R. Tolkien", "Image/el_hobbit.jpg", "Pdf/el_hobbit.pdf", "novela", new DateTime(2002, 4, 12),14);
            Libro libro6 = new Libro(6, "Crimen y castigo", "Fyodor Dostoevsky", "Image/crimen_castigo.jpg", "Pdf/crimen_y_castigo.pdf", "ciencia ficcion", new DateTime(2013, 2, 20),23);
            Libro libro7 = new Libro(7, "Cien años de soledad", "Gabriel García Márquez", "Image/soledad.jpg", "Pdf/cien_anios_de_soledad.pdf", "ciencia ficcion", new DateTime(2012, 2, 21),55);
            Libro libro8 = new Libro(8, "El señor de los anillos", "J.R.R. Tolkien", "Image/senor_anillos.jpg", "Pdf/el_senor_de_los_anillos.pdf", "ciencia ficcion", new DateTime(2000, 2, 20),99);
            Libro libro9 = new Libro(9, "El código Da Vinci", "Dan Brown", "Image/codigo_da_vinci.jpg", "Pdf/el_codigo_da_vinci.pdf", "policial", new DateTime(2023, 9, 30),7);
            Libro libro10 = new Libro(10, "Los juegos del hambre", "Suzanne Collins", "Image/juegos_del_hambre.jpg", "Pdf/los_juegos_del_hambre.pdf", "ciencia ficcion", new DateTime(2011, 11, 11),17);
            Libro libro11 = new Libro(11, "El alquimista", "Paulo Coelho", "Image/el_alquimista.jpg", "Pdf/el_alquimista.pdf", "ciencia ficcion", new DateTime(2022, 2, 22),34);
            Libro libro12 = new Libro(1, "Harry Potter y la piedra filosofal", "J.K. Rowling", "Image/harry_potter.jpg", "Pdf/harry_potter_piedra_filosofal.pdf", "ciencia ficcion", new DateTime(2007, 7, 10),88);
            Libro libro13 = new Libro(2, "1984", "George Orwell", "Image/1984.jpg", "Pdf/1984.pdf", "ciencia ficcion", new DateTime(2010, 1, 21),90);
            Libro libro14= new Libro(3, "Crónicas marcianas", "Ray Bradbury", "Image/cronicas_marcianas.jpg", "Pdf/cronicas_marcianas.pdf", "ciencia ficcion", new DateTime(2000, 1, 18),1);
            Libro libro15 = new Libro(4, "Don Quijote de la Mancha", "Miguel de Cervantes", "Image/don_quijote.jpg", "Pdf/don_quijote.pdf", "ciencia ficcion", new DateTime(2023, 2, 19),26);
            Libro libro16= new Libro(5, "El Hobbit", "J.R.R. Tolkien", "Image/el_hobbit.jpg", "Pdf/el_hobbit.pdf", "ciencia ficcion", new DateTime(2023, 2, 27),70);
            Libro libro17= new Libro(6, "Crimen y castigo", "Fyodor Dostoevsky", "Image/crimen_castigo.jpg", "Pdf/crimen_y_castigo.pdf", "ciencia ficcion", new DateTime(2016, 2, 20),33);
            Libro libro18= new Libro(7, "Cien años de soledad", "Gabriel García Márquez", "Image/soledad.jpg", "Pdf/cien_anios_de_soledad.pdf", "ciencia ficcion", new DateTime(2013, 2, 20),12);
            Libro libro19= new Libro(8, "El señor de los anillos", "J.R.R. Tolkien", "Image/senor_anillos.jpg", "Pdf/el_senor_de_los_anillos.pdf", "ciencia ficcion", new DateTime(2005, 2, 12),51);
            Libro libro20= new Libro(9, "El código Da Vinci", "Dan Brown", "Image/codigo_da_vinci.jpg", "Pdf/el_codigo_da_vinci.pdf", "ciencia ficcion", new DateTime(1999, 2, 20),98);
            Libro libro21 = new Libro(10, "Los juegos del hambre", "Suzanne Collins", "Image/juegos_del_hambre.jpg", "Pdf/los_juegos_del_hambre.pdf", "ciencia ficcion", new DateTime(1998, 2, 20),2);
            Libro libro22 = new Libro(11, "El alquimista", "Paulo Coelho", "Image/el_alquimista.jpg", "Pdf/el_alquimista.pdf", "ciencia ficcion", new DateTime(2021, 2, 2),83);

            // añadir los libros a la lista

            listaLibros.Add(libro1);
            listaLibros.Add(libro2);
            listaLibros.Add(libro3);
            listaLibros.Add(libro4);
            listaLibros.Add(libro5);
            listaLibros.Add(libro6);
            listaLibros.Add(libro7);
            listaLibros.Add(libro8);
            listaLibros.Add(libro9);
            listaLibros.Add(libro10);
            listaLibros.Add(libro11);
            listaLibros.Add(libro12);
            listaLibros.Add(libro13);
            listaLibros.Add(libro14);
            listaLibros.Add(libro15);
            listaLibros.Add(libro16);
            listaLibros.Add(libro17);
            listaLibros.Add(libro18);
            listaLibros.Add(libro19);
            listaLibros.Add(libro20);
            listaLibros.Add(libro21);
            listaLibros.Add(libro22);

            

            return listaLibros;

        }


        void MostrarLibros(List<Libro> listaLibros)
        {
            panelLibros.Controls.Clear();
            

            // Definimos las propiedades del PictureBox
            int anchoPictureBox = 130; 
            int altoPictureBox = 220;  
            int columnas = panelLibros.Width / (anchoPictureBox +15);
            int imagen = 0;

            //Recorremos la lista de libros
            foreach (var libro in listaLibros)
            {

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = anchoPictureBox;
                pictureBox.Height = altoPictureBox;
                pictureBox.Image = Image.FromFile(libro.rutaImg);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = libro.rutaPdf; // Almacena la ruta del PDF en el Tag del PictureBox
                pictureBox.Click += PictureBox_Click;
                pictureBox.MouseHover += PictureBox_MouseHover;
                TextBox tituloLibro = new TextBox();
                tituloLibro.Width = anchoPictureBox;
                tituloLibro.Text = libro.titulo;
                
               

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

        private void MostrarLibrosPorFecha(List<Libro> listaLibros)
        {
            List<Libro> librosOrdenadosPorFecha = listaLibros.OrderByDescending(libro => libro.fecha).ToList();
            List<Libro> losCincoMasRecientes = librosOrdenadosPorFecha.Take(5).ToList();

            listaActual = losCincoMasRecientes;
            MostrarLibros(losCincoMasRecientes);
           
        }

        private void MostrarLibrosPorLecturas(List<Libro> listaLibros)
        {
           
            List<Libro> librosOrdenadosPorLecturas = listaLibros.OrderByDescending(libro => libro.lecturas).ToList();
            List<Libro> losCincoMasLeidos = librosOrdenadosPorLecturas.Take(5).ToList();

            listaActual = losCincoMasLeidos;
             MostrarLibros(losCincoMasLeidos);
        }

        private void CargarAutores()
        {
            // Crear una lista para almacenar los nombres de los autores únicos
            List<string> autores = new List<string>();

            autores.Add("Autores");
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

            // Agregar los autores al ComboBox
            comboBoxAutores.DataSource = autores;
            
        }

        private void LimpiarRadioButtons()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }
        private void LimpiarCombobox()
        {
            comboBoxAutores.SelectedIndex = 0;
        }
       

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is string nombreArchivo)
            {
                // Construye la ruta completa al archivo PDF
                string rutaPDF = Path.Combine(Application.StartupPath, nombreArchivo);

                try
                {
                    System.Diagnostics.Process.Start(rutaPDF);
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    // Manejar la excepción si no se puede abrir el archivo
                    MessageBox.Show($"Error al abrir el archivo: {ex.Message}");
                }
            }
        }
        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnMenuGenero_Click(object sender, EventArgs e)
        {
            panelLibros.Controls.Clear();
            MostrarLibrosGenero(listaLibros, "novela");
            groupBoxGenero.Visible = true;           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                LimpiarCombobox();
               // panelLibros.Controls.Clear();
                
                // Obtener el género del texto del RadioButton en minusculas
                string generoSeleccionado = radioButton.Text.ToLower(); 
                MostrarLibrosGenero(listaLibros, generoSeleccionado );
                
            }
        }

        private void comboBoxAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el autor seleccionado en el ComboBox
            string autorSeleccionado =  comboBoxAutores.Text;           

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

        private void groupBoxGenero_Enter(object sender, EventArgs e)
        {

        }

        private void btnMenuCatalogo_Click(object sender, EventArgs e)
        {
            LimpiarCombobox();
            LimpiarRadioButtons();
            MostrarLibros(listaLibros);
        }

        private void btnMenuUltimos_Click(object sender, EventArgs e)
        {
            LimpiarCombobox();
            LimpiarRadioButtons();
            MostrarLibrosPorFecha(listaLibros);
        }

        private void btnMenuLeidos_Click(object sender, EventArgs e)
        {
            LimpiarCombobox();
            LimpiarRadioButtons();
            MostrarLibrosPorLecturas(listaLibros);
        }

        private void FormMenu_ResizeEnd(object sender, EventArgs e)
        {
                       
             MostrarLibros(listaActual);
                                 
        }

       
        private void FormMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
               
                MostrarLibros(listaActual);

            }
            

        }
    }
}


