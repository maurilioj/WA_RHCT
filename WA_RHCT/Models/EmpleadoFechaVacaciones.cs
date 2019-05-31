namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EmpleadoFechaVacaciones")]
    public partial class EmpleadoFechaVacaciones
    {
        [Key]
        public int PK_IdEmpleadoFechaVacaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int Periodo { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public DateTime FechaVacaciones { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public DateTime? FechaBase { get; set; }

        public int DiasAntiguedad { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
