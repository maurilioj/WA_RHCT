namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DatosCedulaRegistro")]
    public partial class DatosCedulaRegistro
    {
        [Key]
        public int PK_IdDatosCedulaRegistro { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int? FK_IdAnio__SIS { get; set; }

        [StringLength(10)]
        public string Acta { get; set; }

        [StringLength(10)]
        public string Foja { get; set; }

        [StringLength(10)]
        public string Libro { get; set; }

        [StringLength(10)]
        public string NumRegistro { get; set; }

        [StringLength(50)]
        public string Dependencia { get; set; }

        [StringLength(50)]
        public string Entidad { get; set; }

        [StringLength(50)]
        public string Unidad { get; set; }

        [StringLength(50)]
        public string PuestoPropuesto { get; set; }

        [StringLength(10)]
        public string Nivel { get; set; }

        [StringLength(50)]
        public string EmpleoAnterior { get; set; }

        [StringLength(50)]
        public string PuestoAnterior { get; set; }

        [StringLength(50)]
        public string Pais { get; set; }

        [StringLength(10)]
        public string Fm { get; set; }

        [StringLength(10)]
        public string Vigencia1 { get; set; }

        [StringLength(10)]
        public string Vigencia2 { get; set; }

        [StringLength(50)]
        public string PuestoAutorizado { get; set; }

        [StringLength(50)]
        public string Madre { get; set; }

        [StringLength(50)]
        public string Padre { get; set; }

        [StringLength(50)]
        public string Conyugue { get; set; }

        [StringLength(2)]
        public string Hijos { get; set; }

        [StringLength(2)]
        public string Padres { get; set; }

        [StringLength(2)]
        public string Otros { get; set; }

        [StringLength(50)]
        public string Estudios { get; set; }

        [StringLength(50)]
        public string MaxCredComp { get; set; }

        [StringLength(50)]
        public string Instituto { get; set; }

        [StringLength(10)]
        public string FechaInicio { get; set; }

        [StringLength(10)]
        public string FechaFin { get; set; }

        [StringLength(50)]
        public string Idiomas { get; set; }

        [StringLength(50)]
        public string Especializacion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
