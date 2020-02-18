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

namespace Proyecto_Consultorio_Medico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicioadores.FormInicio(this);

            if (Validaciones.FormularioNoAbierto("Menu"))
            {
                Vistas.Menu menu = new Vistas.Menu();
                menu.MdiParent = this;
                menu.Show();
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaMedico"))
            {
                Vistas.Medicos.AltaMedico altaMedico = new Vistas.Medicos.AltaMedico();
                altaMedico.MdiParent = this;
                altaMedico.Show();
            }
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("ListaMedicos"))
            {
                Vistas.Medicos.ListaMedicos lista = new Vistas.Medicos.ListaMedicos();
                lista.MdiParent = this;
                lista.Show();
            }
        }
    }
}
