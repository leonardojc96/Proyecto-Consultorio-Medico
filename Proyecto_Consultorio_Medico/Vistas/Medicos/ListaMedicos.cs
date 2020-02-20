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

namespace Proyecto_Consultorio_Medico.Vistas.Medicos
{
    public partial class ListaMedicos : Plantillas.PlantillaListas
    {
        Negocios.MedicosNegocio medicosNegocio = new Negocios.MedicosNegocio();
        int idMedico = 0;

        public ListaMedicos(): base("Medicos")
        {
            InitializeComponent();
        }

        private void ListaMedicos_Load(object sender, EventArgs e)
        {
            

            CargarData();
        }

        public void CargarData()
        {
            dgvLista.Columns.Add("Id", "Id");
            dgvLista.Columns.Add("Nombre", "Nombre y apellido");
            dgvLista.Columns.Add("DNI", "DNI");
            dgvLista.Columns.Add("Telefono", "Telefono");
            dgvLista.Columns["Id"].Visible = false;

            Inicioadores.DataGrid(dgvLista);

            RefreshData(medicosNegocio.Get());
            
        }

        public void RefreshData(ICollection<Modelo.Medicos> datos)
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
            if (idMedico != 0)
            {
                try
                {
                    Modelo.Medicos medicos = medicosNegocio.Get(idMedico);
                    string message = "Seguro desea eliminar permanentemente a "+medicos.Apellido+"?";
                    string caption = "Eliminar";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        medicosNegocio.Remove(medicos);
                        RefreshData(medicosNegocio.Get());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string message = "Debes seleccionar un medico primero";
                string caption = "Eliminar";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        public override void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvLista_CellClick(sender, e);
            if (e.RowIndex != -1)
            {
                idMedico = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idMedico != 0)
            {
                if (Validaciones.FormularioNoAbierto("AltaMedico"))
                {
                    Vistas.Medicos.AltaMedico altaMedico = new AltaMedico();
                    altaMedico.ModificarMedico(idMedico);
                    altaMedico.MdiParent = this.Parent.FindForm();
                    altaMedico.Show();
                }
                else
                {
                    Vistas.Medicos.AltaMedico alta = (Vistas.Medicos.AltaMedico) Application.OpenForms["AltaMedico"];
                    alta.Close();
                    alta = new AltaMedico();
                    alta.MdiParent = this.Parent.FindForm();
                    alta.ModificarMedico(idMedico);
                    alta.Show();

                }

            }
        }
        public override void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvLista_CellDoubleClick(sender, e);
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (Validaciones.FormularioNoAbierto("InfoMedico"))
                {
                    Vistas.Medicos.InfoMedico info = new InfoMedico(id);
                    info.MdiParent = this.Parent.FindForm();
                    info.Show();
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text != "")
                RefreshData(medicosNegocio.Search(txtBuscar.Text));

            else
                RefreshData(medicosNegocio.Get());
        }
    }
}
