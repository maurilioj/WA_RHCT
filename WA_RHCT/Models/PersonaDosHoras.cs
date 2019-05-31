namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.PersonaDosHoras")]
    public partial class PersonaDosHoras
    {
        [Key]
        public int PK_IdPersonaDosHoras { get; set; }

        public int FK_IdPersona__RHCT { get; set; }

        public int QuincenaIncidencia { get; set; }

        public DateTime FechaIncidencia { get; set; }

        public int FK_IdNombramiento__RHCT { get; set; }

        public int FK_IdPlaza__RHCT { get; set; }

        public int FK_IdHorario__RHCT { get; set; }

        public int FK_IdTurno__RHCT { get; set; }

        public int ClaveAutorizacion { get; set; }

        public decimal Horas { get; set; }

        [Required]
        [StringLength(2)]
        public string HoraInicio { get; set; }

        [Required]
        [StringLength(2)]
        public string MinutoInicio { get; set; }

        [Required]
        [StringLength(2)]
        public string HoraFin { get; set; }

        [Required]
        [StringLength(2)]
        public string MinutoFin { get; set; }

        [Required]
        [StringLength(32)]
        public string Documento { get; set; }

        public DateTime FechaDocumento { get; set; }

        public int IdUsuario { get; set; }

        [StringLength(40)]
        public string TerminalCaptura { get; set; }

        public DateTime FechaCaptura { get; set; }

        public int QuincenaCaptura { get; set; }

        public int ConsecutivoCaptura { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public virtual Horario Horario { get; set; }

        public virtual Nombramiento Nombramiento { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Turno Turno { get; set; }

        public virtual Plaza Plaza { get; set; }
    }
}
