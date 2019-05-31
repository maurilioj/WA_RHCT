namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.ConsultaPlaza")]
    public partial class ConsultaPlaza
    {
        [Key]
        public int PK_IdConsultaPlaza { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int FK_IdPlazaEstatus__RHCT { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public virtual PlazaEstatus PlazaEstatus { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
