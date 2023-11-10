using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            labelMenuBienvenida.Text = bienvenida + " bienvenido a la Biblioteca";
        }
    }
}
