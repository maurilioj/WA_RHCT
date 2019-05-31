namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.CentroTrabajoVacaciones")]
    public partial class CentroTrabajoVacaciones
    {
        [Key]
        public int PK_IdCentroTrabajoVacaciones { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Dias { get; set; }
    }
}
