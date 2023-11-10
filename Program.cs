using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegrador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

        }
    }

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

        public override string ToString()
        {
            return "Usuario: " + nombre + " Contraseña: " + contrasenia + "\n";
        }
    }

    
}
