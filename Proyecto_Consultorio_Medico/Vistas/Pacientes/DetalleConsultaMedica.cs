using Proyecto_Consultorio_Medico.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    public partial class DetalleConsultaMedica : Plantillas.Plantilla
    {
        Modelo.ConsultaMedica consultaMedica = new Modelo.ConsultaMedica();
        Negocios.ConsultaMedicaNegocio consultaNegocio = new Negocios.ConsultaMedicaNegocio();
        Negocios.MedicosNegocio medicosNegocio = new MedicosNegocio();
        Negocios.PacienteNegocio pacienteNegocio = new PacienteNegocio();

        public DetalleConsultaMedica()
        {
            InitializeComponent();
        }

         public DetalleConsultaMedica(int idConsulta)
         {
            consultaMedica = consultaNegocio.Get(idConsulta);
            InitializeComponent();
            Modelo.Pacientes pacientes = pacienteNegocio.GetByHistorial(consultaMedica.Id_Historico);

            CambiarTitulo(consultaMedica.Fecha.Value.ToString("dd/MM/yyyy") + " - " + pacientes.Nombre + " " + pacientes.Apellido);


         }

        public void CargarDatos()
        {
            Modelo.Medicos medicos = medicosNegocio.Get(consultaMedica.Id_Medico);
            id_MedicoTextBox.Text = medicos.Nombre + " " + medicos.Apellido;
            try
            {
                txtFechaProx.Text = consultaMedica.FechaProxConsulta.Value.ToString("dd/MM/yyyy");

            }
            catch (Exception)
            {
            }
            sintomasTextBox.Text = consultaMedica.Sintomas;
            diagnosticoTextBox.Text = consultaMedica.Diagnostico;
            medicacionSugeridaTextBox.Text = consultaMedica.MedicacionSugerida;
            observacionesTextBox.Text = consultaMedica.Observaciones;
            estudiosSolicitadosTextBox.Text = consultaMedica.EstudiosSolicitados;
            estudiosResibidosTextBox.Text = consultaMedica.EstudiosResibidos;
            resultadosEstudiosResibidosTextBox.Text = consultaMedica.ResultadosEstudiosResibidos;
            richTxtNotas.Text = consultaMedica.Notas;

        }

        private void DetalleConsultaMedica_Load(object sender, EventArgs e)
        {
            this.CancelButton = btnSalir;
            pdfEstudios.src = consultaMedica.Estudios;
            Inicioadores.TextoBlanco(panel1);
            Inicioadores.Labels(lblEstudios);

            CargarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pdfEstudios_OnError(object sender, EventArgs e)
        {

        }
    }
}
