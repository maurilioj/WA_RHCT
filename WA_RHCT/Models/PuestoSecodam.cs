namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PuestoSecodam")]
    public partial class PuestoSecodam
    {
        [Key]
        public int PK_IdPuestoSecodam { get; set; }

        [Required]
        [StringLength(7)]
        public string Clave { get; set; }

        [Required]
        [StringLength(32)]
        public string Descripcion { get; set; }
    }
}
