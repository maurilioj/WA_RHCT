namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasDerecho")]
    public partial class DiasDerecho
    {
        [Key]
        public int PK_IdDiasDerecho { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        [Column("DiasDerecho")]
        public int DiasDerecho1 { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
