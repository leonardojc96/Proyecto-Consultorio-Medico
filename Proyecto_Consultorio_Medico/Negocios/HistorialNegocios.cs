﻿using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class HistorialNegocios
    {
        HistorialConsultas historial = new HistorialConsultas();

        public bool Save(HistorialConsultas historial)
        {
            return historial.Save(historial);
        }

        public ICollection<HistorialConsultas> GetByIdPaciente( int id )
        {
            return historial.GetByIdPaciente(id);
        }

        public HistorialConsultas Get(int id)
        {
            return historial.GetIdPaciente(id);
        }

        public IEnumerable<dynamic> GetTunosPendientes(int idMedico)
        {
            return historial.GetTunosPendientes(idMedico);
        }

    }
}
