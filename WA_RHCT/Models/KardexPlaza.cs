namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.KardexPlaza")]
    public partial class KardexPlaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KardexPlaza()
        {
            PlazaAutorizada1 = new HashSet<PlazaAutorizada>();
        }

        [Key]
        public int PK_IdKardexPlaza { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int FK_IdAreaDocto__SIS { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int Plaza { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public int QuincenaAplicacion { get; set; }

        public int FK_IdSituacionPlaza__RHCT { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual SituacionPlaza SituacionPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaAutorizada> PlazaAutorizada1 { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
