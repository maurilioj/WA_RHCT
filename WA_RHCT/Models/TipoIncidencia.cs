namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.TipoIncidencia")]
    public partial class TipoIncidencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoIncidencia()
        {
            Incidencia = new HashSet<Incidencia>();
        }

        [Key]
        public int PK_IdTipoIncidencia { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public string Observaciones { get; set; }

        public int? Limite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }
    }
}
