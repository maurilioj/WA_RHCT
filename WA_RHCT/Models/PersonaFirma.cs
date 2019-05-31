namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaFirma")]
    public partial class PersonaFirma
    {
        [Key]
        public int PK_IdPersonaFirma { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        [Required]
        [StringLength(5)]
        public string Profesion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
