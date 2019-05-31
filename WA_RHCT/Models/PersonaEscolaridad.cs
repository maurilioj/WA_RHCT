namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaEscolaridad")]
    public partial class PersonaEscolaridad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PK_IdPersonaEscolaridad { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdEscolaridad__RHCT { get; set; }

        public virtual Escolaridad Escolaridad { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
