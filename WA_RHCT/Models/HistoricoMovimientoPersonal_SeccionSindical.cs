namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HistoricoMovimientoPersonal_SeccionSindical")]
    public partial class HistoricoMovimientoPersonal_SeccionSindical
    {
        [Key]
        public int PK_IdHistoricoMovimientoPersonal_SeccionSindical { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdRadicacionPago__RHCT { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }

        public virtual RadicacionPago RadicacionPago { get; set; }
    }
}
