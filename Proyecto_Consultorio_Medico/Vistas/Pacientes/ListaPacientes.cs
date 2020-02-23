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
    public partial class ListaPacientes : Plantillas.PlantillaListas
    {
        int idPaciente = -1;
        public ListaPacientes()
        {
            InitializeComponent();
        }

        private void ListaPacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            PacienteNegocio p = new PacienteNegocio();
            dgvLista.Columns.Add("Id", "Id");
            dgvLista.Columns.Add("Nombre", "Nombre");
            dgvLista.Columns.Add("Apellido", "Apellido");
            dgvLista.Columns.Add("DNI", "DNI");
            dgvLista.Columns.Add("O. Social", "OSocial");
            Inicioadores.DataGrid(dgvLista);

            RefreshData(p.Get());

        }


        public void RefreshData(ICollection<Modelo.Pacientes> datos)
        {
            dgvLista.Rows.Clear();


            foreach (var item in datos)
            {
                object[] elementos =
                {
                    item.Id,
                    item.Nombre + " "+ item.Apellido,
                    item.DNI,
                    item.Telefono
                };

                dgvLista.Rows.Insert(0, elementos);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(idPaciente != -1)
            {
                try
                {
                    PacienteNegocio paciente = new PacienteNegocio();
                    Modelo.Pacientes p = paciente.Get(idPaciente);
                    string mensaje = "Esta seguro que desea eliminar al paciente" + p.Apellido + "?";
                    string caption = "Eliminar";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(mensaje, caption, buttons);
                    if(result == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                        paciente.Remove(p);
                        RefreshData(p.Get());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string message = "Debes seleccionar un paciente primero";
                string caption = "Eliminar";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(idPaciente != -1)
            {
                if (Validaciones.FormularioNoAbierto("AltaPacientes"))
                {
                    Vistas.Pacientes.AltaPacientes alta = new AltaPacientes();
                    alta.MdiParent = this.Parent.FindForm();
                    alta.Modificar(idPaciente);
                    alta.Show();
                }
                else
                {
                    Vistas.Pacientes.AltaPacientes alta = (Vistas.Pacientes.AltaPacientes)Application.OpenForms["AltaPacientes"];
                    alta = new AltaPacientes();
                    alta.MdiParent = this.Parent.FindForm();
                    alta.Modificar(idPaciente);
                    alta.Show();

                }
            }
        }

        public override void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvLista_CellClick(sender, e);
            idPaciente = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());

        }
        public override void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvLista_CellDoubleClick(sender, e);
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (Validaciones.FormularioNoAbierto("InfoPaciente"))
                {            
                    Vistas.Pacientes.InfoPacientes info = new InfoPacientes(id);
                    info.MdiParent = this.Parent.FindForm();         
                    info.Show();
                    

                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            PacienteNegocio p = new PacienteNegocio();
            if (txtBuscar.Text != "")
                RefreshData(p.Search(txtBuscar.Text));

            else
                RefreshData(p.Get());
        }

    }
}
