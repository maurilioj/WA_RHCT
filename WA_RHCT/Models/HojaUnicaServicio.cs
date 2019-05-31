namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.HojaUnicaServicio")]
    public partial class HojaUnicaServicio
    {
        [Key]
        public int PK_IdHojaUnicaServicio { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Sueldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SobreSueldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Compensacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Quinquenio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Otros { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
