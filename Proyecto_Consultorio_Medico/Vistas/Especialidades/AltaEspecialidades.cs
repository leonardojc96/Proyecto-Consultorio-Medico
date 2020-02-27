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

namespace Proyecto_Consultorio_Medico.Vistas.Especialidades
{
    public partial class AltaEspecialidades : Plantillas.PlantillaAlta
    {
        Modelo.Especialidades especialidades = new Modelo.Especialidades();
        Nespecialidades nespecialidades = new Nespecialidades();

        public AltaEspecialidades(): base("Especialidades")
        {
            InitializeComponent();
        }

        private void AltaEspecialidades_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "id");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns.Add("Especialidad", "Especialidad");

            Inicioadores.TextoBlanco(panelAlta);

            CargarData();
        }

        public void CargarData()
        {
            dataGridView1.Rows.Clear();

            foreach (var item in nespecialidades.GetEspecialidades())
            {
                object[] elementos =
                {
                    item.Id,
                    item.Nombre
                };

                dataGridView1.Rows.Insert(0, elementos);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validaciones.NoEsNullNiVacio(panelAlta))
            {
                especialidades = new Modelo.Especialidades();

                especialidades.Nombre = nombreTextBox.Text;

                if (nespecialidades.SaveEspecialidad(especialidades))
                {
                    CargarData();
                    MessageBox.Show("Se ha guardado la especialidad");
                }
                else MessageBox.Show("No se pudo guardar la especialidad");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                if (btnModificar.Text.ToLower() == "modificar")
                {
                    btnModificar.Text = "Aceptar";
                    int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                    Modelo.Especialidades especialidad = nespecialidades.Get(id);

                    nombreTextBox.Text = especialidad.Nombre;
                }
                else if (btnModificar.Text.ToLower() == "aceptar")
                {
                    try
                    {
                        btnModificar.Text = "Modificar";
                        int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                        especialidades = new Modelo.Especialidades();

                        especialidades.Nombre = nombreTextBox.Text;

                        if (nespecialidades.Update(id, especialidades))
                        {
                            CargarData();
                            MessageBox.Show("Consultorio modificado");
                        }
                        else MessageBox.Show("No se pudo modificar");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }

            }
        }
    }
}
