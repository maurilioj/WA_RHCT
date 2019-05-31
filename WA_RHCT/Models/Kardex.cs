namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Kardex")]
    public partial class Kardex
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kardex()
        {
            PersonaPlaza = new HashSet<PersonaPlaza>();
        }

        [Key]
        public int PK_IdKardex { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int? FK_IdDependencia__RHCT { get; set; }

        public int? FK_IdSituacionPersona__RHCT { get; set; }

        public int? FK_IdArea__SIS { get; set; }

        public int? FK_IdPuesto__RHCT { get; set; }

        public int? FK_IdClasePuesto__RHCT { get; set; }

        public int? FK_IdPlazaAutorizada__RHCT { get; set; }

        public int? FK_IdEscalaSalarial__RHCT { get; set; }

        public int? FK_IdNombramiento__RHCT { get; set; }

        public int? FK_IdHorario__RHCT { get; set; }

        public int? FK_IdTurno__RHCT { get; set; }

        public int? FK_IdMotivoMovto__RHCT { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int? QuincenaInicio { get; set; }

        public int? QuincenaFin { get; set; }

        public decimal? Horas { get; set; }

        public int? FK_IdAreaDocto__SIS { get; set; }

        [StringLength(32)]
        public string Documento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sueldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SobreSueldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Compensacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quinquenio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Otras { get; set; }

        public int QuincenaAplicacion { get; set; }

        [StringLength(150)]
        public string PuestoAnt { get; set; }

        [StringLength(100)]
        public string DependenciaAnt { get; set; }

        [Column(TypeName = "text")]
        public string MotivoSeparacionAnt { get; set; }

        public bool EsGobierno { get; set; }

        public bool AplicaQuinquenio { get; set; }

        public int ClaveMovto { get; set; }

        public virtual ClasePuesto ClasePuesto { get; set; }

        public virtual Dependencia Dependencia { get; set; }

        public virtual EscalaSalarial EscalaSalarial { get; set; }

        public virtual Horario Horario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual SituacionPersona SituacionPersona { get; set; }

        public virtual Turno Turno { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
