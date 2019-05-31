namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EmpleadoTarjetaObservaciones")]
    public partial class EmpleadoTarjetaObservaciones
    {
        [Key]
        public int PK_IdEmpleadoTarjetaObservaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        [Required]
        [StringLength(64)]
        public string Observaciones { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
