using Proyecto_Consultorio_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consultorio_Medico.Negocios
{
    class MedicoConsultorioNegocio
    {
        MedicoConsultorio medicoConsultorio = new MedicoConsultorio();

        public bool Save(MedicoConsultorio medicoConsultorio)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                db.MedicoConsultorio.Add(medicoConsultorio);

                if (db.SaveChanges() == 1)
                {
                    return true;
                }
                return false;
            }
        }

        public ICollection<MedicoConsultorio> GetByConsultorio(int idConsultorio)
        {
            return medicoConsultorio.GetByConsultorio(idConsultorio);
        }

        public ICollection<MedicoConsultorio> GetByMedico(int idMedico)
        {
            return medicoConsultorio.GetByMedico(idMedico);
        }
    }
}
