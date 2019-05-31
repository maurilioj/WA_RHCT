namespace WA_RHCT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RHCT.Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Antiguedad = new HashSet<Antiguedad>();
            BasificadoOE = new HashSet<BasificadoOE>();
            ConsultaPlaza = new HashSet<ConsultaPlaza>();
            CuentaPersona = new HashSet<CuentaPersona>();
            CuentaPersonaBanamex = new HashSet<CuentaPersonaBanamex>();
            DatosCedulaRegistro = new HashSet<DatosCedulaRegistro>();
            DatosMovto = new HashSet<DatosMovto>();
            DatosTransferencia = new HashSet<DatosTransferencia>();
            Dependiente = new HashSet<Dependiente>();
            DiasDerecho = new HashSet<DiasDerecho>();
            DiasLaborados = new HashSet<DiasLaborados>();
            DiasRealesVacaciones = new HashSet<DiasRealesVacaciones>();
            DiasReservados = new HashSet<DiasReservados>();
            DiasReservadosVacaciones = new HashSet<DiasReservadosVacaciones>();
            Direccion = new HashSet<Direccion>();
            EmpleadoBasificacion = new HashSet<EmpleadoBasificacion>();
            EmpleadoDiasEconomicos = new HashSet<EmpleadoDiasEconomicos>();
            EmpleadoFechaIngreso = new HashSet<EmpleadoFechaIngreso>();
            EmpleadoFechaVacaciones = new HashSet<EmpleadoFechaVacaciones>();
            EmpleadoFechaVacacionesSemes = new HashSet<EmpleadoFechaVacacionesSemes>();
            EmpleadoSeguimientoLicencia = new HashSet<EmpleadoSeguimientoLicencia>();
            EmpleadoTarjetaObservaciones = new HashSet<EmpleadoTarjetaObservaciones>();
            FechasIngreso = new HashSet<FechasIngreso>();
            FechaVacaciones = new HashSet<FechaVacaciones>();
            GuardiaPersonal = new HashSet<GuardiaPersonal>();
            HI_Empleado = new HashSet<HI_Empleado>();
            HistoricoMovimientoPersonal = new HashSet<HistoricoMovimientoPersonal>();
            HistoricoMovimientoPersonal_FormaPago = new HashSet<HistoricoMovimientoPersonal_FormaPago>();
            HistoricoMovimientoPersonal_OpcionJubilacion = new HashSet<HistoricoMovimientoPersonal_OpcionJubilacion>();
            HistoricoMovimientoPersonal_SeccionSindical = new HashSet<HistoricoMovimientoPersonal_SeccionSindical>();
            HistoricoMovimientoPersonal2 = new HashSet<HistoricoMovimientoPersonal2>();
            HojaUnicaServicio = new HashSet<HojaUnicaServicio>();
            Incidencia = new HashSet<Incidencia>();
            Kardex = new HashSet<Kardex>();
            Licencia = new HashSet<Licencia>();
            MovPreparado = new HashSet<MovPreparado>();
            PeriodoVacaciones = new HashSet<PeriodoVacaciones>();
            PersonaEscolaridad = new HashSet<PersonaEscolaridad>();
            PersonaResponsableArea = new HashSet<PersonaResponsableArea>();
            QN_Empleado = new HashSet<QN_Empleado>();
            PersonaConstanciasISSSTE = new HashSet<PersonaConstanciasISSSTE>();
            PersonaControlLicencia = new HashSet<PersonaControlLicencia>();
            PersonaDosHoras = new HashSet<PersonaDosHoras>();
            PersonaFirma = new HashSet<PersonaFirma>();
            PersonaMasiva = new HashSet<PersonaMasiva>();
            PersonaOnomastico = new HashSet<PersonaOnomastico>();
            PersonaPadecimiento = new HashSet<PersonaPadecimiento>();
            PersonaPlaza = new HashSet<PersonaPlaza>();
            PrimaVacacional = new HashSet<PrimaVacacional>();
            Vacaciones = new HashSet<Vacaciones>();
        }

        [Key]
        public int PK_IdPersona { get; set; }

        [Required]
        [StringLength(15)]
        public string Clave { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Paterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Materno { get; set; }

        [StringLength(255)]
        public string Dirección { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(15)]
        public string Celular { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        [StringLength(15)]
        public string RFC { get; set; }

        [Required]
        [StringLength(18)]
        public string Curp { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        public int FK_IdEstadoCivil__RHCT { get; set; }

        public int FK_IdTipoPersonal__RHCT { get; set; }

        public int? FK_IdMunicipio__SIS { get; set; }

        public int FK_IdNacionalidad__RHCT { get; set; }

        public int FK_IdEscolaridad__RHCT { get; set; }

        public bool Titulado { get; set; }

        public DateTime? FechaTitulacion { get; set; }

        [StringLength(12)]
        public string NumSegSocial { get; set; }

        [StringLength(32)]
        public string PermisoGobe { get; set; }

        [StringLength(16)]
        public string NoCartilla { get; set; }

        [StringLength(16)]
        public string NoLicencia { get; set; }

        [StringLength(16)]
        public string NoPasaporte { get; set; }

        [StringLength(16)]
        public string NoCedulaProfesional { get; set; }

        [StringLength(32)]
        public string NoCredencialElector { get; set; }

        public int? FK_IdTipoCarrera__RHCT { get; set; }

        [StringLength(1000)]
        public string FL_FOTO { get; set; }

        [StringLength(15)]
        public string Expediente { get; set; }

        [StringLength(40)]
        public string Calle { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(40)]
        public string Colonia { get; set; }

        [StringLength(6)]
        public string CP { get; set; }

        public int? FK_IdOpcionJubilacion { get; set; }

        [StringLength(4)]
        public string PorcentajeAhorro { get; set; }

        [StringLength(250)]
        public string MailPersonal { get; set; }

        [StringLength(250)]
        public string MailInstitucional { get; set; }

        public int? FK_IdTallaVestimenta__RHCT { get; set; }

        public int? FK_IdEstadoSalud__RHCT { get; set; }

        public int? FK_IdComprobanteEstudios__RHCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Antiguedad> Antiguedad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasificadoOE> BasificadoOE { get; set; }

        public virtual ComprobanteEstudios ComprobanteEstudios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaPlaza> ConsultaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaPersona> CuentaPersona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaPersonaBanamex> CuentaPersonaBanamex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosCedulaRegistro> DatosCedulaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosMovto> DatosMovto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosTransferencia> DatosTransferencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dependiente> Dependiente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasDerecho> DiasDerecho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasLaborados> DiasLaborados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasRealesVacaciones> DiasRealesVacaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasReservados> DiasReservados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiasReservadosVacaciones> DiasReservadosVacaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Direccion> Direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoBasificacion> EmpleadoBasificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoDiasEconomicos> EmpleadoDiasEconomicos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoFechaIngreso> EmpleadoFechaIngreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoFechaVacaciones> EmpleadoFechaVacaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoFechaVacacionesSemes> EmpleadoFechaVacacionesSemes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoSeguimientoLicencia> EmpleadoSeguimientoLicencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoTarjetaObservaciones> EmpleadoTarjetaObservaciones { get; set; }

        public virtual Escolaridad Escolaridad { get; set; }

        public virtual EstadoCivil EstadoCivil { get; set; }

        public virtual EstadoSalud EstadoSalud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FechasIngreso> FechasIngreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FechaVacaciones> FechaVacaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaPersonal> GuardiaPersonal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HI_Empleado> HI_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal> HistoricoMovimientoPersonal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_FormaPago> HistoricoMovimientoPersonal_FormaPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_OpcionJubilacion> HistoricoMovimientoPersonal_OpcionJubilacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal_SeccionSindical> HistoricoMovimientoPersonal_SeccionSindical { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoMovimientoPersonal2> HistoricoMovimientoPersonal2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HojaUnicaServicio> HojaUnicaServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencia> Licencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovPreparado> MovPreparado { get; set; }

        public virtual Nacionalidad Nacionalidad { get; set; }

        public virtual OpcionJubilacion OpcionJubilacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeriodoVacaciones> PeriodoVacaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaEscolaridad> PersonaEscolaridad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaResponsableArea> PersonaResponsableArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QN_Empleado> QN_Empleado { get; set; }

        public virtual TallaVestimenta TallaVestimenta { get; set; }

        public virtual TipoPersonal TipoPersonal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaConstanciasISSSTE> PersonaConstanciasISSSTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaControlLicencia> PersonaControlLicencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaDosHoras> PersonaDosHoras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaFirma> PersonaFirma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaMasiva> PersonaMasiva { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaOnomastico> PersonaOnomastico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPadecimiento> PersonaPadecimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaPlaza> PersonaPlaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimaVacacional> PrimaVacacional { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }
    }
}
