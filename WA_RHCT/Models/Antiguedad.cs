namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Antiguedad")]
    public partial class Antiguedad
    {
        [Key]
        public int PK_IdAntiguedad { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdClasificadorIngreso__RHCT { get; set; }

        public int Consecutivo { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public virtual ClasificadorIngreso ClasificadorIngreso { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
