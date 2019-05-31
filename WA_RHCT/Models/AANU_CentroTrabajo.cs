namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.AANU_CentroTrabajo")]
    public partial class AANU_CentroTrabajo
    {
        [Key]
        public int PK_IdCentroTrabajo { get; set; }

        public int FK_IdUnidadResp__RHCT { get; set; }

        public int FK_IdMunicipio__SIS { get; set; }

        [Required]
        [StringLength(10)]
        public string Clave { get; set; }

        [Required]
        [StringLength(128)]
        public string Descripcion { get; set; }

        public int ZonaEconomica { get; set; }

        [Required]
        [StringLength(64)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(64)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo_Postal { get; set; }

        [Required]
        [StringLength(32)]
        public string Telefono { get; set; }

        public virtual AANU_UnidadResp AANU_UnidadResp { get; set; }
    }
}
