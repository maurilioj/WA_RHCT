namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaMasiva")]
    public partial class PersonaMasiva
    {
        [Key]
        public int PK_IdPersonaMasiva { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int IdSituacionPersona { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int FK_IdEscalaSalarial__RHCT { get; set; }

        public int IdClaseMovto { get; set; }

        public int QuincenaPago { get; set; }

        public int QuincenaInicioProceso { get; set; }

        public virtual ClaseMovto ClaseMovto { get; set; }

        public virtual EscalaSalarial EscalaSalarial { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual SituacionPersona SituacionPersona { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
