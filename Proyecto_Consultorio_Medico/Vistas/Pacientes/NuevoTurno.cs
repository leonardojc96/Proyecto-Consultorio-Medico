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
    public partial class NuevoTurno : Form
    {
        ICollection<Modelo.MedicoEspecialidad> medesplista = new List<Modelo.MedicoEspecialidad>();
        Negocios.MedicoEspecialidadNegocio medespNegocio = new Negocios.MedicoEspecialidadNegocio();
        Negocios.Nespecialidades esp = new Negocios.Nespecialidades();
        ICollection<Modelo.Especialidades> espLista = new List<Modelo.Especialidades>();
        ICollection<Modelo.Medicos> listaMed = new List<Modelo.Medicos>();
        ICollection<Modelo.Medicos> listaAlter = new List<Modelo.Medicos>();
        Negocios.MedicosNegocio med = new Negocios.MedicosNegocio();
        ICollection<int> listaEnteros = new List<int>();
        Modelo.Medicos m = new Modelo.Medicos();
        public NuevoTurno()
        {
            InitializeComponent();
            cmbEspecialidad.DataSource = esp.GetEspecialidades();
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "Id";

        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            listaMed = med.Get();
           
           

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaAlter = new List<Modelo.Medicos>();

            if (cmbEspecialidad.SelectedValue.ToString() != "0")
            {
                try
                {



                    int id = int.Parse(cmbEspecialidad.SelectedValue.ToString());


                    medesplista = medespNegocio.GeyByEspecialidad(id);

                    //foreach (var item in medesplista)
                    //{
                    //    foreach (var item2 in listaMed)
                    //    {
                    //        if (item.Id_Medico == item2.Id)
                    //        {
                    //            listaAlter.Add(item2);
                    //        }
                    //    }
                    //}

                    //Negocios.Inicioadores.ComboBox(cmbMedicos, listaMed);
                    cmbMedicos.Items.Clear();
                    CargaDatosMedicos(medesplista);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
        public void CargaDatosMedicos(ICollection<Modelo.MedicoEspecialidad> m)
        {
            Negocios.Inicioadores.ComboBox(cmbMedicos, m);
            //foreach (var item in m)
            //{

            //    try
            //    {


            //        cmbMedicos.Items.Add(item);
            //        cmbMedicos.DisplayMember = "Apellido";
                   
            //        cmbMedicos.ValueMember = "Id";

            //    } catch (Exception ex)
            //    {
            //        MessageBox.Show("Error en Carga datos medicos");
            //    }
            //}




        }

        private void cmbEspecialidad_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            if (cmbMedicos.SelectedIndex.ToString() != "0")
            {
               
                try
                {
                    int id = -1;                  
                    txtTurnos.Clear();
                    id = int.Parse(cmbMedicos.SelectedValue.ToString());
                    //string apellido = (cmbMedicos.SelectedText);
                    m = med.Get(id);
                    txtTurnos.Text = m.CantidadTurnos.ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
