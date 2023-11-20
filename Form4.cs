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
        

        private void SubirLibro(string rutaimagen, string rutapdf)
        {           

            Console.WriteLine(textBoxImagen.Text);
            Console.WriteLine(textBoxLibro.Text);
            rutaimagen = "Image/" + textBoxImagen.Text;
            rutapdf = "Pdf/"+textBoxLibro.Text;
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

            private void FormAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMenu.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)            {
                
                textBoxImagen.Text = Path.GetFileName(openFileDialog1.FileName);
                nombreImagen = Path.GetFileName(openFileDialog1.FileName);
                rutaCompletaImagen = openFileDialog1.FileName;            

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string rutaDestinoImagen = Path.Combine(Application.StartupPath, "Image", "Image/" + textBoxImagen.Text);
            string rutaDestinoPdf = Path.Combine(Application.StartupPath, "Pdf", "Pdf/" + textBoxLibro.Text);
            SubirLibro(rutaDestinoImagen, rutaDestinoPdf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBoxLibro.Text = Path.GetFileName(openFileDialog2.FileName);
                nombrePdf = Path.GetFileName(openFileDialog2.FileName);
                rutaCompletaPdf = openFileDialog2.FileName;

            }
        }
    }
}
