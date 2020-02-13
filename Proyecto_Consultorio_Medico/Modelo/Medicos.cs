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
    }
}
