namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.MovimientoPlaza")]
    public partial class MovimientoPlaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovimientoPlaza()
        {
            ErrorMovtoPlaza = new HashSet<ErrorMovtoPlaza>();
        }

        [Key]
        public int PK_IdMovimientoPlaza { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public int FK_IdSituacionMovimiento__RHCT { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public int Numeracion { get; set; }

        public int? FK_IdPuesto__RHCT { get; set; }

        public decimal? Horas { get; set; }

        public decimal? Horas_Nvo { get; set; }

        [StringLength(40)]
        public string TerminalCaptura { get; set; }

        public DateTime? FechaCaptura { get; set; }

        public int? QuincenaCaptura { get; set; }

        public int? ConsecutivoCaptura { get; set; }

        [StringLength(40)]
        public string TerminalAplica { get; set; }

        public DateTime? FechaAplicacion { get; set; }

        public int? QuincenaAplicacion { get; set; }

        public int? ConsecutivoAplicacion { get; set; }

        public bool? AplicaMovto { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public int? Operacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorMovtoPlaza> ErrorMovtoPlaza { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual SituacionMovimiento SituacionMovimiento { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
