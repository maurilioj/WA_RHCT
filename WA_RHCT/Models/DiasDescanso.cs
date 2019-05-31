namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.DiasDescanso")]
    public partial class DiasDescanso
    {
        [Key]
        public int PK_IdDiasDescanso { get; set; }

        public DateTime FchaInicio { get; set; }

        public DateTime FchaFin { get; set; }

        public int FK_IdTipoDescanso__RHCT { get; set; }

        public int? FK_IdRadicacionPago__RHCT { get; set; }

        public int? FK_IdNombramiento__RHCT { get; set; }

        public int? FK_IdMando__RHCT { get; set; }

        public bool? Sexo { get; set; }

        [Required]
        [StringLength(25)]
        public string Referencia { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public string Observaciones { get; set; }

        public virtual Mando Mando { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual RadicacionPago RadicacionPago { get; set; }

        public virtual TipoDescanso TipoDescanso { get; set; }
    }
}
