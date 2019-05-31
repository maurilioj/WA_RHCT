namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.MandoTipoNomina")]
    public partial class MandoTipoNomina
    {
        [Key]
        public int PK_IdMandoTipoNomina { get; set; }

        public int FK_IdMando__RHCT { get; set; }

        public int FK_IdTipoNomina__NOMI { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public virtual Mando Mando { get; set; }
    }
}
