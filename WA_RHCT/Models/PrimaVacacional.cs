namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PrimaVacacional")]
    public partial class PrimaVacacional
    {
        [Key]
        public int PK_IdPrimaVacacional { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int QuincenaAplicacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Importe { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
