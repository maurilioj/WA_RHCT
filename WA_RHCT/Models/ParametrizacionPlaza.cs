namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ParametrizacionPlaza")]
    public partial class ParametrizacionPlaza
    {
        [Key]
        public int PK_IdParametrizacionPlaza { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public int FK_IdSituacionPlazaLee__RHCT { get; set; }

        public int FK_IdSituacionPlazaGraba__RHCT { get; set; }

        public int FK_IdSituacionPlazaCierra__RHCT { get; set; }

        public int FK_IdSituacionPlazaGrabaA__RHCT { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual SituacionPlaza SituacionPlaza { get; set; }

        public virtual SituacionPlaza SituacionPlaza1 { get; set; }

        public virtual SituacionPlaza SituacionPlaza2 { get; set; }

        public virtual SituacionPlaza SituacionPlaza3 { get; set; }
    }
}
