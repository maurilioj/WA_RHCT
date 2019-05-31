namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TipoPuesto")]
    public partial class TipoPuesto
    {
        [Key]
        public int PK_IdTipoPuesto { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
