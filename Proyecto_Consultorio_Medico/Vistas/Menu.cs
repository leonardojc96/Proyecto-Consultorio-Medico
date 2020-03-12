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

namespace Proyecto_Consultorio_Medico.Vistas
{
    public partial class Menu : Plantillas.Plantilla
    {
        public Menu(): base("Menu Principal")
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    Button item2 = (Button)item;
                    item2.BackColor = Color.FromArgb(28, 162, 162);
                    item2.Font = new Font("calibri", 24, FontStyle.Bold);
                    item2.ForeColor = Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("ListaMedicos"))
            {
                Vistas.Medicos.ListaMedicos listaMedicos = new Medicos.ListaMedicos();
                listaMedicos.MdiParent = this.Parent.FindForm();
                listaMedicos.Show();
            }
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("ListaPacientes"))
            {
                Vistas.Pacientes.ListaPacientes listaPacientes = new Pacientes.ListaPacientes();
                listaPacientes.MdiParent = this.Parent.FindForm();
                listaPacientes.Show();
            }
        }

        private void btnNuevoMedico_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaMedico"))
            {
                Vistas.Medicos.AltaMedico altaMedico = new Medicos.AltaMedico();
                altaMedico.MdiParent = this.Parent.FindForm();
                altaMedico.Show();
            }
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaPacientes"))
            {
                Vistas.Pacientes.AltaPacientes altaPacientes = new Pacientes.AltaPacientes();
                altaPacientes.MdiParent = this.Parent.FindForm();
                altaPacientes.Show();
            }
        }
    }
}
