namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Dependencia")]
    public partial class Dependencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dependencia()
        {
            Kardex = new HashSet<Kardex>();
        }

        [Key]
        public int PK_IdDependencia { get; set; }

        [Required]
        [StringLength(20)]
        public string Clave { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Column("Dependencia")]
        [Required]
        [StringLength(200)]
        public string Dependencia1 { get; set; }

        public string Observacion { get; set; }

        public string Nota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }
    }
}
