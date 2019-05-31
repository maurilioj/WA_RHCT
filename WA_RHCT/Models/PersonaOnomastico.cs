namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaOnomastico")]
    public partial class PersonaOnomastico
    {
        [Key]
        public int PK_IdPersonaOnomastico { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public DateTime FechaOnomastico { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
