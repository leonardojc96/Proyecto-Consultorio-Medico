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
        HistorialNegocios historialNegocio = new HistorialNegocios();
        HistorialConsultas historial = new HistorialConsultas();
        ICollection<Modelo.ConsultaMedica> ConsultasListas = new List<Modelo.ConsultaMedica>();
        Modelo.ConsultaMedica consulta = new Modelo.ConsultaMedica();
        public InfoPacientes()
        {
            InitializeComponent();
        }
        public InfoPacientes(int id)
        {
           paciente = pacienteNegocio.Get(id);
            InitializeComponent();
            CargarFoto(paciente.Foto);
            historial = historialNegocio.Get(id);

        }
        //public void CargaConsultas(ICollection<HistorialConsultas> datos)
        //{
        //    ICollection<ConsultaMedica> consultaMedicaModeloLista = new List<ConsultaMedica>();
        //    Negocios.ConsultaMedicaNegocio consNegocio = new ConsultaMedicaNegocio();
        //    consultaMedicaModeloLista = consNegocio.Get
        //}
        private void InfoPacientes_Load(object sender, EventArgs e)
        {
            Inicioadores.TextoBlanco(panelLabels);
            Inicioadores.DataGrid(dgvConsultas);
           
            MostrarDatos();
            CargaDgv();

        }

        public void CargaDgv()
        {
            ConsultasListas = new List<Modelo.ConsultaMedica>();
            dgvConsultas.Rows.Clear();
            int id = historial.Id;
            ConsultasListas = consulta.GetByIdHistorio(id);


            foreach (var item in ConsultasListas)
            {
                if (item.Estado == "Finalizado")
                {
                    object[] elementos =
                    {
                    item.Id,
                    item.Observaciones,
                    item.Fecha.Value,
                    item.Medicos.Nombre + " " + item.Medicos.Apellido
                };
                    dgvConsultas.Rows.Insert(0, elementos);
                }
            }
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
            Vistas.Pacientes.Turnos nuevoturno = new Turnos(paciente.Id);
            nuevoturno.MdiParent = this.Parent.FindForm();
            nuevoturno.Show();

        }

        private void dgvConsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Vistas.Pacientes.DetalleConsultaMedica detalleConsulta = new DetalleConsultaMedica(int.Parse(dgvConsultas.Rows[e.RowIndex].Cells[0].Value.ToString()));
                detalleConsulta.MdiParent = this.Parent.FindForm();
                detalleConsulta.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
