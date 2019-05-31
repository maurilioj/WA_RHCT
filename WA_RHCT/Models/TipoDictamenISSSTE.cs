namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TipoDictamenISSSTE")]
    public partial class TipoDictamenISSSTE
    {
        [Key]
        public int PK_IdTipoDictamenISSSTE { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }
    }
}
