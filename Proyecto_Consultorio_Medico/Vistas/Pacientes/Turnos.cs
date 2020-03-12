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
    public partial class Turnos : Plantillas.Plantilla
    {
        int MedicoId;
        Negocios.HistorialNegocios historial = new Negocios.HistorialNegocios();
        Modelo.HistorialConsultas historialModelo = new Modelo.HistorialConsultas();
        Modelo.Pacientes pacienteModelo = new Modelo.Pacientes();
        Negocios.PacienteNegocio pNegocio = new Negocios.PacienteNegocio();
        Negocios.Nespecialidades especialidadNegocio = new Negocios.Nespecialidades();
        Modelo.Especialidades esp = new Modelo.Especialidades();
        ICollection<Modelo.Especialidades> espLista = new List<Modelo.Especialidades>();
        Negocios.MedicoEspecialidadNegocio medEspecialidad = new Negocios.MedicoEspecialidadNegocio();
        ICollection<Modelo.MedicoEspecialidad> medEspLista = new List<Modelo.MedicoEspecialidad>();
        Negocios.MedicosNegocio medicosNegocio = new Negocios.MedicosNegocio();
        ICollection<Modelo.Medicos> medicosLista = new List<Modelo.Medicos>();
        Modelo.Medicos m = new Modelo.Medicos();
        ICollection<string> listaVacio = new List<string>();
        Modelo.Turnos turnoModelo = new Modelo.Turnos();
        Negocios.TurnoNegocio turnoNegocio = new Negocios.TurnoNegocio();
        Modelo.ConsultaMedica consulModelo = new Modelo.ConsultaMedica();
        Negocios.ConsultaMedicaNegocio consulNegocio = new Negocios.ConsultaMedicaNegocio();
        //Modelo.MedicoConsultorio medConsultorioModelo = new Modelo.MedicoConsultorio();
        ICollection<Modelo.MedicoConsultorio> medConsultorioModeloLista = new List<Modelo.MedicoConsultorio>();
        Negocios.MedicoConsultorioNegocio medConsultorioNegocio = new Negocios.MedicoConsultorioNegocio();
        Modelo.Consultorios consultoriosModelo = new Modelo.Consultorios();
        Negocios.ConsultoriosNegocio consultorioNegocio = new Negocios.ConsultoriosNegocio();
        
        public Turnos()
        {
            InitializeComponent();
            //espLista = especialidadNegocio.GetEspecialidades();
        }

        public Turnos(int id)
        {
            InitializeComponent();
            espLista = especialidadNegocio.GetEspecialidades();
            pacienteModelo = pNegocio.Get(id);
            btnAceptar.Enabled = false;
            CambiarTitulo("Turno para " + pacienteModelo.Apellido + " " + pacienteModelo.Nombre);
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            Inicioadores.DataGrid(dgvMedicos);
            Inicioadores.DataGrid(dgvUltimosMedicos);
            Inicioadores.Labels(lblUltimos);
            Inicioadores.Labels(lblMedicos);
            Negocios.Inicioadores.ComboBox(cmbEspecialidad, espLista);
            listaVacio.Add("");
            this.CancelButton = btnSalir;

            CargarUltimosMedicos();
        }

        public void CargarUltimosMedicos()
        {
            foreach (var item in turnoNegocio.GetLastMedicos(pacienteModelo.Id))
            {
                object[] elementos =
                {
                    item.Id,
                    item.Nombre,
                    item.Apellido
                };

                dgvUltimosMedicos.Rows.Insert(0, elementos);
            }
        }
       
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedIndex.ToString() != "-1")
            {
                
                medicosLista = new List<Modelo.Medicos>();
                medEspLista = new List<Modelo.MedicoEspecialidad>();
                int id = -1;
                try
                {
                    
                     id = int.Parse(cmbEspecialidad.SelectedValue.ToString());
                    medEspLista = medEspecialidad.GeyByEspecialidad(id);
                    RefreshData(medEspLista);
                    //foreach (var item in medEspLista)
                    //{
                    //    m.Nombre = item.Medicos.Nombre + " " + item.Medicos.Apellido;
                    //    m.Id = item.Medicos.Id;
                    //    medicosLista.Add(m);
                    //}
                    //medEspLista = medEspecialidad.GeyByEspecialidad(id);
                    // Negocios.Inicioadores.ComboBox(cmbMedicos, medEspLista);

                    //cmbMedicos.DataSource = medicosLista;
                    //cmbMedicos.DisplayMember = "Nombre";
                    //cmbMedicos.ValueMember = "Id";

                }
                catch(Exception ex)
                {
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Modelo.Medicos medicos = medicosNegocio.Get(MedicoId);
            if (medicos.CantidadTurnos - turnoNegocio.GetCantidadTurnos(MedicoId) > 0)
            {
                historialModelo = historial.Get(pacienteModelo.Id);
                int idEspecialidad = int.Parse(cmbEspecialidad.SelectedValue.ToString());
                consultoriosModelo = turnoNegocio.GetConsultoriosByMedicoYEspecialidad(MedicoId, idEspecialidad);

                if (historialModelo != null)
                {
                    turnoModelo.Id_Paciente = historialModelo.Id_Paciente;
                    turnoModelo.Id_Consultorio = consultoriosModelo.Id;
                    turnoNegocio.Save(turnoModelo);
                    consulModelo.Id_Medico = MedicoId;
                    consulModelo.Id_Historico = historialModelo.Id;
                    consulModelo.Id_Turno = GetIDTurnoByIdPaciente(historialModelo.Id_Paciente);
                    consulModelo.Estado = "Pendiente";
                    consulModelo.Fecha = DateTime.Today;

                    if (consulNegocio.Save(consulModelo))
                    {
                        MessageBox.Show("Turno asignado, por favor espere en el consultorio " + consultoriosModelo.Nombre);

                    }

                }
                else if (historialModelo == null)
                {
                    historialModelo = new Modelo.HistorialConsultas();
                    historialModelo.Id_Paciente = pacienteModelo.Id;
                    historial.Save(historialModelo);
                    btnAceptar_Click(sender, e);

                }

                this.Close();
            }
            else MessageBox.Show("El medico no tiene mas turnos disponibles hoy");
            
        }


        public void RefreshData(ICollection<Modelo.MedicoEspecialidad> datos)
        {
            dgvMedicos.Rows.Clear();
           

            foreach (var item in datos)
            {
                int cantTurnosDis = int.Parse(item.Medicos.CantidadTurnos.ToString()) - turnoNegocio.GetCantidadTurnos(item.Medicos.Id);
                object[] elementos =
                {
                    item.Medicos.Nombre,
                    item.Medicos.Apellido,
                    cantTurnosDis,
                    item.Medicos.Id
                };

                dgvMedicos.Rows.Insert(0, elementos);
            }
        }
        public void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            
            if (e.RowIndex != -1)
            {
                MedicoId = int.Parse(dgvMedicos.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }
        public int GetIDTurnoByIdPaciente(int id)
        {
            turnoModelo = turnoNegocio.GetTurnoByIdPaciente(id);
            return turnoModelo.Id;
        }
        public int GetIdConsultorio(int id)
        {
            int idConsultorio = -1;
            consultoriosModelo = new Modelo.Consultorios();
            medConsultorioModeloLista = medConsultorioNegocio.GetByMedico(id);
            foreach (var item in medConsultorioModeloLista)
            {
                if(item.Id_Consultorio == int.Parse(cmbEspecialidad.SelectedValue.ToString()))
                {
                     idConsultorio = item.Id_Consultorio;
                }
            }
            return idConsultorio;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUltimosMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;

            if (e.RowIndex != -1)
            {
                MedicoId = int.Parse(dgvUltimosMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
