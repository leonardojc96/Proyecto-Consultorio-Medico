using Proyecto_Consultorio_Medico.Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    public partial class ListaPacientes : Plantillas.PlantillaListas
    {
        int idPaciente = -1;
        public ListaPacientes(): base("Pacientes")
        {
            InitializeComponent();
        }

        private void ListaPacientes_Load(object sender, EventArgs e)
        {
            Inicioadores.Labels(lblDetalles);

            CargarDatos();
            lblBuscar.Text = "Bustar por DNI:";
        }

        public void CargarDatos()
        {
            PacienteNegocio p = new PacienteNegocio();
            dgvLista.Columns.Add("Id", "Id");
            dgvLista.Columns["Id"].Visible = false;
            dgvLista.Columns.Add("Nombre", "Nombre y apellido");
            dgvLista.Columns.Add("DNI", "DNI");
            dgvLista.Columns.Add("Telefono", "Telefono");
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
                    item.Telefono,
                    item.ObraSocial
                };

                dgvLista.Rows.Insert(0, elementos);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPaciente != -1)
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
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        paciente.Remove(p);
                        RefreshData(p.Get());
                    }
                }
                catch (Exception ex)
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
            if (idPaciente != -1)
            {
                if (Validaciones.FormularioNoAbierto("AltaPacientes"))
                {
                    int idpa = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString());
                    Vistas.Pacientes.AltaPacientes alta = new AltaPacientes(idPaciente);
                    alta.MdiParent = this.Parent.FindForm();
                    alta.Modificar(idpa);
                    alta.Show();
                }
                else
                {
                    int idpa = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString());

                    Vistas.Pacientes.AltaPacientes alta = (Vistas.Pacientes.AltaPacientes)Application.OpenForms["AltaPacientes"];
                    alta = new AltaPacientes(idpa);
                    alta.MdiParent = this.Parent.FindForm();
                    alta.Modificar(idpa);
                    alta.Show();

                }
            }
            else
                MessageBox.Show("Debe seleccionar un paciente primero.");
        }

        public override void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvLista_CellClick(sender, e);
            if (e.RowIndex != -1)
            {
                idPaciente = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            PacienteNegocio pacienteNegocio = new PacienteNegocio();
            if (txtBuscar.Text != "")
                RefreshData(pacienteNegocio.SearchByDNI(txtBuscar.Text));

            else
                RefreshData(pacienteNegocio.Get());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Pacientes.AltaPacientes altaPaciente = new AltaPacientes();
            altaPaciente.MdiParent = this.Parent.FindForm();
            altaPaciente.Show();

        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            if(idPaciente !=-1)
            {
                if (Validaciones.FormularioNoAbierto("Turnos"))
                {
                    int idpa = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString()); 
                    Vistas.Pacientes.Turnos Turnos = new Turnos(idpa);
                    Turnos.MdiParent = this.Parent.FindForm();                  
                    Turnos.Show();
                }
                else
                {
                    int idpa = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString());

                    Vistas.Pacientes.Turnos Turnos = (Vistas.Pacientes.Turnos)Application.OpenForms["Turnos"];
                    Turnos = new Turnos(idpa);
                    Turnos.MdiParent = this.Parent.FindForm();               
                    Turnos.Show();

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente primero.");
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
