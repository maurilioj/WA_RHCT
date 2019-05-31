namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.FechasIngreso")]
    public partial class FechasIngreso
    {
        [Key]
        public int PK_IdFechasIngreso { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdClasificadorIngreso__RHCT { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public virtual ClasificadorIngreso ClasificadorIngreso { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
