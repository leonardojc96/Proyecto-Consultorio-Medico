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
    public partial class PlantillaListas : Plantilla
    {
        public PlantillaListas()
        {
            InitializeComponent();
        }

        public PlantillaListas(string titulo) : base(titulo)
        {
            InitializeComponent();
        }

        private void PlantillaListas_Load(object sender, EventArgs e)
        {
            Inicioadores.Labels(lblBuscar);
            CancelButton = btnSalir;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
