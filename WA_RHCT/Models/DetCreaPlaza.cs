namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DetCreaPlaza")]
    public partial class DetCreaPlaza
    {
        [Key]
        public int PK_IdDetCreaPlaza { get; set; }

        public int FK_IdMovimientoPlaza__RHCT { get; set; }

        public int FK_IdArea__SIS { get; set; }

        public int FK_IdEstructProgramatica__NOMI { get; set; }

        public int FK_IdPuesto__RHCT { get; set; }

        public decimal Horas { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int QuincenaInicio { get; set; }

        public int QuincenaFin { get; set; }

        public int NumeroPlazas { get; set; }

        public bool DeTransferencia { get; set; }

        public int? QuincenaCaptura { get; set; }

        public int? ConsecutivoCaptura { get; set; }

        public DateTime? FechaAplicacion { get; set; }

        public int? QuincenaAplicacion { get; set; }

        public int? ConsecutivoAplicacion { get; set; }

        public bool AplicaMovto { get; set; }
    }
}
