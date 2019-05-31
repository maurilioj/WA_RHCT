namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.MovPreparado")]
    public partial class MovPreparado
    {
        [Key]
        public int PK_IdMovPreparado { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int InicioProceso { get; set; }

        public int Consecutivo { get; set; }

        public int? Movimiento { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public int Inicio { get; set; }

        public int Fin { get; set; }

        public int Dias { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
