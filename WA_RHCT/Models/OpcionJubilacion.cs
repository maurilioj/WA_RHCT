namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.OpcionJubilacion")]
    public partial class OpcionJubilacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpcionJubilacion()
        {
            HistoricoMovimientoPersonal_OpcionJubilacion = new HashSet<HistoricoMovimientoPersonal_OpcionJubilacion>();
            HistoricoMovimientoPersonal_OpcionJubilacion1 = new HashSet<HistoricoMovimientoPersonal_OpcionJubilacion>();
            Persona = new HashSet<Persona>();
        }

        [Key]
        public int PK_IdOpcionJubilacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_OpcionJubilacion> HistoricoMovimientoPersonal_OpcionJubilacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_OpcionJubilacion> HistoricoMovimientoPersonal_OpcionJubilacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
