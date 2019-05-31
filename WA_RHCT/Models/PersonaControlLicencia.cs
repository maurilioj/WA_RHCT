namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaControlLicencia")]
    public partial class PersonaControlLicencia
    {
        [Key]
        public int PK_IdPersonaControlLicencia { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public DateTime FechaIngresoAnioActual { get; set; }

        public DateTime FechaFinLicenciaAnioPosterior { get; set; }

        public int Dias100 { get; set; }

        public int Dias50 { get; set; }

        public int Dias0 { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
