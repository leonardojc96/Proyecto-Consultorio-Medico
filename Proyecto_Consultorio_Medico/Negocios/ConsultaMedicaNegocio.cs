using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class ConsultaMedicaNegocio
    {
        ConsultaMedica consulta = new ConsultaMedica();

        public IEnumerable<dynamic> GetTunosPendientes(int idMedico)
        {
            return consulta.GetTunosPendientes(idMedico);
        }
    }
}
