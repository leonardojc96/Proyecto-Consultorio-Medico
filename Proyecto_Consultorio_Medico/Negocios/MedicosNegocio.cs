using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class MedicosNegocio
    {
        Medicos medico = new Medicos();

        public void SaveMedico(Medicos med)
        {
            med.SaveMedico(med);
        }

        public Medicos GetMedicoByName(string nombre)
        {
            return medico.GetMedicoByName(nombre);
        }

        public Medicos Get(int id)
        {
            return medico.Get(id);
        }

        public ICollection<Medicos> Get()
        {
            return medico.Get();
        }

        public void Remove(Medicos med)
        {
            medico.Remove(med);
        }

        public bool Update(int id, Medicos medicos)
        {
            return medico.Update(id, medicos);
        }
    }
}
