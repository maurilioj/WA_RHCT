namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.RadicacionPago")]
    public partial class RadicacionPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RadicacionPago()
        {
            DatosMovto = new HashSet<DatosMovto>();
            DiasDescanso = new HashSet<DiasDescanso>();
            HistoricoMovimientoPersonal_SeccionSindical = new HashSet<HistoricoMovimientoPersonal_SeccionSindical>();
            PersonaPlaza = new HashSet<PersonaPlaza>();
        }

        [Key]
        public int PK_IdRadicacionPago { get; set; }

        public int FK_IdMunicipio__SIS { get; set; }

        public int ZonaEconomica { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(64)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(64)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo_Postal { get; set; }

        [Required]
        [StringLength(32)]
        public string Telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasDescanso> DiasDescanso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_SeccionSindical> HistoricoMovimientoPersonal_SeccionSindical { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }
    }
}
