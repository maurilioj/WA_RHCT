namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PeriodoVacaciones")]
    public partial class PeriodoVacaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeriodoVacaciones()
        {
            DiasReservadosVacaciones = new HashSet<DiasReservadosVacaciones>();
        }

        [Key]
        public int PK_IdPeriodoVacaciones { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdTipoVacaciones__RHCT { get; set; }

        public int FK_IdAnio__SIS { get; set; }

        public int FK_IdDiasReservados__RHCT { get; set; }

        public int Periodo { get; set; }

        public DateTime FechaInicioPeriodo { get; set; }

        public DateTime FechaFinPeriodo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Dias { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DiasDisfrutados { get; set; }

        public virtual DiasReservados DiasReservados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasReservadosVacaciones> DiasReservadosVacaciones { get; set; }

        public virtual TipoVacaciones TipoVacaciones { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
