namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Rama")]
    public partial class Rama
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rama()
        {
            HI_Empleado = new HashSet<HI_Empleado>();
            QN_Empleado = new HashSet<QN_Empleado>();
        }

        [Key]
        public int PK_IdRama { get; set; }

        public int FK_IdGrupoPuesto__RHCT { get; set; }

        [Required]
        [StringLength(2)]
        public string Clave { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        public virtual GrupoPuesto GrupoPuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HI_Empleado> HI_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QN_Empleado> QN_Empleado { get; set; }
    }
}
