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

        public ConsultaMedica Get(int id)
        {
            return consulta.Get(id);
        }

        public bool Save(ConsultaMedica consultaMedica)
        {
            return consulta.Save(consultaMedica);
        }
    }
}
