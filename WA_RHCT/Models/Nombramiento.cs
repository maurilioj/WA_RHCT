namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Nombramiento")]
    public partial class Nombramiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nombramiento()
        {
            DatosMovto = new HashSet<DatosMovto>();
            DiasDescanso = new HashSet<DiasDescanso>();
            HI_Empleado = new HashSet<HI_Empleado>();
            HistoricoMovimientoPersonal = new HashSet<HistoricoMovimientoPersonal>();
            HistoricoMovimientoPersonal2 = new HashSet<HistoricoMovimientoPersonal2>();
            Kardex = new HashSet<Kardex>();
            QN_Empleado = new HashSet<QN_Empleado>();
            PersonaConstanciasISSSTE = new HashSet<PersonaConstanciasISSSTE>();
            PersonaDosHoras = new HashSet<PersonaDosHoras>();
            PersonaPlaza = new HashSet<PersonaPlaza>();
            PuestoNombramiento = new HashSet<PuestoNombramiento>();
        }

        [Key]
        public int PK_IdNombramiento { get; set; }

        public int FK_IdPartida__SIS { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasDescanso> DiasDescanso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HI_Empleado> HI_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal> HistoricoMovimientoPersonal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal2> HistoricoMovimientoPersonal2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QN_Empleado> QN_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaConstanciasISSSTE> PersonaConstanciasISSSTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaDosHoras> PersonaDosHoras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestoNombramiento> PuestoNombramiento { get; set; }
    }
}
