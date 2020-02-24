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
    public partial class NuevoTurno : Form
    {
        ICollection<Modelo.MedicoEspecialidad> medesplista = new List<Modelo.MedicoEspecialidad>();
        Negocios.MedicoEspecialidadNegocio medespNegocio = new Negocios.MedicoEspecialidadNegocio();
        public NuevoTurno()
        {
            InitializeComponent();
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_centro_medicoDataSet.Consultorios' Puede moverla o quitarla según sea necesario.
            this.consultoriosTableAdapter.Fill(this.proyecto_centro_medicoDataSet.Consultorios);


        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cmbEspecialidad.SelectedIndex;
            medesplista = medespNegocio.GeyByEspecialidad(id);
            Negocios.Inicioadores.ComboBox(cmbMedicos, medesplista);
        }
    }
}
