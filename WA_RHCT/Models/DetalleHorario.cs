namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DetalleHorario")]
    public partial class DetalleHorario
    {
        [Key]
        public int PK_IdDetalleHorario { get; set; }

        public int? FK_IdHorario__RHCT { get; set; }

        public int FK_IdDia__SIS { get; set; }

        public TimeSpan? HoraEntrada { get; set; }

        public TimeSpan? HoraSalida { get; set; }

        public int RetrasoLeve { get; set; }

        public int RetrasoGrave { get; set; }

        public int ToleraAntesEntrada { get; set; }

        public int ToleraAntesSalida { get; set; }

        public int ToleraDespuesEntrada { get; set; }

        public int ToleraDespuesSalida { get; set; }

        public int FK_IdTipoDetalleHorario { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual Horario Horario { get; set; }
    }
}
