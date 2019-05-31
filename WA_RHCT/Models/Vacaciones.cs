namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Vacaciones")]
    public partial class Vacaciones
    {
        [Key]
        public int PK_IdVacaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdTipoVacaciones__RHCT { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int Periodo { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public decimal Dias { get; set; }

        public bool Reserva { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual TipoVacaciones TipoVacaciones { get; set; }
    }
}
