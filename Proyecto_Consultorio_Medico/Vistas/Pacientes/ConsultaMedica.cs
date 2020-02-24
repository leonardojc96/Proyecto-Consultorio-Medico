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

namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    public partial class ConsultaMedica : Plantillas.PlantillaAlta
    {
        public ConsultaMedica()
        {
            InitializeComponent();
        }

        public ConsultaMedica(string titulo) : base(titulo)
        {
            InitializeComponent();
        }

        private void ConsultaMedica_Load(object sender, EventArgs e)
        {
            Inicioadores.TextoBlanco(panelAlta);
        }

    }
}
