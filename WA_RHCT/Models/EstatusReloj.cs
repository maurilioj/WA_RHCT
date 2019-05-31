namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EstatusReloj")]
    public partial class EstatusReloj
    {
        [Key]
        public int PK_IdEstatusReloj { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}
