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

namespace Proyecto_Consultorio_Medico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicioadores.FormInicio(this);

            if (Validaciones.FormularioNoAbierto("Menu"))
            {
                Vistas.Menu menu = new Vistas.Menu();
                menu.MdiParent = this;
                menu.Show();
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaMedico"))
            {
                Vistas.Medicos.AltaMedico altaMedico = new Vistas.Medicos.AltaMedico();
                altaMedico.MdiParent = this;
                altaMedico.btnModificar.Enabled = false;
                altaMedico.Show();
            }
            else
            {
                Vistas.Medicos.AltaMedico altaMedico = (Vistas.Medicos.AltaMedico) Application.OpenForms["AltaMedico"];
                altaMedico = new Vistas.Medicos.AltaMedico();
                altaMedico.MdiParent = this;
                altaMedico.btnModificar.Enabled = false;
                altaMedico.Show();
            }
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("ListaMedicos"))
            {
                Vistas.Medicos.ListaMedicos lista = new Vistas.Medicos.ListaMedicos();
                lista.MdiParent = this;
                lista.Show();
            }
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaPacientes"))
            {
                Vistas.Pacientes.AltaPacientes altaPaciente = new Vistas.Pacientes.AltaPacientes();
                altaPaciente.MdiParent = this;
                altaPaciente.btnModificar.Enabled = false;
                altaPaciente.Show();
            }
            else
            {
                Vistas.Pacientes.AltaPacientes altaPaciente = (Vistas.Pacientes.AltaPacientes)Application.OpenForms["AltaPacientes"];
                altaPaciente = new Vistas.Pacientes.AltaPacientes();
                altaPaciente.MdiParent = this;
                altaPaciente.btnModificar.Enabled = false;
                altaPaciente.Show();
            }
            
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("ListaPacientes"))
            {
                Vistas.Pacientes.ListaPacientes listaPaciente = new Vistas.Pacientes.ListaPacientes();
                listaPaciente.MdiParent = this;
                listaPaciente.Show();
            }
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaEspecialidades"))
            {
                Vistas.Especialidades.AltaEspecialidades altaEspecialidades = new Vistas.Especialidades.AltaEspecialidades();
                altaEspecialidades.MdiParent = this;
                altaEspecialidades.Show();
            }
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("AltaConsultorios"))
            {
                Vistas.Consultorios.AltaConsultorios altaConsultorios = new Vistas.Consultorios.AltaConsultorios();
                altaConsultorios.MdiParent = this;
                altaConsultorios.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("Menu"))
            {
                Vistas.Menu menu = new Vistas.Menu();
                menu.MdiParent = this;
                menu.Show();
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validaciones.FormularioNoAbierto("TurnosGeneral"))
            {
                Vistas.TurnosGenerales.TurnosGeneral t = new Vistas.TurnosGenerales.TurnosGeneral();
                t.MdiParent = this;
                t.Show();

            }
        }
    }
}
