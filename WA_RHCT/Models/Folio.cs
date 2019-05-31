namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Folio")]
    public partial class Folio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Folio()
        {
            FolioCancelado = new HashSet<FolioCancelado>();
        }

        [Key]
        public int PK_IdFolio { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        [Column("Folio")]
        public int Folio1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolioCancelado> FolioCancelado { get; set; }
    }
}
