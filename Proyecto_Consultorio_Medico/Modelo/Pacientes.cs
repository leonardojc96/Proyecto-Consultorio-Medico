//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Consultorio_Medico.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Pacientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacientes()
        {
            this.HistorialConsultas = new HashSet<HistorialConsultas>();
            this.Turnos = new HashSet<Turnos>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string DNI { get; set; }
        public string ObraSocial { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Foto { get; set; }
        public Nullable<System.DateTime> UltimaVisita { get; set; }
        public string Detalles { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialConsultas> HistorialConsultas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnos> Turnos { get; set; }

        public bool Save(Pacientes paciente)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                db.Pacientes.Add(paciente);

                if (db.SaveChanges() == 1)
                {
                    return true;
                }
                return false;
            }
        }

        public ICollection<Pacientes> Get()
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Pacientes.ToList();
            }
        }

        public Pacientes GetByHistorial(int idHistorial)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return (from p in db.Pacientes
                        join h in db.HistorialConsultas on p.Id equals h.Id_Paciente
                        where h.Id == idHistorial
                        select p).FirstOrDefault();
            }
        }

        public Pacientes Get(int id)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Pacientes.Find(id);
            }
        }

        public Pacientes GetDNI(string DNI)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Pacientes.Where(x => x.DNI == DNI).FirstOrDefault();
            }
        }

        public void Remove(Pacientes paciente)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                try
                {
                    db.Entry(paciente).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public bool Update(int id, Pacientes paciente)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                Pacientes p = db.Pacientes.Where(x => x.Id == id).FirstOrDefault();

                p.Nombre = paciente.Nombre;
                p.Apellido = paciente.Apellido;
                p.DNI = paciente.DNI;
                p.Telefono = paciente.Telefono;
                p.FechaIngreso = paciente.FechaIngreso;
                p.FechaNac = paciente.FechaNac;
                p.ObraSocial = paciente.ObraSocial;
                p.Direccion = paciente.Direccion;
                p.Foto = paciente.Foto;

                if (db.SaveChanges() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public ICollection<Pacientes> Search(string nombre)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Pacientes.Where(x => x.Nombre.StartsWith(nombre)).ToList();
            }
        }

        public ICollection<Pacientes> SearchByDNI(string dni)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Pacientes.Where(x => x.DNI.StartsWith(dni)).ToList();
            }
        }

        public IEnumerable<dynamic> GetByMedicos(int idMedico)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                var pacientes = (from p in db.Pacientes
                                 join h in db.HistorialConsultas on p.Id equals h.Id_Paciente
                                 join c in db.ConsultaMedica on h.Id equals c.Id_Historico
                                 where c.Id_Medico == idMedico
                                 select new { p.Nombre , p.Apellido, p.DNI, c.Fecha }).ToList();

                return pacientes;
            }
        }
    }
}
