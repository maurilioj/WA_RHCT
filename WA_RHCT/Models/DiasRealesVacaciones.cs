namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasRealesVacaciones")]
    public partial class DiasRealesVacaciones
    {
        [Key]
        public int PK_IdDiasRealesVacaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Tiene { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
