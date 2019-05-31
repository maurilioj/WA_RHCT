namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PeriodoLicencia")]
    public partial class PeriodoLicencia
    {
        [Key]
        public int PK_IdPeriodoLicencia { get; set; }

        public int RangoInicio { get; set; }

        public int RangoFin { get; set; }

        public int Dias100 { get; set; }

        public int Dias50 { get; set; }
    }
}
