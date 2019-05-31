namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Credencial")]
    public partial class Credencial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Credencial()
        {
            PuestoCredencial = new HashSet<PuestoCredencial>();
        }

        [Key]
        public int PK_IdCredencial { get; set; }

        [Required]
        [StringLength(32)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string Abreviatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestoCredencial> PuestoCredencial { get; set; }
    }
}
