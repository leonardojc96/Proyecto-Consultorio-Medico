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

namespace Proyecto_Consultorio_Medico.Vistas.Plantillas
{
    public partial class Plantilla : Form
    {
        public Plantilla()
        {
            InitializeComponent();
        }

        public Plantilla(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {
            Inicioadores.Plantillas(this);
            Inicioadores.Header(panelHeader);
            Inicioadores.Titulo(lblTitulo);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CambiarTitulo(string titulo)
        {
            lblTitulo.Text = titulo;
        }
    }
}
