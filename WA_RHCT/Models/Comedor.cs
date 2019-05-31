namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Comedor")]
    public partial class Comedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comedor()
        {
            DatosMovto = new HashSet<DatosMovto>();
            PersonaPlaza = new HashSet<PersonaPlaza>();
        }

        [Key]
        public int PK_IdComedor { get; set; }

        [Required]
        [StringLength(32)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(32)]
        public string Horario { get; set; }

        public int Alimentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }
    }
}
