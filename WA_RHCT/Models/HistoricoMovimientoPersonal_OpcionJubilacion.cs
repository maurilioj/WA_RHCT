namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HistoricoMovimientoPersonal_OpcionJubilacion")]
    public partial class HistoricoMovimientoPersonal_OpcionJubilacion
    {
        [Key]
        public int PK_IdHistoricoMovimientoPersonal_OpcionJubilacion { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdOpcionJubilacion { get; set; }

        [StringLength(4)]
        public string PorcentajeAhorro { get; set; }

        public int? Fk_IdOpcionJubilacion_Ant { get; set; }

        public virtual OpcionJubilacion OpcionJubilacion { get; set; }

        public virtual OpcionJubilacion OpcionJubilacion1 { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
