﻿using System;
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
    public partial class Turnos : Plantillas.Plantilla
    {
        Negocios.HistorialNegocios historial = new Negocios.HistorialNegocios();
        Modelo.HistorialConsultas historialModelo = new Modelo.HistorialConsultas();
        Modelo.Pacientes pacienteModelo = new Modelo.Pacientes();
        Negocios.PacienteNegocio pNegocio = new Negocios.PacienteNegocio();
        Negocios.Nespecialidades especialidadNegocio = new Negocios.Nespecialidades();
        Modelo.Especialidades esp = new Modelo.Especialidades();
        ICollection<Modelo.Especialidades> espLista = new List<Modelo.Especialidades>();
        Negocios.MedicoEspecialidadNegocio medEspecialidad = new Negocios.MedicoEspecialidadNegocio();
        ICollection<Modelo.MedicoEspecialidad> medEspLista = new List<Modelo.MedicoEspecialidad>();
        Negocios.MedicosNegocio medicosNegocio = new Negocios.MedicosNegocio();
        ICollection<Modelo.Medicos> medicosLista = new List<Modelo.Medicos>();
        Modelo.Medicos m = new Modelo.Medicos();
        ICollection<string> listaVacio = new List<string>();
        Modelo.Turnos turnoModelo = new Modelo.Turnos();
        Negocios.TurnoNegocio turnoNegocio = new Negocios.TurnoNegocio();
        Modelo.ConsultaMedica consulModelo = new Modelo.ConsultaMedica();
        Negocios.ConsultaMedicaNegocio consulNegocio = new Negocios.ConsultaMedicaNegocio();
        //Modelo.MedicoConsultorio medConsultorioModelo = new Modelo.MedicoConsultorio();
        ICollection<Modelo.MedicoConsultorio> medConsultorioModeloLista = new List<Modelo.MedicoConsultorio>();
        Negocios.MedicoConsultorioNegocio medConsultorioNegocio = new Negocios.MedicoConsultorioNegocio();
        Modelo.Consultorios consultoriosModelo = new Modelo.Consultorios();
        Negocios.ConsultoriosNegocio consultorioNegocio = new Negocios.ConsultoriosNegocio();
        
        public Turnos()
        {
            InitializeComponent();
            //espLista = especialidadNegocio.GetEspecialidades();
        }

        public Turnos(int id)
        {
            InitializeComponent();
            espLista = especialidadNegocio.GetEspecialidades();
            pacienteModelo = pNegocio.Get(id);
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
           
            Negocios.Inicioadores.ComboBox(cmbEspecialidad, espLista);
            listaVacio.Add("");
        }
       
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            if (cmbEspecialidad.SelectedIndex.ToString() != "0")
            {
                cmbMedicos.DataSource = listaVacio;
                medicosLista = new List<Modelo.Medicos>();
                medEspLista = new List<Modelo.MedicoEspecialidad>();
                int id = -1;
                try
                {
                    
                     id = int.Parse(cmbEspecialidad.SelectedValue.ToString());
                    medEspLista = medEspecialidad.GeyByEspecialidad(id);
                    foreach (var item in medEspLista)
                    {
                        m.Nombre = item.Medicos.Nombre + " " + item.Medicos.Apellido;
                        m.Id = item.Medicos.Id;
                        medicosLista.Add(m);
                    }
                    //medEspLista = medEspecialidad.GeyByEspecialidad(id);
                    // Negocios.Inicioadores.ComboBox(cmbMedicos, medEspLista);
                    cmbMedicos.DataSource = medicosLista;
                    cmbMedicos.DisplayMember = "Nombre";
                    cmbMedicos.ValueMember = "Id";

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            historialModelo = historial.Get(pacienteModelo.Id);
            if (historialModelo != null)
            {
                turnoModelo.Id_Paciente = historialModelo.Id_Paciente;
                turnoModelo.Id_Consultorio = GetIdConsultorio(int.Parse(cmbMedicos.SelectedValue.ToString()));
                turnoModelo.Id_Paciente = historialModelo.Id_Paciente;
                turnoNegocio.Save(turnoModelo);
                consulModelo.Id_Medico = int.Parse(cmbMedicos.SelectedValue.ToString());
                consulModelo.Id_Historico = historialModelo.Id;
                consulModelo.Id_Turno = GetIDTurnoByIdPaciente(historialModelo.Id_Paciente);
                consulModelo.Estado = "Pendiente";
                consulNegocio.Save(consulModelo);

            }
            else
            {
                historialModelo.Id_Paciente = pacienteModelo.Id;
                historial.Save(historialModelo);
                btnAceptar_Click(sender, e);

            }

            this.Close();
        }

        public int GetIDTurnoByIdPaciente(int id)
        {
            turnoModelo = turnoNegocio.GetTurnoByIdPaciente(id);
            return turnoModelo.Id;
        }
        public int GetIdConsultorio(int id)
        {
            int idConsultorio = -1;
            consultoriosModelo = new Modelo.Consultorios();
            medConsultorioModeloLista = medConsultorioNegocio.GetByMedico(id);
            foreach (var item in medConsultorioModeloLista)
            {
                if(item.Id_Consultorio == int.Parse(cmbEspecialidad.SelectedValue.ToString()))
                {
                     idConsultorio = item.Id_Consultorio;
                }
            }
            return idConsultorio;
        }
    }
}
