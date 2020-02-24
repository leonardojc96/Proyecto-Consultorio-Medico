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

namespace Proyecto_Consultorio_Medico.Vistas.Medicos
{
    public partial class AltaMedico : Plantillas.PlantillaAlta
    {
        int idMedicoModificar;
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
            btnEliminar.Visible = false;
            Inicioadores.Labels(lblDisponibles);
            Inicioadores.DataGrid(dgvEspecialidades);
            Inicioadores.TextoBlanco(panelLabels);
            Inicioadores.TextoBlanco(panelHorarios);
            Inicioadores.ComboBox(cbEspecialidad, nespecialidades.GetEspecialidades());
            dataGridView1.Visible = false;

            try
            {
                cbEspecialidad.SelectedIndex = 1;
                cbEspecialidad.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.NoEsNullNiVacio(panelAlta))
                {
                    medico = CargarMedico();

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
                        TimeSpan.TryParseExact(item.Cells["H_Entrada"].Value.ToString(), @"hh\:mm", null, out Hentrada);
                        TimeSpan HSalida;
                        TimeSpan.TryParseExact(item.Cells["H_Salida"].Value.ToString(), @"hh\:mm", null, out HSalida);

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
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
                
            }
            
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Especialidades especialid = nespecialidades.Get(idEspecialidad);
                object[] elemetos =
                {
                especialid.Id,
                especialid.Nombre
            };

                dgvEspecialidades.Rows.Insert(0, elemetos);
            }catch(Exception)
            {
                MessageBox.Show("No seleccionó ninguna especialidad o no hay ninguna cargada");
            }
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
            if (cbConsultorios.SelectedValue.ToString() != "0")
            {
                try
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
                catch (Exception)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFoto.FileName = "";
            openFoto.Filter = "Archivos de Imagen | *.jpg";
            openFoto.RestoreDirectory = true;
            if (openFoto.ShowDialog() == DialogResult.OK && openFoto.FileName != "")
            {
                string dir = openFoto.FileName;
                Bitmap picture = new Bitmap(dir);
                picMuestraFoto.Image = (Image)picture;
                fotoTextBox.Text = openFoto.FileName;
            }
        }

        private string GuardarFoto()
        {
            string destino = "";
            if (fotoTextBox.Text != "")
            {
                destino = Path.Combine(Application.StartupPath, string.Format("Imagenes\\{0}", Path.GetFileName(fotoTextBox.Text)));
                if (File.Exists(destino))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre");
                }
                else
                    File.Copy(fotoTextBox.Text, destino);
            }

            return destino;
        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecialidad.SelectedValue.ToString() != "0")
            {
                try
                {
                    if (cbConsultorios.Enabled == false)
                    {
                        cbConsultorios.Enabled = true;
                        btnAgregarHorario.Enabled = true;
                    }

                    idEspecialidad = int.Parse(cbEspecialidad.SelectedValue.ToString());

                    Inicioadores.ComboBox(cbConsultorios, consultoriosNegocio.GetByEspecialidad(idEspecialidad));
                }
                catch (Exception)
                {
                    cbConsultorios.Enabled = false;
                    btnAgregarHorario.Enabled = false;
                }
                
            }
        }

        public void ModificarMedico(int id)
        {
            idMedicoModificar = id;
            btnAgregar.Enabled = false;

            Modelo.Medicos medicoEditar = medicosNegocio.Get(id);
            nombreTextBox.Text = medicoEditar.Nombre;
            apellidoTextBox.Text = medicoEditar.Apellido;
            dNITextBox.Text = medicoEditar.DNI;
            direccionTextBox.Text = medicoEditar.Direccion;
            cantidadTurnosTextBox.Text = medicoEditar.CantidadTurnos.ToString();
            fechaNacDateTimePicker.Value = medicoEditar.FechaNac.Value;
            matriculaTextBox.Text = medicoEditar.Matricula;
            telefonoTextBox.Text = medicoEditar.Telefono;
            contactoAuxTextBox.Text = medicoEditar.ContactoAux;
            fotoTextBox.Text = medicoEditar.Foto;
            curriculaTextBox.Text = medicoEditar.Curricula;
            foreach (var item in medicoEspecialidadNegocio.GetByMedico(id))
            {
                Modelo.Especialidades especialidad = nespecialidades.Get(item.Id_Especialidad);
                object[] elementos =
                {
                    especialidad.Id,
                    especialidad.Nombre
                };

                dgvEspecialidades.Rows.Insert(0, elementos);
            }

            foreach (var item in medicoConsultorio.GetByMedico(id))
            {
                Modelo.Consultorios con = consultoriosNegocio.Get(item.Id_Consultorio);
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
                            con.Id
                 };

                dgvHorarios.Rows.Insert(0, elementos);
            }
            
        }

        public Modelo.Medicos CargarMedico() 
        {
            string pathFoto = GuardarFoto();
            string pathCurricula = GuardarCurricula();

            return medico = new Modelo.Medicos()
            {
                Nombre = nombreTextBox.Text,
                Apellido = apellidoTextBox.Text,
                DNI = dNITextBox.Text,
                Foto = pathFoto,
                Curricula = pathCurricula,
                Matricula = matriculaTextBox.Text,
                FechaNac = fechaNacDateTimePicker.Value,
                CantidadTurnos = int.Parse(cantidadTurnosTextBox.Text),
                ContactoAux = contactoAuxTextBox.Text,
                Direccion = direccionTextBox.Text,
                Telefono = telefonoTextBox.Text,
            };
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            medico = CargarMedico();

            if (medicosNegocio.Update(idMedicoModificar, medico))
                MessageBox.Show("Se modifico el medico");
            else
                MessageBox.Show("No se pudo guardar");

            foreach (DataGridViewRow item in dgvHorarios.Rows)
            {
                TimeSpan Hentrada;
                TimeSpan.TryParseExact(item.Cells["H_Entrada"].Value.ToString(), @"hh\:mm", null, out Hentrada);
                TimeSpan HSalida;
                TimeSpan.TryParseExact(item.Cells["H_Salida"].Value.ToString(), @"hh\:mm", null, out HSalida);

                medicoConsultorio = new MedicoConsultorio()
                {
                    Id_Medico = idMedicoModificar,
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
                if (!medico.MedicoConsultorio.Contains(medicoConsultorio))
                    medicoConsultorioNegocio.Save(medicoConsultorio);
            }
        }

        private void btnCurricula_Click(object sender, EventArgs e)
        {
            openCurricula.FileName = "";
            openCurricula.Filter = "Archivos PDF | *.pdf";
            openCurricula.RestoreDirectory = true;
            if (openCurricula.ShowDialog() == DialogResult.OK && openCurricula.FileName != "")
            {
                string dir = openCurricula.FileName;
                curriculaTextBox.Text = openCurricula.FileName;
            }
        }

        public string GuardarCurricula()
        {
            string destino = "";
            if (curriculaTextBox.Text != "")
            {
                destino = Path.Combine(Application.StartupPath, string.Format("Archivos\\{0}", Path.GetFileName(curriculaTextBox.Text)));
                if (File.Exists(destino))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre");
                }
                else
                    File.Copy(curriculaTextBox.Text, destino);
            }

            return destino;
        }
    }
}
