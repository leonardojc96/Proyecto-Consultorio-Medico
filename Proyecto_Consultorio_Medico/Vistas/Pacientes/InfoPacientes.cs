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
using Proyecto_Consultorio_Medico.Modelo;
using System.IO;
namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    public partial class InfoPacientes : Vistas.Plantillas.PlantillaInfo
    {
        Modelo.Pacientes paciente = new Modelo.Pacientes();
        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        public InfoPacientes()
        {
            InitializeComponent();
        }
        public InfoPacientes(int id)
        {
           paciente = pacienteNegocio.Get(id);
            InitializeComponent();
            CargarFoto(paciente.Foto);

        }

        private void InfoPacientes_Load(object sender, EventArgs e)
        {
            Inicioadores.TextoBlanco(panelLabels);
            MostrarDatos();
        }


        public void MostrarDatos()
        {
            nombreTextBox.Text = paciente.Nombre;
            apellidoTextBox.Text = paciente.Apellido;
            dNITextBox.Text = paciente.DNI;
            direccionTextBox.Text = paciente.Direccion;
            telefonoTextBox.Text = paciente.Telefono;
            obraSocialTextBox.Text = paciente.ObraSocial;
            txtFechaNac.Text = paciente.FechaNac.Value.Year.ToString();
            txtFecIngreso.Text = paciente.FechaIngreso.Year.ToString();
            txtFecUltimaVis.Text = paciente.UltimaVisita.Value.Year.ToString();
            detallesTextBox.Text = paciente.Detalles;
        }

        private void btnNuevoTur_Click(object sender, EventArgs e)
        {
            Vistas.Pacientes.NuevoTurno nuevoturno = new NuevoTurno();
            nuevoturno.MdiParent = this.Parent.FindForm();
            nuevoturno.Show();

        }
    }
}
