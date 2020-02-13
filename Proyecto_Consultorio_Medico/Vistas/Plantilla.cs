using Proyecto_Consultorio_Medico.Negocios;
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
    public partial class Plantilla : Form
    {
        public Plantilla()
        {
            InitializeComponent();
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {
            Inicioadores.Plantillas(this);
        }
    }
}
