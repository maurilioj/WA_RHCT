namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TipoCarrera")]
    public partial class TipoCarrera
    {
        [Key]
        public int PK_IdTipoCarrera { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
