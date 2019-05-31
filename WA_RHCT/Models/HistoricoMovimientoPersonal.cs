namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HistoricoMovimientoPersonal")]
    public partial class HistoricoMovimientoPersonal
    {
        [Key]
        public int PK_IdHistoricoMovimientoPersonal { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
