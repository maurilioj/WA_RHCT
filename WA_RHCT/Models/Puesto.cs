namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Puesto")]
    public partial class Puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puesto()
        {
            ComparativoPlaza = new HashSet<ComparativoPlaza>();
            DatosMovto = new HashSet<DatosMovto>();
            DatosTransferencia = new HashSet<DatosTransferencia>();
            HI_Empleado = new HashSet<HI_Empleado>();
            HistoricoMovimientoPersonal = new HashSet<HistoricoMovimientoPersonal>();
            HistoricoMovimientoPersonal_FormaPago = new HashSet<HistoricoMovimientoPersonal_FormaPago>();
            HistoricoMovimientoPersonal_OpcionJubilacion = new HashSet<HistoricoMovimientoPersonal_OpcionJubilacion>();
            HistoricoMovimientoPersonal_SeccionSindical = new HashSet<HistoricoMovimientoPersonal_SeccionSindical>();
            HistoricoMovimientoPersonal2 = new HashSet<HistoricoMovimientoPersonal2>();
            HojaUnicaServicio = new HashSet<HojaUnicaServicio>();
            Kardex = new HashSet<Kardex>();
            KardexPlaza = new HashSet<KardexPlaza>();
            MovimientoPlaza = new HashSet<MovimientoPlaza>();
            PlantillaPlaza = new HashSet<PlantillaPlaza>();
            Plaza = new HashSet<Plaza>();
            PlazaAutorizada = new HashSet<PlazaAutorizada>();
            PuestoCredencial = new HashSet<PuestoCredencial>();
            QN_Empleado = new HashSet<QN_Empleado>();
            PuestoNombramiento = new HashSet<PuestoNombramiento>();
            PuestoRetabular = new HashSet<PuestoRetabular>();
            PuestoRetabular1 = new HashSet<PuestoRetabular>();
        }

        [Key]
        public int PK_IdPuesto { get; set; }

        public int? FK_IdPuestoValido__RHCT { get; set; }

        public int? FK_IdRama__RHCT { get; set; }

        public int? FK_IdPuestoSecodam__RHCT { get; set; }

        public int FK_IdTipoPuesto__RHCT { get; set; }

        public int FK_IdAreaDocto__RHCT { get; set; }

        public int? FK_IdNivel__RHCT { get; set; }

        [Required]
        [StringLength(15)]
        public string Clave { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int? Mando { get; set; }

        public decimal? Horas { get; set; }

        public int? Orden { get; set; }

        [Required]
        [StringLength(64)]
        public string Descripcion1 { get; set; }

        [StringLength(64)]
        public string Descripcion2 { get; set; }

        [StringLength(4)]
        public string Nivel { get; set; }

        [StringLength(200)]
        public string DescripcionCompletaPuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComparativoPlaza> ComparativoPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosTransferencia> DatosTransferencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HI_Empleado> HI_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal> HistoricoMovimientoPersonal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_FormaPago> HistoricoMovimientoPersonal_FormaPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_OpcionJubilacion> HistoricoMovimientoPersonal_OpcionJubilacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_SeccionSindical> HistoricoMovimientoPersonal_SeccionSindical { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal2> HistoricoMovimientoPersonal2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HojaUnicaServicio> HojaUnicaServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KardexPlaza> KardexPlaza { get; set; }

        public virtual Mando Mando1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoPlaza> MovimientoPlaza { get; set; }

        public virtual Nivel Nivel1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlantillaPlaza> PlantillaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plaza> Plaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaAutorizada> PlazaAutorizada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestoCredencial> PuestoCredencial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QN_Empleado> QN_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestoNombramiento> PuestoNombramiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestoRetabular> PuestoRetabular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestoRetabular> PuestoRetabular1 { get; set; }
    }
}
