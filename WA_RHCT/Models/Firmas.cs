namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Firmas")]
    public partial class Firmas
    {
        [Key]
        public int PK_IdFirmas { get; set; }

        [Required]
        [StringLength(64)]
        public string SubDirRH { get; set; }

        [Required]
        [StringLength(64)]
        public string DirAdmva { get; set; }

        [Required]
        [StringLength(64)]
        public string DirGral { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }
    }
}
