namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HistoricoMovimientoPersonal2")]
    public partial class HistoricoMovimientoPersonal2
    {
        [Key]
        public int PK_IdHistoricoMovimientoPersonal2 { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public int FK_IdMovimiento__RHCT { get; set; }

        public int QuincenaAplicacion { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public virtual Movimiento Movimiento { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
