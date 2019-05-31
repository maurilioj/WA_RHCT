namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DictamenISSSTE")]
    public partial class DictamenISSSTE
    {
        [Key]
        public int PK_IdDictamenISSSTE { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int FK_IdTipoDictamenISSSTE__RHCT { get; set; }

        public DateTime FechaInicioIncidencia { get; set; }

        public DateTime FechaFinIncidencia { get; set; }

        public DateTime FechaJustificacion { get; set; }

        public DateTime FechaCaptura { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Observaciones { get; set; }
    }
}
