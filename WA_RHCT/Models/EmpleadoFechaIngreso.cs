namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EmpleadoFechaIngreso")]
    public partial class EmpleadoFechaIngreso
    {
        [Key]
        public int PK_IdEmpleadoFechaIngreso { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdClasificadorIngreso__RHCT { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaBaja { get; set; }

        public int AntiguedadAnios { get; set; }

        public int AntiguedadMeses { get; set; }

        public int AntiguedadDias { get; set; }

        public virtual ClasificadorIngreso ClasificadorIngreso { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
