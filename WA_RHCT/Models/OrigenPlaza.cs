namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.OrigenPlaza")]
    public partial class OrigenPlaza
    {
        [Key]
        public int PK_IdOrigenPlaza { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int FK_IdMotivoMovto__RHCT { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        public virtual MotivoMovto MotivoMovto { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
