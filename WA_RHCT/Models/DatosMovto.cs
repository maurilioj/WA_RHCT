namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DatosMovto")]
    public partial class DatosMovto
    {
        [Key]
        public int PK_IdDatosMovto { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public int FK_IdEscalaSalarial__RHCT { get; set; }

        public int FK_IdRadicacionPago__RHCT { get; set; }

        public int FK_IdHorario__RHCT { get; set; }

        public int FK_IdTurno__RHCT { get; set; }

        public int FK_IdComedor__RHCT { get; set; }

        public int FK_IdSituacionMovimiento__RHCT { get; set; }

        public int? FK_IdPuesto__RHCT { get; set; }

        public int? FK_IdArea__SIS { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        public DateTime FechaCaptura { get; set; }

        public int QuincenaInicioProceso { get; set; }

        [Required]
        [StringLength(64)]
        public string Observaciones { get; set; }

        public bool ChecaTarjeta { get; set; }

        public bool AplicaMovto { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public decimal Horas { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Importe { get; set; }

        public int Consecutivo { get; set; }

        public virtual Comedor Comedor { get; set; }

        public virtual EscalaSalarial EscalaSalarial { get; set; }

        public virtual Horario Horario { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual RadicacionPago RadicacionPago { get; set; }

        public virtual SituacionMovimiento SituacionMovimiento { get; set; }

        public virtual Turno Turno { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
