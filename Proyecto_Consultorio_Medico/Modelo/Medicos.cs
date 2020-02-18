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
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Medicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicos()
        {
            this.ConsultaMedica = new HashSet<ConsultaMedica>();
            this.MedicoConsultorio = new HashSet<MedicoConsultorio>();
            this.MedicoEspecialidad = new HashSet<MedicoEspecialidad>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> CantidadTurnos { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string Matricula { get; set; }
        public string Telefono { get; set; }
        public string ContactoAux { get; set; }
        public string Foto { get; set; }
        public string Curricula { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaMedica> ConsultaMedica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicoConsultorio> MedicoConsultorio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicoEspecialidad> MedicoEspecialidad { get; set; }

        public void SaveMedico(Medicos med)
        {

            Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities();
            db.Medicos.Add(med);
            db.SaveChanges();
        }

        public Medicos GetMedicoByName(string nombre)
        {
            nombre = nombre.ToLower().Trim();
            Medicos m = new Medicos();
            Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities();
            m = db.Medicos.Where(x => x.Nombre.ToLower().Trim() == nombre).FirstOrDefault();


            return m;
        }

        public Medicos Get(int id)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Medicos.Find(id);
            }
        }

        public ICollection<Medicos> Get()
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                return db.Medicos.ToList();
            }
        }

        public void Remove(Medicos medicos)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                try
                {
                    db.Entry(medicos).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public bool Update(int id, Medicos medicos)
        {
            using (Proyecto_centro_medicoEntities db = new Proyecto_centro_medicoEntities())
            {
                Medicos m = db.Medicos.Where(x => x.Id == id).FirstOrDefault();

                m.Nombre = medicos.Nombre;
                m.Apellido = medicos.Apellido;
                m.DNI = medicos.DNI;
                m.Direccion = medicos.Direccion;
                m.Curricula = medicos.Curricula;
                m.Foto = medicos.Foto;
                m.FechaNac = medicos.FechaNac;
                m.Matricula = medicos.Matricula;
                m.Telefono = medicos.Telefono;
                m.ContactoAux = medicos.ContactoAux;
                m.CantidadTurnos = medicos.CantidadTurnos;


                if (db.SaveChanges() == 1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
