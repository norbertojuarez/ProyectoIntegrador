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
            labelMenuBienvenida.Text = bienvenida + " bienvenido a la Biblioteca";
        }

        public class Libro
        {
            public int id;
            public string titulo;
            public string autor;
            public string rutaImg;
            public string rutaPdf;
            public Libro(int id, string titulo, string autor, string rutaImg, string rutaPdf)
            {
                this.id = id;
                this.titulo = titulo;
                this.autor = autor;
                this.rutaImg = rutaImg;
                this.rutaPdf = rutaPdf;
            }

        }

        List<Libro> CrearLista()
        {
            //Crear lista de libros
            List<Libro> listaLibros = new List<Libro>();

            //Crear los objetos libro
            Libro libro1 = new Libro(1, "Harry Potter y la piedra filosofal", "J.K. Rowling", "Image/harry_potter.jpg", "Pdf/harry_potter_piedra_filosofal.pdf");
            Libro libro2 = new Libro(2, "1984", "George Orwell", "Image/1984.jpg", "Pdf/1984.pdf");
            Libro libro3 = new Libro(3, "Crónicas marcianas", "Ray Bradbury", "Image/cronicas_marcianas.jpg", "Pdf/cronicas_marcianas.pdf");
            Libro libro4 = new Libro(4, "Don Quijote de la Mancha", "Miguel de Cervantes", "Image/don_quijote.jpg", "Pdf/don_quijote.pdf");
            Libro libro5 = new Libro(5, "El Hobbit", "J.R.R. Tolkien", "Image/el_hobbit.jpg", "Pdf/el_hobbit.pdf");
            Libro libro6 = new Libro(6, "Crimen y castigo", "Fyodor Dostoevsky", "Image/crimen_castigo.jpg", "Pdf/crimen_y_castigo.pdf");
            Libro libro7 = new Libro(7, "Cien años de soledad", "Gabriel García Márquez", "Image/soledad.jpg", "Pdf/cien_anios_de_soledad.pdf");
            Libro libro8 = new Libro(8, "El señor de los anillos", "J.R.R. Tolkien", "Image/senor_anillos.jpg", "Pdf/el_senor_de_los_anillos.pdf");
            Libro libro9 = new Libro(9, "El código Da Vinci", "Dan Brown", "Image/codigo_da_vinci.jpg", "Pdf/el_codigo_da_vinci.pdf");
            Libro libro10 = new Libro(10, "Los juegos del hambre", "Suzanne Collins", "Image/juegos_del_hambre.jpg", "Pdf/los_juegos_del_hambre.pdf");
            Libro libro11 = new Libro(11, "El alquimista", "Paulo Coelho", "Image/el_alquimista.jpg", "Pdf/el_alquimista.pdf");
            Libro libro12 = new Libro(1, "Harry Potter y la piedra filosofal", "J.K. Rowling", "Image/harry_potter.jpg", "Pdf/harry_potter_piedra_filosofal.pdf");
            Libro libro13 = new Libro(2, "1984", "George Orwell", "Image/1984.jpg", "Pdf/1984.pdf");
            Libro libro14= new Libro(3, "Crónicas marcianas", "Ray Bradbury", "Image/cronicas_marcianas.jpg", "Pdf/cronicas_marcianas.pdf");
            Libro libro15 = new Libro(4, "Don Quijote de la Mancha", "Miguel de Cervantes", "Image/don_quijote.jpg", "Pdf/don_quijote.pdf");
            Libro libro16= new Libro(5, "El Hobbit", "J.R.R. Tolkien", "Image/el_hobbit.jpg", "Pdf/el_hobbit.pdf");
            Libro libro17= new Libro(6, "Crimen y castigo", "Fyodor Dostoevsky", "Image/crimen_castigo.jpg", "Pdf/crimen_y_castigo.pdf");
            Libro libro18= new Libro(7, "Cien años de soledad", "Gabriel García Márquez", "Image/soledad.jpg", "Pdf/cien_anios_de_soledad.pdf");
            Libro libro19= new Libro(8, "El señor de los anillos", "J.R.R. Tolkien", "Image/senor_anillos.jpg", "Pdf/el_senor_de_los_anillos.pdf");
            Libro libro20= new Libro(9, "El código Da Vinci", "Dan Brown", "Image/codigo_da_vinci.jpg", "Pdf/el_codigo_da_vinci.pdf");
            Libro libro21 = new Libro(10, "Los juegos del hambre", "Suzanne Collins", "Image/juegos_del_hambre.jpg", "Pdf/los_juegos_del_hambre.pdf");
            Libro libro22 = new Libro(11, "El alquimista", "Paulo Coelho", "Image/el_alquimista.jpg", "Pdf/el_alquimista.pdf");

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
            // Definimos las propiedades del PictureBox
            int anchoPictureBox = 65; 
            int altoPictureBox = 110;  
            int columnas = 6;
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
        }

        private void PictureBox_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
    }
}
