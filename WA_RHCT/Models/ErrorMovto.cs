namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ErrorMovto")]
    public partial class ErrorMovto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ErrorMovto()
        {
            ErrorMovtoPlaza = new HashSet<ErrorMovtoPlaza>();
        }

        [Key]
        public int PK_IdErrorMovto { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public int FK_IdError__SIS { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public int QuincenaInicioProcesoError { get; set; }

        public int Consecutivo { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorMovtoPlaza> ErrorMovtoPlaza { get; set; }
    }
}
