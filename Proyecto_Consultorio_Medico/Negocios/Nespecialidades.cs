using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class Nespecialidades
    {

        public void SaveEspecialidad(Modelo.Especialidades es)
        {
            es.SaveEspecialidades(es);


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
        
    }
}
