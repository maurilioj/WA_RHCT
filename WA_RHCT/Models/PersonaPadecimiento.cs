namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaPadecimiento")]
    public partial class PersonaPadecimiento
    {
        [Key]
        public int PK_IdPersonaPadecimiento { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPadecimiento__RHCT { get; set; }

        public virtual Padecimientos Padecimientos { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
