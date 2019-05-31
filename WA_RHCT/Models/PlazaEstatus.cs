namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PlazaEstatus")]
    public partial class PlazaEstatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlazaEstatus()
        {
            ConsultaPlaza = new HashSet<ConsultaPlaza>();
        }

        [Key]
        public int PK_IdPlazaEstatus { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_IdSituacionPlaza__RHCT { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaPlaza> ConsultaPlaza { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual SituacionPlaza SituacionPlaza { get; set; }
    }
}
