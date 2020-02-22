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
        MedicoEspecialidad medicoEspecialidad = new MedicoEspecialidad();

        public bool Save(MedicoEspecialidad medicoEspecialidad)
        {
            return medicoEspecialidad.Save(medicoEspecialidad);
        }

        public ICollection<MedicoEspecialidad> GetByMedico(int id)
        {
            return medicoEspecialidad.GetByMedico(id);
        }

        public ICollection<MedicoEspecialidad> GeyByEspecialidad(int id)
        {
            return medicoEspecialidad.GeyByEspecialidad(id);
        }
    }
}
