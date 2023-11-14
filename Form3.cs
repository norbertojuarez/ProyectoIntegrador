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
    public partial class FormRegistro : Form
    {
        private Form formularioLogin;
        public FormRegistro(Form login)
        {
            InitializeComponent();
            this.formularioLogin = login;
        }
       
        
      
        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {          

            //Agregar usuarios a la base
            if (textBoxRegistroUsuario.Text != string.Empty && textBoxRegistroContrasenia.Text != string.Empty) 
            {
                string baseUsuarios = "Usuario: " + textBoxRegistroUsuario.Text + " Contraseña: " + textBoxRegistroContrasenia.Text;
                StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\BDUsuarios.txt");
                string texto = sr.ReadToEnd();
                sr.Close();

                if (!texto.Contains("Usuario: " + textBoxRegistroUsuario.Text + " "))
                {                   
                    StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\BDUsuarios.txt", append: true);
                    sw.WriteLine(baseUsuarios);
                    sw.Close();
                    labelRegistroError.Text = "";
                    textBoxRegistroUsuario.Text = "";
                    textBoxRegistroContrasenia.Text = "";
                    labelRegistroExitoso.Text = "USUARIO CREADO CON EXITO!";
                    btnRegistroAceptar.Visible = true;
                    btnRegistroAsociarse.Visible = false;                 
                    
                }
                else
                    labelRegistroError.Text = "USUARIO YA EXISTENTE";
            }
            else
                
                labelRegistroError.Text = "INGRESE USUARIO Y CONTRASEÑA VALIDOS";
        }

        private void btnRegistroAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioLogin.Show();
        }

        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formularioLogin.Show();
        }
    }
}
