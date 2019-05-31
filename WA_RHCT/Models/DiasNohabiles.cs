namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasNohabiles")]
    public partial class DiasNohabiles
    {
        [Key]
        public int PK_IdDiasNohabiles { get; set; }

        public DateTime FechaFestivo { get; set; }
    }
}
