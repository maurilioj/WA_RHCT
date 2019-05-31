namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ComparativoPlaza")]
    public partial class ComparativoPlaza
    {
        [Key]
        public int PK_IdComparativoPlaza { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        [Required]
        [StringLength(5)]
        public string Nivel { get; set; }

        public int Autorizadas { get; set; }

        public int Ocupadas { get; set; }

        public int Vacantes { get; set; }

        public int Congeladas { get; set; }

        public int OtraSituacion { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
