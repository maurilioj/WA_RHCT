namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Plaza")]
    public partial class Plaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plaza()
        {
            ConsultaPlaza = new HashSet<ConsultaPlaza>();
            DetMovPlaza = new HashSet<DetMovPlaza>();
            EmpleadoBasificacion = new HashSet<EmpleadoBasificacion>();
            Licencia = new HashSet<Licencia>();
            OrigenPlaza = new HashSet<OrigenPlaza>();
            PersonaConstanciasISSSTE = new HashSet<PersonaConstanciasISSSTE>();
            PersonaDosHoras = new HashSet<PersonaDosHoras>();
            PersonaMasiva = new HashSet<PersonaMasiva>();
        }

        [Key]
        public int PK_IdPlaza { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_IdEstructProgramatica__NOMI { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        [Column("Plaza")]
        public int Plaza1 { get; set; }

        public int ZonaEconomica { get; set; }

        public decimal Horas { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public int TipoPlaza { get; set; }

        public int Estructura { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaPlaza> ConsultaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetMovPlaza> DetMovPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoBasificacion> EmpleadoBasificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencia> Licencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrigenPlaza> OrigenPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaConstanciasISSSTE> PersonaConstanciasISSSTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaDosHoras> PersonaDosHoras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaMasiva> PersonaMasiva { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual Puesto Puesto { get; set; }
    }
}
