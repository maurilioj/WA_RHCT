namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Reloj")]
    public partial class Reloj
    {
        [Key]
        public int PK_IdReloj { get; set; }

        public int Lector { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(15)]
        public string NumEmp { get; set; }

        [StringLength(15)]
        public string Codigo { get; set; }
    }
}
