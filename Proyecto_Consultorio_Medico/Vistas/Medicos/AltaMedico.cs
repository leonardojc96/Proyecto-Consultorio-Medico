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


namespace Proyecto_Consultorio_Medico.Vistas.Medicos
{
    public partial class AltaMedico : Plantillas.PlantillaAlta
    {
        Modelo.Medicos medico = new Modelo.Medicos();
        MedicosNegocio medicosNegocio = new MedicosNegocio();
        Nespecialidades nespecialidades = new Nespecialidades();
        ConsultoriosNegocio consultoriosNegocio = new ConsultoriosNegocio();
        MedicoConsultorio medicoConsultorio = new MedicoConsultorio();
        MedicoEspecialidadNegocio medicoEspecialidadNegocio = new MedicoEspecialidadNegocio();
        int idEspecialidad;
        int idConsultorio;

        public AltaMedico(): base("Alta medico")
        {
            InitializeComponent();
        }

        private void AltaMedico_Load(object sender, EventArgs e)
        {
            Inicioadores.Labels(lblDisponibles);
            Inicioadores.DataGrid(dgvEspecialidades);
            Inicioadores.TextoBlanco(panelLabels);
            Inicioadores.TextoBlanco(panelHorarios);
            Inicioadores.ComboBox(cbEspecialidad, nespecialidades.GetEspecialidades());
            dataGridView1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validaciones.NoEsNullNiVacio(panelAlta))
            {
                medico = new Modelo.Medicos()
                {
                    Nombre = nombreTextBox.Text,
                    Apellido = apellidoTextBox.Text,
                    DNI = dNITextBox.Text,
                    Foto = fotoTextBox.Text,
                    Curricula = curriculaTextBox.Text,
                    Matricula = matriculaTextBox.Text,
                    FechaNac = fechaNacDateTimePicker.Value,
                    CantidadTurnos = int.Parse(cantidadTurnosTextBox.Text),
                    ContactoAux = contactoAuxTextBox.Text,
                    Direccion = direccionTextBox.Text,
                    Telefono = telefonoTextBox.Text,
                };

                medicosNegocio.SaveMedico(medico);

                foreach (DataGridViewRow item in dgvEspecialidades.Rows)
                {
                    Modelo.MedicoEspecialidad medicoEspecialidad = new MedicoEspecialidad();
                    medicoEspecialidad.Id_Especialidad = int.Parse(item.Cells[0].Value.ToString());
                    medicoEspecialidad.Id_Medico = medico.Id;

                    if (!medicoEspecialidadNegocio.Save(medicoEspecialidad))
                    {
                        MessageBox.Show("Hubo un error");
                    }
                }

                foreach (DataGridViewRow item in dgvHorarios.Rows)
                {
                    TimeSpan Hentrada;
                    TimeSpan.TryParseExact(item.Cells["H_Entrada"].Value.ToString(), @"mm\:ss", null, out Hentrada);
                    TimeSpan HSalida;
                    TimeSpan.TryParseExact(item.Cells["H_Salida"].Value.ToString(), @"mm\:ss", null, out HSalida);

                    medicoConsultorio = new MedicoConsultorio()
                    {
                        Id_Medico = medico.Id,
                        Id_Consultorio = (int)item.Cells["idCon"].Value,
                        H_Entrada = Hentrada,
                        H_Salida = HSalida,
                        Lunes = (bool)item.Cells["Lu"].Value,
                        Martes = (bool)item.Cells["Ma"].Value,
                        Miercoles = (bool)item.Cells["Mi"].Value,
                        Jueves = (bool)item.Cells["Ju"].Value,
                        Viernes = (bool)item.Cells["Vi"].Value,
                        Sabado = (bool)item.Cells["Sa"].Value,
                        Domingo = (bool)item.Cells["Do"].Value,
                    };

                    

                    MedicoConsultorioNegocio medicoConsultorioNegocio = new MedicoConsultorioNegocio();

                    medicoConsultorioNegocio.Save(medicoConsultorio);
                }
            }
        }

        private void cbEspecialidad_DropDownClosed(object sender, EventArgs e)
        {
            if (cbConsultorios.Enabled == false)
            {
                cbConsultorios.Enabled = true;
                btnAgregarHorario.Enabled = true;
            }

            idEspecialidad = int.Parse(cbEspecialidad.SelectedValue.ToString());

            Inicioadores.ComboBox(cbConsultorios, consultoriosNegocio.GetByEspecialidad(idEspecialidad));
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            Modelo.Especialidades especialid = nespecialidades.Get(idEspecialidad);
            object[] elemetos =
            {
                especialid.Id,
                especialid.Nombre
            };

            dgvEspecialidades.Rows.Insert(0, elemetos);
        }

        private void cbConsultorios_DropDownClosed(object sender, EventArgs e)
        {
            idConsultorio = int.Parse(cbConsultorios.SelectedValue.ToString());
            dgvDisponibles.Rows.Clear();
            //dgvDisponibles.DataSource = medicoConsultorio.GetByConsultorio(idConsultorio);

            foreach (var item in medicoConsultorio.GetByConsultorio(idConsultorio))
            {
                Modelo.Medicos med = medicosNegocio.Get(item.Id_Medico);
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
                    med.Apellido +" "+med.Nombre
                };

                dgvDisponibles.Rows.Insert(0, elementos);
            }
        }

        public void CargarData(ICollection<object> datos)
        {
            
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            if (idConsultorio != 0)
            {
                object[] elementos =
                {
                    H_Entradatxt.Text,
                    H_Salidatxt.Text,
                    lunesCheckBox.Checked,
                    martesCheckBox.Checked,
                    miercolesCheckBox.Checked,
                    juevesCheckBox.Checked,
                    viernesCheckBox.Checked,
                    sabadoCheckBox.Checked,
                    domingoCheckBox.Checked,
                    consultoriosNegocio.Get(idConsultorio).Nombre,
                    idConsultorio,
                };

                dgvHorarios.Rows.Insert(0, elementos);
            }
            
        }

        private void cbConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
