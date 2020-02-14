using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class ConsultoriosNegocio
    {
        Consultorios consultorios = new Consultorios();

        public bool Save(Consultorios consultorio)
        {
            return consultorios.Save(consultorio);
        }

        public ICollection<Consultorios> Get()
        {
            return consultorios.Get();
        }

        public Consultorios Get(int id)
        {
            return consultorios.Get(id);
        }

        public Consultorios GetByNumero(string Numero)
        {
            return consultorios.GetByNumero(Numero);
        }

        public bool Remove(Consultorios consultorio)
        {
            return consultorios.Remove(consultorio);
        }

        public bool Update(int id, Consultorios consultorio)
        {
            return consultorios.Update(id, consultorio);
        }
    }
}
