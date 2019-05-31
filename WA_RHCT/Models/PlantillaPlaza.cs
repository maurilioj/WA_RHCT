namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PlantillaPlaza")]
    public partial class PlantillaPlaza
    {
        [Key]
        public int PK_IdPlantillaPlaza { get; set; }

        public int FK_IdPlazaAutorizada__RHCT { get; set; }

        public int FK_IdEstructProgramatica__NOMI { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public int? FK_IdTipoPlaza__RHCT { get; set; }

        public int Plaza { get; set; }

        public int ZonaEconomica { get; set; }

        public decimal Horas { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        [Required]
        [StringLength(50)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        public virtual PlazaAutorizada PlazaAutorizada { get; set; }

        public virtual Puesto Puesto { get; set; }

        public virtual TipoPlaza TipoPlaza { get; set; }
    }
}
