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
    
    public partial class ConsultaMedica
    {
        public int Id { get; set; }
        public int Id_Medico { get; set; }
        public int Id_Historico { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Estado { get; set; }
        public string Estudios { get; set; }
        public Nullable<System.DateTime> FechaProxConsulta { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string MedicacionSugerida { get; set; }
        public string Observaciones { get; set; }
        public string Notas { get; set; }
        public string EstudiosSolicitados { get; set; }
        public string EstudiosResibidos { get; set; }
        public string ResultadosEstudiosResibidos { get; set; }
    
        public virtual HistorialConsultas HistorialConsultas { get; set; }
        public virtual Medicos Medicos { get; set; }
    }
}
