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
        private FormLogin formularioLogin;
        public FormRegistro(FormLogin login)
        {
            InitializeComponent();
            this.formularioLogin = login;
        }

        //METODO PARA REGISTRAR USUARIOS NUEVOS
        private void RegistrarUsuarios()
        {
            if (textBoxRegistroUsuario.Text != string.Empty && textBoxRegistroContrasenia.Text != string.Empty)
            {
                int Id = formularioLogin.listaUsuarios.Count()+1;
                string nombre = textBoxRegistroUsuario.Text;
                string contrasenia = textBoxRegistroContrasenia.Text;
                FormLogin.Usuario nuevoUsuario = new FormLogin.Usuario(Id, nombre, contrasenia);

                bool usuarioExistente = false;
                foreach (FormLogin.Usuario usuario in formularioLogin.listaUsuarios)
                {
                    if (usuario.nombre == nuevoUsuario.nombre)
                    {
                        usuarioExistente = true;
                    }
                }
                if (!usuarioExistente)
                {
                    formularioLogin.listaUsuarios.Add(nuevoUsuario);                  
                    string rutaArchivo = Environment.CurrentDirectory + "\\BDUsuarios.txt";
                    using (StreamWriter writer = new StreamWriter(rutaArchivo))
                    {
                        foreach (FormLogin.Usuario usuario in formularioLogin.listaUsuarios)
                        {
                            writer.WriteLine($"{usuario.id};{usuario.nombre};{usuario.contrasenia}");
                        }
                    }

                    labelRegistroError.Text = "";
                    textBoxRegistroUsuario.Text = "";
                    textBoxRegistroContrasenia.Text = "";
                    labelRegistroExitoso.Text = "USUARIO CREADO CON EXITO!";
                    btnRegistroAceptar.Visible = true;
                    btnRegistroAsociarse.Visible = false;
                }
                else
                {
                    labelRegistroError.Text = "USUARIO YA EXISTENTE";
                }
            }
            else
            {
                labelRegistroError.Text = "INGRESE USUARIO Y CONTRASEÑA VALIDOS";
            }
        }


        //EVENTO SOBRE EL BOTON ASOCIARSE      
        private void BtnRegistroAsociarse_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios();                
        }

        //EVENTO SOBRE EL BOTON ACEPTAR UNA VEZ QUE SE CREA UN NUEVO USUARIO
        private void BtnRegistroAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioLogin.Show();
        }

        //EVENTO RECUPERA EL FORMULARIO LOGIN Y OCULTA ESTE AL CERRARLO
        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formularioLogin.Show();
        }
    }
}
