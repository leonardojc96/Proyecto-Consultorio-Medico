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

namespace Proyecto_Consultorio_Medico.Vistas.Consultorios
{
    public partial class AltaConsultorios : Plantillas.PlantillaAlta
    {
        Modelo.Consultorios consultorios = new Modelo.Consultorios();
        ConsultoriosNegocio consultoriosNegocio = new ConsultoriosNegocio();
        Nespecialidades nespecialidades = new Nespecialidades();

        public AltaConsultorios():base("Consultorios")
        {
            InitializeComponent();
        }

        private void AltaConsultorios_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "id");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns.Add("Nombre", "Nº");
            dataGridView1.Columns.Add("Especialidad", "Especialidad");

            Inicioadores.ComboBox(cbEspecialidades, nespecialidades.GetEspecialidades());
            Inicioadores.TextoBlanco(panelAlta);

            CargarData();

        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidaEntero(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                consultorios = new Modelo.Consultorios();

                consultorios.Id_Especialidad = int.Parse(cbEspecialidades.SelectedValue.ToString());
                consultorios.Nombre = nombreTextBox.Text;
                consultorios.HayTurnos = true;

                if (consultoriosNegocio.Save(consultorios))
                {
                    CargarData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in consultoriosNegocio.Get())
            {
                Modelo.Especialidades especialidades = nespecialidades.Get(item.Id_Especialidad);
                object[] elementos =
                    {
                        item.Id,
                        item.Nombre,
                        especialidades.Nombre
                    };

                dataGridView1.Rows.Insert(0, elementos);
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

                    Modelo.Consultorios consultorio = consultoriosNegocio.Get(id);

                    cbEspecialidades.SelectedValue = consultorio.Id_Especialidad;
                    nombreTextBox.Text = consultorio.Nombre;
                }
                else if(btnModificar.Text.ToLower() =="aceptar")
                {
                    try
                    {
                        btnModificar.Text = "Modificar";
                        int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                        consultorios = new Modelo.Consultorios();

                        consultorios.Id_Especialidad = int.Parse(cbEspecialidades.SelectedValue.ToString());
                        consultorios.Nombre = nombreTextBox.Text;
                        consultorios.HayTurnos = true;

                        if (consultoriosNegocio.Update(id, consultorios))
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

        public override void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dataGridView1_CellClick(sender, e);
            if (e.RowIndex != -1)
            {
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                Modelo.Consultorios consultorios = consultoriosNegocio.Get(id);

                if (consultoriosNegocio.Remove(consultorios))
                {
                    CargarData();
                    MessageBox.Show("Consultorio eliminado");
                }
                else MessageBox.Show("No se puso eliminar");
            }
        }
    }
}
