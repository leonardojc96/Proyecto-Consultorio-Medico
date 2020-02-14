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

namespace Proyecto_Consultorio_Medico.Vistas.Medicos
{
    public partial class AltaMedico : Plantillas.PlantillaAlta
    {
        public AltaMedico(): base("Medicos")
        {
            InitializeComponent();
        }

        private void AltaMedico_Load(object sender, EventArgs e)
        {
        }
    }
}
