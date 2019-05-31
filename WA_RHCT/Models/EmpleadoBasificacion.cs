namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EmpleadoBasificacion")]
    public partial class EmpleadoBasificacion
    {
        [Key]
        public int PK_IdEmpleadoBasificacion { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
