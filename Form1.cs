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
    {        public FormLogin()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        public List<Usuario> listaUsuarios = new List<Usuario>(); //Lista de usuarios donde se almacenaran los usuarios creados
        public bool encontrado = false;//Boleano para cuando se encuentre el usuario en la base de datos

        //CLASE USUARIO Y SU CONSTRUCTOR
        public class Usuario
        {
            public int id;
            public string nombre;
            public string contrasenia;
            public Usuario(int id, string nombre, string contrasenia)
            {
                this.id = id;
                this.nombre = nombre;
                this.contrasenia = contrasenia;
            }           
        }       

        //METODO CARGA DE USUARIOS - Se ejecuta cuando inicia el formulario y cada vez que se agrega un usuario nuevo
        public void CargarUsuarios()
        {
            //Using y StreamReader para leer la base de datos y luego cerrar el StreamReader
            using (StreamReader reader = new StreamReader(Environment.CurrentDirectory + "\\BDUsuarios.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)//Leemos la base linea a linea hasta la ultima
                {
                    //por cada linea, armamos un array con la información almacenada(id, nombre, contraseña) y luego lo descomponemos
                    string[] campos = linea.Split(';');
                    int id = int.Parse(campos[0]);
                    string nombre = campos[1];
                    string contrasenia = campos[2];
                    //con el array descompuesto creamos un nuevo usuario
                    Usuario nuevoUsuario = new Usuario(id, nombre, contrasenia);
                    listaUsuarios.Add(nuevoUsuario);//lo agregamos a la lista de usuarios              
                }
            }
        }

        //EVENTO BOTON INGRESO
        private void BtnLoginIngresar_Click(object sender, EventArgs e)
        {            
            if (textBoxLoginUsuario.Text != string.Empty && textBoxLoginContrasenia.Text != string.Empty)// solo ingresa a validar si los campos de usuario o contraseña no estan en blanco
            {        
                foreach(Usuario usuario in listaUsuarios)//por cada usuario almacenado en la base
                {
                    if (usuario.nombre == textBoxLoginUsuario.Text && usuario.contrasenia == textBoxLoginContrasenia.Text)//compara que sean igual tanto nombre de usuario como contraseña
                    {
                        encontrado = true;//si lo encuentra activa la bandera
                    }
                }
                if (encontrado)
                {
                    FormMenu miMenu = new FormMenu(textBoxLoginUsuario.Text, this);
                    this.Hide();
                    miMenu.Show();
                }
                else
                {
                    labelLoginError.Text = "Usuario o contraseña invalida";                    
                }               
            }
            else
            {
                labelLoginError.Text = "ingresar usuario y contraseña";
            }
        }

        //EVENTO AL BOTON PARA ASOCIARSE
        private void Button1_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(this);
            labelLoginError.Text = "";
            textBoxLoginUsuario.Text = "";
            textBoxLoginContrasenia.Text = "";
            formRegistro.Show();
            this.Hide();

        }

        //EVENTO CUANDO CERRAMOS EL FORMULARIO - Se cierra la app.
        private void LabelLoginCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MOVER EL FORMULARIO AL QUE LE QUITAMOS LOS BORDES
        bool clickMouse;
        int mouseX, mouseY;
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)//evento cuando está pulsado el click del mouse
        {
            clickMouse = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)//evento cuando se mueve el mouse
        {
            if(clickMouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        
        private void FormLogin_MouseUp(object sender, MouseEventArgs e)//evento cuando se libera el click del mouse
        {
            clickMouse = false;
        }
    }
}
