namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.AsistenciaQuincena")]
    public partial class AsistenciaQuincena
    {
        [Key]
        public int PK_IdAsistenciaQuincena { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int FK_IdRadicacionPago__RHCT { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public int FK_IdMando__RHCT { get; set; }

        public int FK_IdEstatusReloj__RHCT { get; set; }

        public int? FK_IdDiasDescanso__RHCT { get; set; }

        public int? FK_IdIncidencia__RHCT { get; set; }

        public DateTime Fecha { get; set; }
    }
}
