﻿using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class TurnoNegocio
    {
        Turnos turnos = new Turnos();
        
        public int GetCantidadTurnos(int idMedico)
        {
            return turnos.GetCantidadTurnos(idMedico);
        }

        public Modelo.Turnos GetTurnoByIdPaciente(int id)
        {
            return turnos.GetTurnoById(id);
        }

        public bool Save(Modelo.Turnos turno)
        {
            return turno.Save(turno);
        }

        public ICollection<Medicos> GetLastMedicos(int idPaciente)
        {
            return turnos.GetLastMedicos(idPaciente);
        }
        public IEnumerable<dynamic> GetTurnos()
        {
            return turnos.GetTurnos();
        }
        public Consultorios GetConsultoriosByMedicoYEspecialidad(int idMed, int idEsp)
        {
            return turnos.GetConsultoriosByMedicoYEspecialidad(idMed, idEsp);
        }
    }
}
