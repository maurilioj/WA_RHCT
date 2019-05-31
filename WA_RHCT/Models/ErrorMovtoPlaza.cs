namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ErrorMovtoPlaza")]
    public partial class ErrorMovtoPlaza
    {
        [Key]
        public int PK_IdErrorMovtoPlaza { get; set; }

        public int FK_IdMovimientoPlaza__RHCT { get; set; }

        public int FK_IdErrorMovto__RHCT { get; set; }

        public decimal Horas { get; set; }

        public int ZonaEconomica { get; set; }

        public virtual ErrorMovto ErrorMovto { get; set; }

        public virtual MovimientoPlaza MovimientoPlaza { get; set; }
    }
}
