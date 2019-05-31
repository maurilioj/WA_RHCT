namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PlazaAutorizada")]
    public partial class PlazaAutorizada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlazaAutorizada()
        {
            DatosMovto = new HashSet<DatosMovto>();
            HI_Empleado = new HashSet<HI_Empleado>();
            Kardex = new HashSet<Kardex>();
            KardexPlaza = new HashSet<KardexPlaza>();
            MovPreparado = new HashSet<MovPreparado>();
            PersonaPlaza = new HashSet<PersonaPlaza>();
            PlantillaPlaza = new HashSet<PlantillaPlaza>();
            Plaza1 = new HashSet<Plaza>();
            PlazaEstatus = new HashSet<PlazaEstatus>();
            QN_Empleado = new HashSet<QN_Empleado>();
        }

        [Key]
        public int PK_IdPlazaAutorizada { get; set; }

        public int? FK_IdEstructProgramatica__NOMI { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int? FK_IdAreaDocto__SIS { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int? FK_IdKardexPlaza__RHCT { get; set; }

        public int? FK_IdSituacionPlaza__RHCT { get; set; }

        public int Plaza { get; set; }

        public int? ZonaEconomica { get; set; }

        public decimal? Horas { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public int? TipoPlaza { get; set; }

        public int? Estructura { get; set; }

        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime? FechaDocumento { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HI_Empleado> HI_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KardexPlaza> KardexPlaza { get; set; }

        public virtual KardexPlaza KardexPlaza1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovPreparado> MovPreparado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlantillaPlaza> PlantillaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plaza> Plaza1 { get; set; }

        public virtual SituacionPlaza SituacionPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaEstatus> PlazaEstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QN_Empleado> QN_Empleado { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
