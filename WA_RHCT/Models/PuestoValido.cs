namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PuestoValido")]
    public partial class PuestoValido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PuestoValido()
        {
            PersonaPlaza = new HashSet<PersonaPlaza>();
        }

        [Key]
        public int PK_IdPuestoValido { get; set; }

        public int FK_IdClasePuesto__RHCT { get; set; }

        [Required]
        [StringLength(7)]
        public string ClavePuesto { get; set; }

        public virtual ClasePuesto ClasePuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }
    }
}
