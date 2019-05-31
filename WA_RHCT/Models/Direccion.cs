namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Direccion")]
    public partial class Direccion
    {
        [Key]
        public int PK_IdDireccion { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdMunicipio__SIS { get; set; }

        public int FK_IdTipoDireccion__RHCT { get; set; }

        public int Consecutivo { get; set; }

        [Required]
        [StringLength(32)]
        public string Calle { get; set; }

        [Required]
        [StringLength(32)]
        public string NumExterior { get; set; }

        [Required]
        [StringLength(32)]
        public string NumInterior { get; set; }

        [Required]
        [StringLength(32)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(5)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(32)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(12)]
        public string Extencion { get; set; }

        [Required]
        [StringLength(12)]
        public string Piso { get; set; }

        public virtual TipoDireccion TipoDireccion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
