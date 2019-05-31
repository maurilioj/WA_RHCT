namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.MotivoLicencia")]
    public partial class MotivoLicencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MotivoLicencia()
        {
            EmpleadoSeguimientoLicencia = new HashSet<EmpleadoSeguimientoLicencia>();
        }

        [Key]
        public int PK_IdMotivoLicencia { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoSeguimientoLicencia> EmpleadoSeguimientoLicencia { get; set; }
    }
}
