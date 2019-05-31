namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.FolioCancelado")]
    public partial class FolioCancelado
    {
        [Key]
        public int PK_IdFolioCancelado { get; set; }

        public int FK_IdFolio__RHCT { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public virtual Folio Folio { get; set; }
    }
}
