namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TipoDescanso")]
    public partial class TipoDescanso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDescanso()
        {
            DiasDescanso = new HashSet<DiasDescanso>();
        }

        [Key]
        public int PK_IdTipoDescanso { get; set; }

        [Required]
        [StringLength(80)]
        public string Descripcion { get; set; }

        public int Clave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasDescanso> DiasDescanso { get; set; }
    }
}
