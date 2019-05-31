namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PuestoCredencial")]
    public partial class PuestoCredencial
    {
        [Key]
        public int PK_IdPuestoCredencial { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdCredencial__RHCT { get; set; }

        public virtual Credencial Credencial { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
