﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Proyecto_centro_medicoEntities : DbContext
    {
        public Proyecto_centro_medicoEntities()
            : base("name=Proyecto_centro_medicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ConsultaMedica> ConsultaMedica { get; set; }
        public virtual DbSet<Consultorios> Consultorios { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<HistorialConsultas> HistorialConsultas { get; set; }
        public virtual DbSet<MedicoConsultorio> MedicoConsultorio { get; set; }
        public virtual DbSet<MedicoEspecialidad> MedicoEspecialidad { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Turnos> Turnos { get; set; }
    }
}
