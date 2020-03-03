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
    public partial class ConsultaMedica : Plantillas.PlantillaAlta
    {
        ConsultaMedicaNegocio consultaMedicaNegocio = new ConsultaMedicaNegocio();
        MedicosNegocio medicosNegocio = new MedicosNegocio();
        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        Modelo.ConsultaMedica consulta = new Modelo.ConsultaMedica();
        Modelo.Medicos medicos = new Modelo.Medicos();
        Modelo.Pacientes pacientes = new Modelo.Pacientes();

        public ConsultaMedica()
        {
            InitializeComponent();
        }

        public ConsultaMedica(string titulo, int idConsulta) : base(titulo)
        {
            consulta = consultaMedicaNegocio.Get(idConsulta);
            medicos = medicosNegocio.Get(consulta.Id_Medico);
            var pac = pacienteNegocio.GetByHistorial(consulta.Id_Historico);
            pacientes = pacienteNegocio.Get(pac.Id);

            InitializeComponent();
        }

        

        private void ConsultaMedica_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            Inicioadores.TextoBlanco(panelAlta);
            CambiarTitulo("Consulta medica: "+pacientes.Nombre + " " + pacientes.Apellido);

            id_MedicoTextBox.Text = medicos.Nombre + " " + medicos.Apellido;
            txtPaciente.Text = pacientes.Nombre + pacientes.Apellido;
            consulta.Estado = "En proceso";
        }

        private void btnEstudios_Click(object sender, EventArgs e)
        {
            openEstudios.FileName = "";
            openEstudios.Filter = "Archivos PDF | *.pdf";
            openEstudios.RestoreDirectory = true;
            if (openEstudios.ShowDialog() == DialogResult.OK && openEstudios.FileName != "")
            {
                string dir = openEstudios.FileName;
                estudiosTextBox.Text = openEstudios.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            consulta.Diagnostico = diagnosticoTextBox.Text;
            consulta.Estado = "Finalizado";
            consulta.Estudios = GuardarEstudios();
            consulta.EstudiosResibidos = estudiosResibidosTextBox.Text;
            consulta.EstudiosSolicitados = estudiosSolicitadosTextBox.Text;
            consulta.Fecha = DateTime.Now;
            consulta.FechaProxConsulta = fechaProxConsultaDateTimePicker.Value;
            consulta.Notas = rtxtNotas.Text;
            consulta.Observaciones = observacionesTextBox.Text;
            consulta.Sintomas = sintomasTextBox.Text;
            consulta.MedicacionSugerida = medicacionSugeridaTextBox.Text;

            consultaMedicaNegocio.Update(consulta);
        }

        private string GuardarEstudios()
        {
            string destino = "";
            if (estudiosTextBox.Text != "")
            {
                destino = Path.Combine(Application.StartupPath, string.Format("Archivos\\{0}", Path.GetFileName(estudiosTextBox.Text)));
                if (File.Exists(destino))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre");
                }
                else
                    File.Copy(estudiosTextBox.Text, destino);
            }

            return destino;
        }
    }
}
