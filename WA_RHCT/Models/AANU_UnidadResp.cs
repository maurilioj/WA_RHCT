namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.AANU_UnidadResp")]
    public partial class AANU_UnidadResp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AANU_UnidadResp()
        {
            AANU_CentroTrabajo = new HashSet<AANU_CentroTrabajo>();
        }

        [Key]
        public int PK_IdUnidadResp { get; set; }

        [Required]
        [StringLength(3)]
        public string Clave { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AANU_CentroTrabajo> AANU_CentroTrabajo { get; set; }
    }
}
