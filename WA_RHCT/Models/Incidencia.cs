namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Incidencia")]
    public partial class Incidencia
    {
        [Key]
        public int PK_IdIncidencia { get; set; }

        public int FK_IdTipoIncidencia__RHCT { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        [Required]
        [StringLength(150)]
        public string Referencia { get; set; }

        public DateTime FchaInicio { get; set; }

        public DateTime FchaFin { get; set; }

        public DateTime FchaJustificacion { get; set; }

        public int? Dias { get; set; }

        public string Observaciones { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual TipoIncidencia TipoIncidencia { get; set; }
    }
}
