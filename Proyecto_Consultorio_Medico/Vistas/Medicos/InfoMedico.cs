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
    public partial class InfoMedico : Plantillas.PlantillaInfo
    {
        Modelo.Medicos medicos = new Modelo.Medicos();
        MedicosNegocio medicosNegocio = new MedicosNegocio();

        public InfoMedico()
        {
            InitializeComponent();
        }

        public InfoMedico(int idMedico)
        {
            medicos = medicosNegocio.Get(idMedico);
            InitializeComponent();
            CambiarTitulo(medicos.Nombre + " " + medicos.Apellido);
            CargarFoto(medicos.Foto);
        }

        private void InfoMedico_Load(object sender, EventArgs e)
        {
            
        }
    }
}
