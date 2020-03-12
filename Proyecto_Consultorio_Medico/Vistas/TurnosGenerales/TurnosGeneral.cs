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

namespace Proyecto_Consultorio_Medico.Vistas.TurnosGenerales
{
    public partial class TurnosGeneral : Vistas.Plantillas.Plantilla
    {
        IEnumerable<dynamic> t = new List<Turnos>();
        TurnoNegocio tNegocio = new TurnoNegocio();


        public TurnosGeneral()
        {
            InitializeComponent();
        }

        private void TurnosGeneral_Load(object sender, EventArgs e)
        {
            Negocios.Inicioadores.DataGrid(dgvTurnosGen);
            t = tNegocio.GetTurnos();

            CargarData(t);
        }


        public void CargarData(IEnumerable<dynamic> datos)
        {
            foreach (var item in datos)
            {
                object[] dat =
                {
                   item.nombrePaciente,
                   item.nombreMedico,
                   item.nombreConsul,
                   item.nombreEspecial


                };
                dgvTurnosGen.Rows.Insert(0, dat);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
