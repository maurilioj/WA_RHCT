namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HI_Empleado")]
    public partial class HI_Empleado
    {
        [Key]
        public int PK_IdHI_Empleado { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_SituacionPersona__RHCT { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int FK_IdGrupoPuesto__RHCT { get; set; }

        public int FK_IdRama__RHCT { get; set; }

        public int FK_IdPuesto_RHCT { get; set; }

        public int FK_IdClasePuesto__RHCT { get; set; }

        public int FK_IdEscalaSalarial__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public int FK_IdClaseMovto__RHCT { get; set; }

        [Required]
        [StringLength(4)]
        public string Nivel { get; set; }

        public int Plaza { get; set; }

        public decimal Horas { get; set; }

        public int ZonaEconomica { get; set; }

        public int QuincenaPago { get; set; }

        public int QuincenaInicioProceso { get; set; }

        public virtual ClaseMovto ClaseMovto { get; set; }

        public virtual ClasePuesto ClasePuesto { get; set; }

        public virtual EscalaSalarial EscalaSalarial { get; set; }

        public virtual GrupoPuesto GrupoPuesto { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual Puesto Puesto { get; set; }

        public virtual Rama Rama { get; set; }

        public virtual SituacionPersona SituacionPersona { get; set; }
    }
}
