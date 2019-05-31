namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasReservadosVacaciones")]
    public partial class DiasReservadosVacaciones
    {
        [Key]
        public int PK_IdDiasReservadosVacaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int IdPeriodoVacaciones { get; set; }

        public int Dias { get; set; }

        public virtual DiasReservadosVacaciones DiasReservadosVacaciones1 { get; set; }

        public virtual DiasReservadosVacaciones DiasReservadosVacaciones2 { get; set; }

        public virtual PeriodoVacaciones PeriodoVacaciones { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
