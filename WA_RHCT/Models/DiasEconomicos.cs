namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasEconomicos")]
    public partial class DiasEconomicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiasEconomicos()
        {
            EmpleadoDiasEconomicos = new HashSet<EmpleadoDiasEconomicos>();
        }

        [Key]
        public int PK_IdDiasEconomicos { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int TipoEconomico { get; set; }

        public int Dias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoDiasEconomicos> EmpleadoDiasEconomicos { get; set; }
    }
}
