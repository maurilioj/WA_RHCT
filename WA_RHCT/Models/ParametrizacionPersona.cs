namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ParametrizacionPersona")]
    public partial class ParametrizacionPersona
    {
        [Key]
        public int PK_IdParametrizacionPersona { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public int FK_IdSituacionPersonaLee__RHCT { get; set; }

        public int FK_IdSituacionPersonaGraba__RHCT { get; set; }

        public int FK_IdSituacionPersonaCierra__RHCT { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual SituacionPersona SituacionPersona { get; set; }

        public virtual SituacionPersona SituacionPersona1 { get; set; }

        public virtual SituacionPersona SituacionPersona2 { get; set; }
    }
}
