using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consultorio_Medico.Vistas
{
    public partial class Menu : Plantilla
    {
        public Menu(): base("Menu Principal")
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnSalir.Visible = false;
        }
    }
}
