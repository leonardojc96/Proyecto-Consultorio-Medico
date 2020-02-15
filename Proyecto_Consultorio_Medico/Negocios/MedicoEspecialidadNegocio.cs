using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class MedicoEspecialidadNegocio
    {
        public bool Save(MedicoEspecialidad medicoEspecialidad)
        {
            return medicoEspecialidad.Save(medicoEspecialidad);
        }
    }
}
