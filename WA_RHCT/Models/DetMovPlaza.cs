namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DetMovPlaza")]
    public partial class DetMovPlaza
    {
        [Key]
        public int PK_IdDetMovPlaza { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int FK_IdTipoPlaza__RHCT { get; set; }

        public int ZonaEconomica { get; set; }

        public int IdEstructProgramatica { get; set; }

        public int ZonaEconomica_T { get; set; }

        public int IdSituacionMovimiento { get; set; }

        public decimal Horas { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public int IdUsuario { get; set; }

        [Required]
        [StringLength(40)]
        public string TerminalCaptura { get; set; }

        public DateTime FechaCaptura { get; set; }

        public int QuincenaCaptura { get; set; }

        public int ConsecutivoCaptura { get; set; }

        public int FK_IdUsuario__SIS { get; set; }

        [Required]
        [StringLength(40)]
        public string TerminalAplica { get; set; }

        public DateTime FechaAplicacion { get; set; }

        public int QuincenaAplicacion { get; set; }

        public int ConsecutivoAplicacion { get; set; }

        public bool AplicaMovto { get; set; }

        public virtual SituacionMovimiento SituacionMovimiento { get; set; }

        public virtual TipoPlaza TipoPlaza { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
