namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EmpleadoDiasEconomicos")]
    public partial class EmpleadoDiasEconomicos
    {
        [Key]
        public int PK_IdEmpleadoDiasEconomicos { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdDiasEconomicos__RHCT { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Dias { get; set; }

        public virtual DiasEconomicos DiasEconomicos { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
