namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Licencia")]
    public partial class Licencia
    {
        [Key]
        public int PK_IdLicencia { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int IdMotivoMovto { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
