using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class PacienteNegocio
    {
        Pacientes paciente = new Pacientes();

        public bool Save(Pacientes paciente)
        {
            return paciente.Save(paciente);
        }

        public ICollection<Pacientes> Get()
        {
            return paciente.Get();
        }

        public Pacientes Get(int id)
        {

            return paciente.Get(id);
        }

        public Pacientes GetDNI(string DNI)
        {
            return paciente.GetDNI(DNI);
        }

        public void Remove(Pacientes paciente)
        {
            paciente.Remove(paciente);
        }

        public bool Update(int id, Pacientes paciente)
        {
            return paciente.Update(id, paciente);
        }
        public ICollection<Pacientes> Search(string nombre)
        {
            return paciente.Search(nombre);
        }
    }
}
