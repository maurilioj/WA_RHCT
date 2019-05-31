namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Operacion")]
    public partial class Operacion
    {
        [Key]
        public int PK_IdOperacion { get; set; }

        [StringLength(10)]
        public string ClaveOperacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
