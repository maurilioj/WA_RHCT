namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasLaborados")]
    public partial class DiasLaborados
    {
        [Key]
        public int PK_IdDiasLaborados { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        [Column("DiasLaborados")]
        public int DiasLaborados1 { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
