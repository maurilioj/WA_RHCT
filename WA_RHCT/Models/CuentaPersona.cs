namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.CuentaPersona")]
    public partial class CuentaPersona
    {
        [Key]
        public int PK_IdCuentaPersona { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int? FK_IdBanco__SIS { get; set; }

        [StringLength(16)]
        public string CuentaCheques { get; set; }

        [StringLength(1)]
        public string FormaPago { get; set; }

        public int? FK_IdTipoCuenta__SIS { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
