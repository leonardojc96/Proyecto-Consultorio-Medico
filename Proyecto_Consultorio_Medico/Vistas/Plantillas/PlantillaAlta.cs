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
    public partial class PlantillaAlta : Plantilla
    {
        public PlantillaAlta()
        {
            InitializeComponent();
        }

        public PlantillaAlta(string titulo): base(titulo)
        {
            InitializeComponent();
        }

        private void PlantillaAlta_Load(object sender, EventArgs e)
        {
            AcceptButton = btnAgregar;
            CancelButton = btnSalir;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hacer override de este metodo para usar
        }

        public virtual void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //hacer override de este metodo para usar
        }
    }
}
