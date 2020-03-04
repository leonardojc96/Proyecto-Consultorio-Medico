using Proyecto_Consultorio_Medico.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Inicioadores.TextoBlanco(panel1);
            
            CargarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        private void pdfEstudios_OnError(object sender, EventArgs e)
        {

=======
        private void btnEstudios_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(consultaMedica.Estudios))
            {
                try
                {
                    Process.Start(consultaMedica.Estudios);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo abrir el pdf");
                }
            }
            else MessageBox.Show("No se cargaron estudios de la consulta");
>>>>>>> e0b9f36d1e60a02b4ccbb424331b06cbaadbcf9f
        }
    }
}
