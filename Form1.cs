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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
             

        //evento para validar usuario y contraseña
        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            //capturar usuario y contraseña ingresada
            string usuarioingresado = "Usuario: " + textBoxLoginUsuario.Text + " Contraseña: " + textBoxLoginContrasenia.Text;
            
            //validar usuario y contraseña
            if (textBoxLoginUsuario.Text != string.Empty && textBoxLoginContrasenia.Text != string.Empty)
            {          
                bool encontrado = false;
                string line;
                //leer base de datos de usuarios y contraseñas
                StreamReader sr = new StreamReader(Environment.CurrentDirectory+"\\BDUsuarios.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string linea = line.ToString();
                    if (linea.Contains(usuarioingresado))
                    {
                        FormMenu miMenu = new FormMenu(textBoxLoginUsuario.Text);

                        this.Hide();
                        miMenu.Show();
                        
                        encontrado = true;
                    }
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

                if (!encontrado)
                    labelLoginError.Text = "Usuario o contraseña invalida";
            }
            else
            {
                labelLoginError.Text = "ingresar usuario y contraseña";                
            }
        }

        //Mover formulario sin bordes
        bool clickMouse;
        int mouseX, mouseY;
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            clickMouse = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if(clickMouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        
        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            clickMouse = false;
        }

        //evento para registrar usuarios nuevos
        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(this);
            labelLoginError.Text = "";
            textBoxLoginUsuario.Text = "";
            textBoxLoginContrasenia.Text = "";
            formRegistro.Show();
            this.Hide();

        }
        private void labelLoginCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
