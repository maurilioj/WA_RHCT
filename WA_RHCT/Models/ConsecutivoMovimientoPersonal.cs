namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ConsecutivoMovimientoPersonal")]
    public partial class ConsecutivoMovimientoPersonal
    {
        [Key]
        public int PK_IdConsecutivoMovimientoPersonal { get; set; }

        public int UltimoValor { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int FK_IdMovimiento__RHCT { get; set; }

        public virtual Movimiento Movimiento { get; set; }
    }
}
