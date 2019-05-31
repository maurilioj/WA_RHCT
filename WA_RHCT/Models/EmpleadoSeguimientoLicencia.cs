namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.EmpleadoSeguimientoLicencia")]
    public partial class EmpleadoSeguimientoLicencia
    {
        [Key]
        public int PK_IdEmpleadoSeguimientoLicencia { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdMotivoLicencia__RHCT { get; set; }

        public int IdUsuario { get; set; }

        public DateTime FechaIngresoAnioActual { get; set; }

        public DateTime FechaInicioLicencia { get; set; }

        public DateTime FechaFinLicencia { get; set; }

        public int DiasLicencia { get; set; }

        [Required]
        [StringLength(128)]
        public string Descripcion { get; set; }

        public DateTime FechaCaptura { get; set; }

        public virtual MotivoLicencia MotivoLicencia { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
