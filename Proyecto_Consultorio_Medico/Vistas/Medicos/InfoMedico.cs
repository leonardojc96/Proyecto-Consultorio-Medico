using Proyecto_Consultorio_Medico.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        MedicoEspecialidadNegocio medicoEspecialidad = new MedicoEspecialidadNegocio();
        MedicoConsultorioNegocio medicoConsultorioNegocio = new MedicoConsultorioNegocio();
        ConsultoriosNegocio consultoriosNegocio = new ConsultoriosNegocio();
        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        HistorialNegocios historialNegocios = new HistorialNegocios();
        ConsultaMedicaNegocio consultaMedicaNegocio = new ConsultaMedicaNegocio();

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
            Inicioadores.DataGrid(dgvEspecialidades);
            Inicioadores.DataGrid(dgvConsultasPendientes);
            Inicioadores.Labels(lblEspecialidades);
            Inicioadores.Labels(lblHorarios);
            Inicioadores.Labels(lblPacientes);
            Inicioadores.TextoBlanco(panelLabels);
            CargarDatos();
            CancelButton = btnSalir;
        }

        public void CargarDatos()
        {
            txtApellido.Text = medicos.Apellido;
            txtNombre.Text = medicos.Nombre;
            txtDni.Text = medicos.DNI;
            txtDireccion.Text = medicos.Direccion;
            txtFecha.Text = medicos.FechaNac.Value.Year.ToString();
            txtMatricula.Text = medicos.Matricula;
            txtTelefono.Text = medicos.Telefono;
            txtCantidadTurnos.Text = medicos.CantidadTurnos.ToString();
            txtContactoAux.Text = medicos.ContactoAux;

            // carga de especialidades
            foreach (var item in medicoEspecialidad.GetByMedico(medicos.Id))
            {
                object[] elementos =
                {
                    item.Especialidades.Nombre
                };

                dgvEspecialidades.Rows.Insert(0, elementos);
            }

            //carga horarios
            foreach (var item in medicoConsultorioNegocio.GetByMedico(medicos.Id))
            {
                Modelo.Consultorios consultorio = consultoriosNegocio.Get(item.Id_Consultorio);
                object[] elementos =
                {
                    item.H_Entrada,
                    item.H_Salida,
                    item.Lunes,
                    item.Martes,
                    item.Miercoles,
                    item.Jueves,
                    item.Viernes,
                    item.Sabado,
                    item.Domingo,
                    consultorio.Nombre +" - "+consultorio.Especialidades.Nombre 
                };

                dgvHorarios.Rows.Insert(0, elementos);
            }

            // carga turnos pendientes
            try
            {
                foreach (var item in historialNegocios.GetTunosPendientes(medicos.Id))
                {
                    Modelo.Consultorios consultorios = consultoriosNegocio.Get(item.Id_Consultorio);

                    object[] elementos =
                    {
                        item.Id,
                        item.Nombre + " "+ item.Apellido,
                        item.DNI,
                        consultorios.Nombre + " "+consultorios.Especialidades.Nombre
                    };

                    dgvConsultasPendientes.Rows.Insert(0, elementos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirCurricula_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(medicos.Curricula);
            }
            catch (Exception)
            {
                MessageBox.Show("El medico no tiene curricula cargada");
            }
        }

        private void btnAbrirConsulta_Click(object sender, EventArgs e)
        {
            // todo: agregar trycatch
            try
            {


                if (dgvConsultasPendientes.CurrentRow.Index != -1)
                {
                    int index = dgvConsultasPendientes.CurrentRow.Index;
                    int idConsulta = int.Parse(dgvConsultasPendientes.Rows[index].Cells["IdConsulta"].Value.ToString());


                    if (Validaciones.FormularioNoAbierto("ConsultaMedica"))
                    {
                        Vistas.Pacientes.ConsultaMedica consultaMedica = new Pacientes.ConsultaMedica("", idConsulta);
                        consultaMedica.MdiParent = this.Parent.FindForm();
                        consultaMedica.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
