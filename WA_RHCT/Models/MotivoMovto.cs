namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.MotivoMovto")]
    public partial class MotivoMovto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MotivoMovto()
        {
            DatosMovto = new HashSet<DatosMovto>();
            ErrorMovto = new HashSet<ErrorMovto>();
            HojaUnicaServicio = new HashSet<HojaUnicaServicio>();
            Kardex = new HashSet<Kardex>();
            Licencia = new HashSet<Licencia>();
            ParametrizacionPersona = new HashSet<ParametrizacionPersona>();
            ParametrizacionPlaza = new HashSet<ParametrizacionPlaza>();
            PlazaEstatus = new HashSet<PlazaEstatus>();
            MovimientoPlaza = new HashSet<MovimientoPlaza>();
            MovPreparado = new HashSet<MovPreparado>();
            OrigenPlaza = new HashSet<OrigenPlaza>();
            PersonaPlaza = new HashSet<PersonaPlaza>();
        }

        [Key]
        public int PK_IdMotivoMovto { get; set; }

        public int FK_IdMovimiento__RHCT { get; set; }

        public int FK_IdClaseMovto__RHCT { get; set; }

        public int Clave { get; set; }

        public int Motivo { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        public virtual ClaseMovto ClaseMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorMovto> ErrorMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HojaUnicaServicio> HojaUnicaServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencia> Licencia { get; set; }

        public virtual Movimiento Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametrizacionPersona> ParametrizacionPersona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametrizacionPlaza> ParametrizacionPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaEstatus> PlazaEstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoPlaza> MovimientoPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovPreparado> MovPreparado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrigenPlaza> OrigenPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }
    }
}
