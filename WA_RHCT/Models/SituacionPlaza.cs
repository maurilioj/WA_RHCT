namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.SituacionPlaza")]
    public partial class SituacionPlaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SituacionPlaza()
        {
            KardexPlaza = new HashSet<KardexPlaza>();
            ParametrizacionPlaza = new HashSet<ParametrizacionPlaza>();
            ParametrizacionPlaza1 = new HashSet<ParametrizacionPlaza>();
            ParametrizacionPlaza2 = new HashSet<ParametrizacionPlaza>();
            ParametrizacionPlaza3 = new HashSet<ParametrizacionPlaza>();
            PlazaAutorizada = new HashSet<PlazaAutorizada>();
            PlazaEstatus = new HashSet<PlazaEstatus>();
        }

        [Key]
        public int PK_IdSituacionPlaza { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KardexPlaza> KardexPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametrizacionPlaza> ParametrizacionPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametrizacionPlaza> ParametrizacionPlaza1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametrizacionPlaza> ParametrizacionPlaza2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametrizacionPlaza> ParametrizacionPlaza3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaAutorizada> PlazaAutorizada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaEstatus> PlazaEstatus { get; set; }
    }
}
