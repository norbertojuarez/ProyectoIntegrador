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
    public partial class FormAdministrador : Form
    {
        private FormMenu formMenu;
        public FormAdministrador(FormMenu formMenu)
        {
            InitializeComponent();
            textBoxId.ReadOnly = true;
            textBoxId.Enabled = false;          
            this.formMenu = formMenu;
        }

        public string rutaCompletaImagen;
        public string rutaCompletaPdf;
        public string nombreImagen;
        public string nombrePdf;        

        //METODO PARA SUBIR LIBROS DESDE LOCAL O RED A LA BASE DE DATOS DE LA APP
        private void SubirLibro()
        {          
            Console.WriteLine(textBoxImagen.Text);
            Console.WriteLine(textBoxLibro.Text);
            string rutaimagen = "Image/" + textBoxImagen.Text;
            string rutapdf = "Pdf/"+textBoxLibro.Text;
            try
            {
                File.Copy(rutaCompletaImagen, rutaimagen, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe imagen con ese nombre en el proyecto, verificar si exite libro en biblioteca o cambiar nombre de imagen");

                return;
            }

            try
            {
                File.Copy(rutaCompletaPdf, rutapdf, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe Pdf con ese nombre en el proyecto, verificar si exite libro en biblioteca o cambiar nombre de Pdf");
                File.Delete(rutaimagen);

                return;
            }

            textBoxId.Text = (formMenu.identificador + 1).ToString();
            formMenu.identificador++;
                    
            int id = int.Parse(textBoxId.Text);            
            string titulo = textBoxTitulo.Text;
            string autor = textBoxAutor.Text;
            string rutaImg = "Image/"+textBoxImagen.Text;
            string rutaLib = "Pdf/"+textBoxLibro.Text;
            string genero = comboBox1.SelectedItem.ToString();
            DateTime fecha = DateTime.Today;
            int lecturas = 0;

            FormMenu.Libro nuevoLibro = new FormMenu.Libro(id, titulo, autor, rutaImg, rutaLib, genero, fecha, lecturas);

            formMenu.listaLibros.Add(nuevoLibro);
            string rutaArchivo = Environment.CurrentDirectory + "\\Libros.txt";
            Console.WriteLine(rutaCompletaImagen);
            Console.WriteLine(rutaCompletaPdf);                      

            GuardarListaLibros(formMenu.listaLibros, rutaArchivo);
            MessageBox.Show("Libro cargado con exito");
            this.Close();

        }

        //METODO PARA ESCRIBIR LA LISTA ACTUALIZADA DE LIBROS EN LA BASE DE DATOS
        static void GuardarListaLibros(List<FormMenu.Libro> lista, string rutaArchivo)
        {

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                foreach (FormMenu.Libro libro in lista)
                {
                    writer.WriteLine($"{libro.id};{libro.titulo};{libro.autor};{libro.rutaImg};{libro.rutaPdf};{libro.categoria};{libro.fecha};{libro.lecturas}");
                }
            }
        }  

        //EVENTO QUE MUESTRA EL FORMULARIO DEL MENU AL CERRAR ESTE FORMULARIO
        private void FormAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMenu.Show();           
        }

        //EVENTO PARA CARGAR LA IMAGEN SELECCIONADA DESDE UBICACION LOCAL
        private void BtnAgregarImagen_click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxImagen.Text = Path.GetFileName(openFileDialog1.FileName);
                nombreImagen = Path.GetFileName(openFileDialog1.FileName);
                rutaCompletaImagen = openFileDialog1.FileName;
            }
        }

        //EVENTO PARA CARGAR LOS PDF DESDE UBICACION LOCAL
        private void BtnAgregarPdf_click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBoxLibro.Text = Path.GetFileName(openFileDialog2.FileName);
                nombrePdf = Path.GetFileName(openFileDialog2.FileName);
                rutaCompletaPdf = openFileDialog2.FileName;
            }
        }

        //EVENTO DEL BOTON AGREGAR LIBRO PARA SUBIR LOS LIBROS CARGADOS
        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {          
            SubirLibro();
        }    
    }
}
