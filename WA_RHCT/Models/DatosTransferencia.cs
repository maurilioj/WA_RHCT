namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DatosTransferencia")]
    public partial class DatosTransferencia
    {
        [Key]
        public int PK_IdDatosTransferencia { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int IdArea { get; set; }

        public DateTime FechaPresentacion { get; set; }

        public DateTime FechaAltaNomina { get; set; }

        public DateTime FechaIngresoGobFed { get; set; }

        public DateTime FechaIngresoSSA { get; set; }

        public DateTime FechaBaseSSA { get; set; }

        [Required]
        [StringLength(64)]
        public string HospitalProcedencia { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Observacion { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
