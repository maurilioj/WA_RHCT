namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.FechaVacaciones")]
    public partial class FechaVacaciones
    {
        [Key]
        public int PK_IdFechaVacaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public DateTime FechaBase { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaAntiguedadVacaciones { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
