namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.CuentaPersonaBanamex")]
    public partial class CuentaPersonaBanamex
    {
        [Key]
        public int PK_IdCuentaPersonaBanamex { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdBanco__SIS { get; set; }

        public int FK_IdTipoCuenta__SIS { get; set; }

        [StringLength(4)]
        public string Sucursal { get; set; }

        [StringLength(16)]
        public string CuentaCheques { get; set; }

        [StringLength(1)]
        public string FormaPago { get; set; }

        public int? QuincenaProceso { get; set; }

        [StringLength(10)]
        public string Usuario { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
