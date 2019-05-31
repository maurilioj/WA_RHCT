namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HistoricoMovimientoPersonal_FormaPago")]
    public partial class HistoricoMovimientoPersonal_FormaPago
    {
        [Key]
        public int PK_IdHistoricoMovimientoPersonal_FormaPago { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        [Required]
        [StringLength(1)]
        public string FormaPago { get; set; }

        public int? FK_IdBanco__SIS { get; set; }

        [StringLength(18)]
        public string Numerocuenta { get; set; }

        [StringLength(1)]
        public string FormaPago_Ant { get; set; }

        public int? FK_IdBanco_Ant { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
