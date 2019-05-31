namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Movimiento")]
    public partial class Movimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movimiento()
        {
            ConsecutivoMovimientoPersonal = new HashSet<ConsecutivoMovimientoPersonal>();
            HistoricoMovimientoPersonal2 = new HashSet<HistoricoMovimientoPersonal2>();
            MotivoMovto = new HashSet<MotivoMovto>();
        }

        [Key]
        public int PK_IdMovimiento { get; set; }

        [StringLength(5)]
        public string Clave { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(3)]
        public string Abreviatura { get; set; }

        public bool AplicaHistorico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsecutivoMovimientoPersonal> ConsecutivoMovimientoPersonal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal2> HistoricoMovimientoPersonal2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotivoMovto> MotivoMovto { get; set; }
    }
}
