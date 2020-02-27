using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class Nespecialidades
    {
        Especialidades especialidades = new Especialidades();

        public bool SaveEspecialidad(Modelo.Especialidades es)
        {
            return es.SaveEspecialidades(es);
        }

        public void RemoveEspecialidad(Modelo.Especialidades es)
        {
            es.RemoveEspecialidad(es);
        }

        public ICollection<Modelo.Especialidades> GetEspecialidades()
        {
            ICollection<Modelo.Especialidades> esplist = new List<Modelo.Especialidades>();
            Modelo.Especialidades esp = new Modelo.Especialidades();
            esplist = esp.GetEspecialidades();
            return esplist;
        }

        public Especialidades Get(int id)
        {
            return especialidades.Get(id);
        }

        internal bool Update(int id, Especialidades especialidades)
        {
            return especialidades.Update(id, especialidades);
        }
    }
}
