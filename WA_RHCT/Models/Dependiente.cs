namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Dependiente")]
    public partial class Dependiente
    {
        [Key]
        public int PK_IdDependiente { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdParentesco__RHCT { get; set; }

        public int? FK_IdEscolaridad__RHCT { get; set; }

        public int? Consecutivo { get; set; }

        [StringLength(32)]
        public string ApPaterno { get; set; }

        [StringLength(32)]
        public string ApMaterno { get; set; }

        [Required]
        [StringLength(32)]
        public string Nombre { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [StringLength(1)]
        public string ClaveSexo { get; set; }

        public bool? Estudia { get; set; }

        public decimal Porcentaje { get; set; }

        public virtual Escolaridad Escolaridad { get; set; }

        public virtual Parentesco Parentesco { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
