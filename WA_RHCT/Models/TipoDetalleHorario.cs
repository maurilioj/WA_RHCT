namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TipoDetalleHorario")]
    public partial class TipoDetalleHorario
    {
        [Key]
        public int PK_IdTipoDetalleHorario { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public int Clave { get; set; }
    }
}
