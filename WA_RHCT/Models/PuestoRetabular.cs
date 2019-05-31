namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PuestoRetabular")]
    public partial class PuestoRetabular
    {
        [Key]
        public int PK_IdPuestoRetabular { get; set; }

        public int IdPuesto { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public bool Aplicado { get; set; }

        public virtual Puesto Puesto { get; set; }

        public virtual Puesto Puesto1 { get; set; }
    }
}
