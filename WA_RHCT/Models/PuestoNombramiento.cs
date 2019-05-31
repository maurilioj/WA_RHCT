namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PuestoNombramiento")]
    public partial class PuestoNombramiento
    {
        [Key]
        public int PK_IdPuestoNombramiento { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
