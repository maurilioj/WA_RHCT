namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaResponsableArea")]
    public partial class PersonaResponsableArea
    {
        [Key]
        public int PK_IdPersonaResponsableArea { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
