namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TopeVacaciones")]
    public partial class TopeVacaciones
    {
        [Key]
        public int PK_IdTopeVacaciones { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int Dias { get; set; }
    }
}
