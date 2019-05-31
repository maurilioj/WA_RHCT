namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaPlaza")]
    public partial class PersonaPlaza
    {
        [Key]
        public int PK_IdPersonaPlaza { get; set; }

        public int? FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_IdSituacionPersona__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public int FK_IdEscalaSalarial__RHCT { get; set; }

        public int FK_IdHorario__RHCT { get; set; }

        public int FK_IdTurno__RHCT { get; set; }

        public int? FK_IdPuestoValido__RHCT { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public int FK_IdRadicacionPago__RHCT { get; set; }

        public int? FK_IdCuenta__SIS { get; set; }

        public int? FK_IdComedor__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int? FK_IdKardex__RHCT { get; set; }

        public int ZonaEconomica { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public decimal Horas { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public int FK_IdAreaDocto__SIS { get; set; }

        [Required]
        [StringLength(1)]
        public string FormaPago { get; set; }

        public bool Declaracion { get; set; }

        public bool ChecaTarjeta { get; set; }

        public virtual Comedor Comedor { get; set; }

        public virtual EscalaSalarial EscalaSalarial { get; set; }

        public virtual Horario Horario { get; set; }

        public virtual Kardex Kardex { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual PuestoValido PuestoValido { get; set; }

        public virtual RadicacionPago RadicacionPago { get; set; }

        public virtual SituacionPersona SituacionPersona { get; set; }

        public virtual Turno Turno { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }
    }
}
