﻿using Proyecto_Consultorio_Medico.Negocios;
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
    public partial class InfoMedico : Plantillas.PlantillaInfo
    {
        Modelo.Medicos medicos = new Modelo.Medicos();
        MedicosNegocio medicosNegocio = new MedicosNegocio();
        MedicoEspecialidadNegocio medicoEspecialidad = new MedicoEspecialidadNegocio();
        MedicoConsultorioNegocio medicoConsultorioNegocio = new MedicoConsultorioNegocio();
        ConsultoriosNegocio consultoriosNegocio = new ConsultoriosNegocio();

        public InfoMedico()
        {
            InitializeComponent();
        }

        public InfoMedico(int idMedico)
        {
            medicos = medicosNegocio.Get(idMedico);
            InitializeComponent();
            CambiarTitulo(medicos.Nombre + " " + medicos.Apellido);
            CargarFoto(medicos.Foto);
        }

        private void InfoMedico_Load(object sender, EventArgs e)
        {
            Inicioadores.DataGrid(dgvEspecialidades);
            Inicioadores.Labels(lblEspecialidades);
            Inicioadores.Labels(lblHorarios);
            Inicioadores.Labels(lblPacientes);
            Inicioadores.TextoBlanco(panelLabels);
            CargarDatos();
            CancelButton = btnSalir;
        }

        public void CargarDatos()
        {
            txtApellido.Text = medicos.Apellido;
            txtNombre.Text = medicos.Nombre;
            txtDni.Text = medicos.DNI;
            txtDireccion.Text = medicos.Direccion;
            txtFecha.Text = medicos.FechaNac.Value.Year.ToString();
            txtMatricula.Text = medicos.Matricula;
            txtTelefono.Text = medicos.Telefono;
            txtCantidadTurnos.Text = medicos.CantidadTurnos.ToString();
            txtContactoAux.Text = medicos.ContactoAux;

            // carga de especialidades
            foreach (var item in medicoEspecialidad.GetByMedico(medicos.Id))
            {
                object[] elementos =
                {
                    item.Especialidades.Nombre
                };

                dgvEspecialidades.Rows.Insert(0, elementos);
            }

            //carga horarios
            foreach (var item in medicoConsultorioNegocio.GetByMedico(medicos.Id))
            {
                Modelo.Consultorios consultorio = consultoriosNegocio.Get(item.Id_Consultorio);
                object[] elementos =
                {
                    item.H_Entrada,
                    item.H_Salida,
                    item.Lunes,
                    item.Martes,
                    item.Miercoles,
                    item.Jueves,
                    item.Viernes,
                    item.Sabado,
                    item.Domingo,
                    consultorio.Nombre +" - "+consultorio.Especialidades.Nombre 
                };

                dgvHorarios.Rows.Insert(0, elementos);

                //carga pacientes
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}