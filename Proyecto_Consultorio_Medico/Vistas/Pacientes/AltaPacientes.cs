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
    public partial class AltaPacientes : Plantillas.PlantillaAlta
    {

        Modelo.Pacientes paciente = new Modelo.Pacientes();
        

        public AltaPacientes()
        {
            InitializeComponent();
            
        }

        private void AltaPacientes_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            btnEliminar.Visible = false;
            //Inicioadores.Labels(lblDisponibles);
            //Inicioadores.DataGrid(dgvEspecialidades);
            Inicioadores.TextoBlanco(panelLabels);
            //Inicioadores.TextoBlanco(panelHorarios);
            //Inicioadores.ComboBox(cbEspecialidad, nespecialidades.GetEspecialidades());

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.NoEsNullNiVacio(panelAlta))
                {
                    paciente = CargarPaciente();
                    PacienteNegocio pac = new PacienteNegocio();
                    pac.Save(paciente);
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private string GuardarFoto()
        {
            string dest = "";
            if(fotoTextBox.Text != "")
            {
                dest = Path.Combine(Application.StartupPath, string.Format("Imagenes\\{0}", Path.GetFileName(fotoTextBox.Text)));
                if (File.Exists(dest))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre");
                }
                else
                {
                    File.Copy(fotoTextBox.Text, dest);
                }   
            }
            return dest;
        }

        public Modelo.Pacientes CargarPaciente()
        {
            string foto = GuardarFoto();
            return paciente = new Modelo.Pacientes()
            {
                Nombre = nombreTextBox.Text,
                Apellido = apellidoTextBox.Text,
                DNI = dNITextBox.Text,
                Telefono = telefonoTextBox.Text,
                FechaIngreso = fechaIngresoDateTimePicker.Value,
                FechaNac = fechaNacDateTimePicker.Value,
                ObraSocial = obraSocialTextBox.Text,
                Direccion = direccionTextBox.Text,
                Foto = foto,



            };
            

               

        
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivos de imagen | *.jpg";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                string dir = openFileDialog1.FileName;
                Bitmap picture = new Bitmap(dir);
                 
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = (Image)picture;
                fotoTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            paciente = CargarPaciente();

        }
    }
}
