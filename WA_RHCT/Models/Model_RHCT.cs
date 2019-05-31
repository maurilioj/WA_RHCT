namespace WA_RHCT.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_RHCT : DbContext
    {
        public Model_RHCT()
            : base("name=Model_RHCT")
        {
        }

        public virtual DbSet<AANU_CentroTrabajo> AANU_CentroTrabajo { get; set; }
        public virtual DbSet<AANU_UnidadResp> AANU_UnidadResp { get; set; }
        public virtual DbSet<Antiguedad> Antiguedad { get; set; }
        public virtual DbSet<AsistenciaQuincena> AsistenciaQuincena { get; set; }
        public virtual DbSet<BasificadoOE> BasificadoOE { get; set; }
        public virtual DbSet<CentroTrabajoVacaciones> CentroTrabajoVacaciones { get; set; }
        public virtual DbSet<ClaseMovto> ClaseMovto { get; set; }
        public virtual DbSet<ClasePuesto> ClasePuesto { get; set; }
        public virtual DbSet<ClasificadorIngreso> ClasificadorIngreso { get; set; }
        public virtual DbSet<Comedor> Comedor { get; set; }
        public virtual DbSet<ComparativoPlaza> ComparativoPlaza { get; set; }
        public virtual DbSet<ComprobanteEstudios> ComprobanteEstudios { get; set; }
        public virtual DbSet<ConsecutivoMovimientoPersonal> ConsecutivoMovimientoPersonal { get; set; }
        public virtual DbSet<ConsultaPlaza> ConsultaPlaza { get; set; }
        public virtual DbSet<Credencial> Credencial { get; set; }
        public virtual DbSet<CuentaPersona> CuentaPersona { get; set; }
        public virtual DbSet<CuentaPersonaBanamex> CuentaPersonaBanamex { get; set; }
        public virtual DbSet<DatosCedulaRegistro> DatosCedulaRegistro { get; set; }
        public virtual DbSet<DatosMovto> DatosMovto { get; set; }
        public virtual DbSet<DatosTransferencia> DatosTransferencia { get; set; }
        public virtual DbSet<Dependencia> Dependencia { get; set; }
        public virtual DbSet<Dependiente> Dependiente { get; set; }
        public virtual DbSet<DetalleHorario> DetalleHorario { get; set; }
        public virtual DbSet<DetCreaPlaza> DetCreaPlaza { get; set; }
        public virtual DbSet<DetMovPlaza> DetMovPlaza { get; set; }
        public virtual DbSet<DiasDerecho> DiasDerecho { get; set; }
        public virtual DbSet<DiasDescanso> DiasDescanso { get; set; }
        public virtual DbSet<DiasEconomicos> DiasEconomicos { get; set; }
        public virtual DbSet<DiasLaborados> DiasLaborados { get; set; }
        public virtual DbSet<DiasNohabiles> DiasNohabiles { get; set; }
        public virtual DbSet<DiasRealesVacaciones> DiasRealesVacaciones { get; set; }
        public virtual DbSet<DiasReservados> DiasReservados { get; set; }
        public virtual DbSet<DiasReservadosVacaciones> DiasReservadosVacaciones { get; set; }
        public virtual DbSet<DictamenISSSTE> DictamenISSSTE { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<EmpleadoBasificacion> EmpleadoBasificacion { get; set; }
        public virtual DbSet<EmpleadoDiasEconomicos> EmpleadoDiasEconomicos { get; set; }
        public virtual DbSet<EmpleadoFechaIngreso> EmpleadoFechaIngreso { get; set; }
        public virtual DbSet<EmpleadoFechaVacaciones> EmpleadoFechaVacaciones { get; set; }
        public virtual DbSet<EmpleadoFechaVacacionesSemes> EmpleadoFechaVacacionesSemes { get; set; }
        public virtual DbSet<EmpleadoSeguimientoLicencia> EmpleadoSeguimientoLicencia { get; set; }
        public virtual DbSet<EmpleadoTarjetaObservaciones> EmpleadoTarjetaObservaciones { get; set; }
        public virtual DbSet<ErrorMovto> ErrorMovto { get; set; }
        public virtual DbSet<ErrorMovtoPlaza> ErrorMovtoPlaza { get; set; }
        public virtual DbSet<EscalaSalarial> EscalaSalarial { get; set; }
        public virtual DbSet<Escolaridad> Escolaridad { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<EstadoSalud> EstadoSalud { get; set; }
        public virtual DbSet<EstatusReloj> EstatusReloj { get; set; }
        public virtual DbSet<FechasIngreso> FechasIngreso { get; set; }
        public virtual DbSet<FechaVacaciones> FechaVacaciones { get; set; }
        public virtual DbSet<Firmas> Firmas { get; set; }
        public virtual DbSet<Folio> Folio { get; set; }
        public virtual DbSet<FolioCancelado> FolioCancelado { get; set; }
        public virtual DbSet<GrupoPuesto> GrupoPuesto { get; set; }
        public virtual DbSet<GuardiaPersonal> GuardiaPersonal { get; set; }
        public virtual DbSet<HI_Empleado> HI_Empleado { get; set; }
        public virtual DbSet<HistoricoMovimientoPersonal> HistoricoMovimientoPersonal { get; set; }
        public virtual DbSet<HistoricoMovimientoPersonal_FormaPago> HistoricoMovimientoPersonal_FormaPago { get; set; }
        public virtual DbSet<HistoricoMovimientoPersonal_OpcionJubilacion> HistoricoMovimientoPersonal_OpcionJubilacion { get; set; }
        public virtual DbSet<HistoricoMovimientoPersonal_SeccionSindical> HistoricoMovimientoPersonal_SeccionSindical { get; set; }
        public virtual DbSet<HistoricoMovimientoPersonal2> HistoricoMovimientoPersonal2 { get; set; }
        public virtual DbSet<HojaUnicaServicio> HojaUnicaServicio { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Incidencia> Incidencia { get; set; }
        public virtual DbSet<Kardex> Kardex { get; set; }
        public virtual DbSet<KardexPlaza> KardexPlaza { get; set; }
        public virtual DbSet<Licencia> Licencia { get; set; }
        public virtual DbSet<Mando> Mando { get; set; }
        public virtual DbSet<MandoTipoNomina> MandoTipoNomina { get; set; }
        public virtual DbSet<MotivoLicencia> MotivoLicencia { get; set; }
        public virtual DbSet<MotivoMovto> MotivoMovto { get; set; }
        public virtual DbSet<Movimiento> Movimiento { get; set; }
        public virtual DbSet<MovimientoPlaza> MovimientoPlaza { get; set; }
        public virtual DbSet<MovPreparado> MovPreparado { get; set; }
        public virtual DbSet<Nacionalidad> Nacionalidad { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Nombramiento> Nombramiento { get; set; }
        public virtual DbSet<OpcionJubilacion> OpcionJubilacion { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<OrigenPlaza> OrigenPlaza { get; set; }
        public virtual DbSet<Padecimientos> Padecimientos { get; set; }
        public virtual DbSet<ParametrizacionPersona> ParametrizacionPersona { get; set; }
        public virtual DbSet<ParametrizacionPlaza> ParametrizacionPlaza { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<PeriodoLicencia> PeriodoLicencia { get; set; }
        public virtual DbSet<PeriodoVacaciones> PeriodoVacaciones { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonaConstanciasISSSTE> PersonaConstanciasISSSTE { get; set; }
        public virtual DbSet<PersonaControlLicencia> PersonaControlLicencia { get; set; }
        public virtual DbSet<PersonaDosHoras> PersonaDosHoras { get; set; }
        public virtual DbSet<PersonaEscolaridad> PersonaEscolaridad { get; set; }
        public virtual DbSet<PersonaFirma> PersonaFirma { get; set; }
        public virtual DbSet<PersonaMasiva> PersonaMasiva { get; set; }
        public virtual DbSet<PersonaOnomastico> PersonaOnomastico { get; set; }
        public virtual DbSet<PersonaPadecimiento> PersonaPadecimiento { get; set; }
        public virtual DbSet<PersonaPlaza> PersonaPlaza { get; set; }
        public virtual DbSet<PersonaResponsableArea> PersonaResponsableArea { get; set; }
        public virtual DbSet<PlantillaPlaza> PlantillaPlaza { get; set; }
        public virtual DbSet<Plaza> Plaza { get; set; }
        public virtual DbSet<PlazaAutorizada> PlazaAutorizada { get; set; }
        public virtual DbSet<PlazaEstatus> PlazaEstatus { get; set; }
        public virtual DbSet<PrimaVacacional> PrimaVacacional { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<PuestoCredencial> PuestoCredencial { get; set; }
        public virtual DbSet<PuestoNombramiento> PuestoNombramiento { get; set; }
        public virtual DbSet<PuestoRetabular> PuestoRetabular { get; set; }
        public virtual DbSet<PuestoSecodam> PuestoSecodam { get; set; }
        public virtual DbSet<PuestoValido> PuestoValido { get; set; }
        public virtual DbSet<QN_Empleado> QN_Empleado { get; set; }
        public virtual DbSet<RadicacionPago> RadicacionPago { get; set; }
        public virtual DbSet<Rama> Rama { get; set; }
        public virtual DbSet<Reloj> Reloj { get; set; }
        public virtual DbSet<SituacionMovimiento> SituacionMovimiento { get; set; }
        public virtual DbSet<SituacionPersona> SituacionPersona { get; set; }
        public virtual DbSet<SituacionPlaza> SituacionPlaza { get; set; }
        public virtual DbSet<TallaVestimenta> TallaVestimenta { get; set; }
        public virtual DbSet<TipoCarrera> TipoCarrera { get; set; }
        public virtual DbSet<TipoDescanso> TipoDescanso { get; set; }
        public virtual DbSet<TipoDetalleHorario> TipoDetalleHorario { get; set; }
        public virtual DbSet<TipoDictamenISSSTE> TipoDictamenISSSTE { get; set; }
        public virtual DbSet<TipoDireccion> TipoDireccion { get; set; }
        public virtual DbSet<TipoIncidencia> TipoIncidencia { get; set; }
        public virtual DbSet<TipoPersonal> TipoPersonal { get; set; }
        public virtual DbSet<TipoPlaza> TipoPlaza { get; set; }
        public virtual DbSet<TipoPuesto> TipoPuesto { get; set; }
        public virtual DbSet<TipoVacaciones> TipoVacaciones { get; set; }
        public virtual DbSet<TopeVacaciones> TopeVacaciones { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AANU_UnidadResp>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<AANU_UnidadResp>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AANU_UnidadResp>()
                .HasMany(e => e.AANU_CentroTrabajo)
                .WithRequired(e => e.AANU_UnidadResp)
                .HasForeignKey(e => e.FK_IdUnidadResp__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaseMovto>()
                .HasMany(e => e.MotivoMovto)
                .WithRequired(e => e.ClaseMovto)
                .HasForeignKey(e => e.FK_IdClaseMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaseMovto>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.ClaseMovto)
                .HasForeignKey(e => e.FK_IdClaseMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaseMovto>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.ClaseMovto)
                .HasForeignKey(e => e.FK_IdClaseMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaseMovto>()
                .HasMany(e => e.PersonaMasiva)
                .WithRequired(e => e.ClaseMovto)
                .HasForeignKey(e => e.IdClaseMovto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasePuesto>()
                .HasMany(e => e.PuestoValido)
                .WithRequired(e => e.ClasePuesto)
                .HasForeignKey(e => e.FK_IdClasePuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasePuesto>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.ClasePuesto)
                .HasForeignKey(e => e.FK_IdClasePuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasePuesto>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.ClasePuesto)
                .HasForeignKey(e => e.FK_IdClasePuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasePuesto>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.ClasePuesto)
                .HasForeignKey(e => e.FK_IdClasePuesto__RHCT);

            modelBuilder.Entity<ClasificadorIngreso>()
                .HasMany(e => e.Antiguedad)
                .WithRequired(e => e.ClasificadorIngreso)
                .HasForeignKey(e => e.FK_IdClasificadorIngreso__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasificadorIngreso>()
                .HasMany(e => e.EmpleadoFechaIngreso)
                .WithRequired(e => e.ClasificadorIngreso)
                .HasForeignKey(e => e.FK_IdClasificadorIngreso__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasificadorIngreso>()
                .HasMany(e => e.FechasIngreso)
                .WithRequired(e => e.ClasificadorIngreso)
                .HasForeignKey(e => e.FK_IdClasificadorIngreso__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comedor>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.Comedor)
                .HasForeignKey(e => e.FK_IdComedor__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comedor>()
                .HasMany(e => e.PersonaPlaza)
                .WithOptional(e => e.Comedor)
                .HasForeignKey(e => e.FK_IdComedor__RHCT);

            modelBuilder.Entity<ComprobanteEstudios>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.ComprobanteEstudios)
                .HasForeignKey(e => e.FK_IdComprobanteEstudios__RHCT);

            modelBuilder.Entity<Credencial>()
                .HasMany(e => e.PuestoCredencial)
                .WithRequired(e => e.Credencial)
                .HasForeignKey(e => e.FK_IdCredencial__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CuentaPersonaBanamex>()
                .Property(e => e.Sucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaPersonaBanamex>()
                .Property(e => e.CuentaCheques)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaPersonaBanamex>()
                .Property(e => e.FormaPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatosMovto>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DatosMovto>()
                .Property(e => e.Importe)
                .HasPrecision(14, 2);

            modelBuilder.Entity<DatosTransferencia>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Dependencia>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.Dependencia)
                .HasForeignKey(e => e.FK_IdDependencia__RHCT);

            modelBuilder.Entity<Dependiente>()
                .Property(e => e.Porcentaje)
                .HasPrecision(6, 2);

            modelBuilder.Entity<DetCreaPlaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DetMovPlaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<DiasEconomicos>()
                .HasMany(e => e.EmpleadoDiasEconomicos)
                .WithRequired(e => e.DiasEconomicos)
                .HasForeignKey(e => e.FK_IdDiasEconomicos__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiasReservados>()
                .Property(e => e.Dias)
                .HasPrecision(14, 2);

            modelBuilder.Entity<DiasReservados>()
                .Property(e => e.DiasDisfrutados)
                .HasPrecision(14, 2);

            modelBuilder.Entity<DiasReservados>()
                .HasMany(e => e.PeriodoVacaciones)
                .WithRequired(e => e.DiasReservados)
                .HasForeignKey(e => e.FK_IdDiasReservados__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiasReservadosVacaciones>()
                .HasOptional(e => e.DiasReservadosVacaciones1)
                .WithRequired(e => e.DiasReservadosVacaciones2);

            modelBuilder.Entity<DictamenISSSTE>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorMovto>()
                .HasMany(e => e.ErrorMovtoPlaza)
                .WithRequired(e => e.ErrorMovto)
                .HasForeignKey(e => e.FK_IdErrorMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ErrorMovtoPlaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<EscalaSalarial>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.EscalaSalarial)
                .HasForeignKey(e => e.FK_IdEscalaSalarial__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EscalaSalarial>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.EscalaSalarial)
                .HasForeignKey(e => e.FK_IdEscalaSalarial__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EscalaSalarial>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.EscalaSalarial)
                .HasForeignKey(e => e.FK_IdEscalaSalarial__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EscalaSalarial>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.EscalaSalarial)
                .HasForeignKey(e => e.FK_IdEscalaSalarial__RHCT);

            modelBuilder.Entity<EscalaSalarial>()
                .HasMany(e => e.PersonaMasiva)
                .WithRequired(e => e.EscalaSalarial)
                .HasForeignKey(e => e.FK_IdEscalaSalarial__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EscalaSalarial>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.EscalaSalarial)
                .HasForeignKey(e => e.FK_IdEscalaSalarial__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Escolaridad>()
                .HasMany(e => e.Dependiente)
                .WithOptional(e => e.Escolaridad)
                .HasForeignKey(e => e.FK_IdEscolaridad__RHCT);

            modelBuilder.Entity<Escolaridad>()
                .HasMany(e => e.PersonaEscolaridad)
                .WithRequired(e => e.Escolaridad)
                .HasForeignKey(e => e.FK_IdEscolaridad__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Escolaridad>()
                .HasMany(e => e.Persona)
                .WithRequired(e => e.Escolaridad)
                .HasForeignKey(e => e.FK_IdEscolaridad__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoCivil>()
                .HasMany(e => e.Persona)
                .WithRequired(e => e.EstadoCivil)
                .HasForeignKey(e => e.FK_IdEstadoCivil__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoSalud>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.EstadoSalud)
                .HasForeignKey(e => e.FK_IdEstadoSalud__RHCT);

            modelBuilder.Entity<Firmas>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Folio>()
                .HasMany(e => e.FolioCancelado)
                .WithRequired(e => e.Folio)
                .HasForeignKey(e => e.FK_IdFolio__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FolioCancelado>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<GrupoPuesto>()
                .HasMany(e => e.Rama)
                .WithRequired(e => e.GrupoPuesto)
                .HasForeignKey(e => e.FK_IdGrupoPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GrupoPuesto>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.GrupoPuesto)
                .HasForeignKey(e => e.FK_IdGrupoPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GrupoPuesto>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.GrupoPuesto)
                .HasForeignKey(e => e.FK_IdGrupoPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HI_Empleado>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<HojaUnicaServicio>()
                .Property(e => e.Sueldo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HojaUnicaServicio>()
                .Property(e => e.SobreSueldo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HojaUnicaServicio>()
                .Property(e => e.Compensacion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HojaUnicaServicio>()
                .Property(e => e.Quinquenio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HojaUnicaServicio>()
                .Property(e => e.Otros)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.Horario)
                .HasForeignKey(e => e.FK_IdHorario__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.DetalleHorario)
                .WithOptional(e => e.Horario)
                .HasForeignKey(e => e.FK_IdHorario__RHCT);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.Horario)
                .HasForeignKey(e => e.FK_IdHorario__RHCT);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.PersonaConstanciasISSSTE)
                .WithRequired(e => e.Horario)
                .HasForeignKey(e => e.FK_IdHorario__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.PersonaDosHoras)
                .WithRequired(e => e.Horario)
                .HasForeignKey(e => e.FK_IdHorario__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.Horario)
                .HasForeignKey(e => e.FK_IdHorario__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Sueldo)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.SobreSueldo)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Compensacion)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Quinquenio)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Otras)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.MotivoSeparacionAnt)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .HasMany(e => e.PersonaPlaza)
                .WithOptional(e => e.Kardex)
                .HasForeignKey(e => e.FK_IdKardex__RHCT);

            modelBuilder.Entity<KardexPlaza>()
                .HasMany(e => e.PlazaAutorizada1)
                .WithOptional(e => e.KardexPlaza1)
                .HasForeignKey(e => e.FK_IdKardexPlaza__RHCT);

            modelBuilder.Entity<Mando>()
                .HasMany(e => e.DiasDescanso)
                .WithOptional(e => e.Mando)
                .HasForeignKey(e => e.FK_IdMando__RHCT);

            modelBuilder.Entity<Mando>()
                .HasMany(e => e.MandoTipoNomina)
                .WithRequired(e => e.Mando)
                .HasForeignKey(e => e.FK_IdMando__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mando>()
                .HasMany(e => e.Puesto)
                .WithOptional(e => e.Mando1)
                .HasForeignKey(e => e.Mando);

            modelBuilder.Entity<MotivoLicencia>()
                .HasMany(e => e.EmpleadoSeguimientoLicencia)
                .WithRequired(e => e.MotivoLicencia)
                .HasForeignKey(e => e.FK_IdMotivoLicencia__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.ErrorMovto)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.HojaUnicaServicio)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.Licencia)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.IdMotivoMovto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.ParametrizacionPersona)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.ParametrizacionPlaza)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.PlazaEstatus)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.MovimientoPlaza)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.MovPreparado)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.OrigenPlaza)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoMovto>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.MotivoMovto)
                .HasForeignKey(e => e.FK_IdMotivoMovto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimiento>()
                .HasMany(e => e.ConsecutivoMovimientoPersonal)
                .WithRequired(e => e.Movimiento)
                .HasForeignKey(e => e.FK_IdMovimiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimiento>()
                .HasMany(e => e.HistoricoMovimientoPersonal2)
                .WithRequired(e => e.Movimiento)
                .HasForeignKey(e => e.FK_IdMovimiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimiento>()
                .HasMany(e => e.MotivoMovto)
                .WithRequired(e => e.Movimiento)
                .HasForeignKey(e => e.FK_IdMovimiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovimientoPlaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<MovimientoPlaza>()
                .Property(e => e.Horas_Nvo)
                .HasPrecision(5, 2);

            modelBuilder.Entity<MovimientoPlaza>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientoPlaza>()
                .HasMany(e => e.ErrorMovtoPlaza)
                .WithRequired(e => e.MovimientoPlaza)
                .HasForeignKey(e => e.FK_IdMovimientoPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovPreparado>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Nacionalidad>()
                .HasMany(e => e.Persona)
                .WithRequired(e => e.Nacionalidad)
                .HasForeignKey(e => e.FK_IdNacionalidad__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Puesto)
                .WithOptional(e => e.Nivel1)
                .HasForeignKey(e => e.FK_IdNivel__RHCT);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.DiasDescanso)
                .WithOptional(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.HistoricoMovimientoPersonal)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.HistoricoMovimientoPersonal2)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.PersonaConstanciasISSSTE)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.PersonaDosHoras)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nombramiento>()
                .HasMany(e => e.PuestoNombramiento)
                .WithRequired(e => e.Nombramiento)
                .HasForeignKey(e => e.FK_IdNombramiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpcionJubilacion>()
                .HasMany(e => e.HistoricoMovimientoPersonal_OpcionJubilacion)
                .WithRequired(e => e.OpcionJubilacion)
                .HasForeignKey(e => e.FK_IdOpcionJubilacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpcionJubilacion>()
                .HasMany(e => e.HistoricoMovimientoPersonal_OpcionJubilacion1)
                .WithOptional(e => e.OpcionJubilacion1)
                .HasForeignKey(e => e.Fk_IdOpcionJubilacion_Ant);

            modelBuilder.Entity<OpcionJubilacion>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.OpcionJubilacion)
                .HasForeignKey(e => e.FK_IdOpcionJubilacion);

            modelBuilder.Entity<Padecimientos>()
                .HasMany(e => e.PersonaPadecimiento)
                .WithRequired(e => e.Padecimientos)
                .HasForeignKey(e => e.FK_IdPadecimiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parentesco>()
                .HasMany(e => e.Dependiente)
                .WithRequired(e => e.Parentesco)
                .HasForeignKey(e => e.FK_IdParentesco__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PeriodoVacaciones>()
                .Property(e => e.Dias)
                .HasPrecision(14, 2);

            modelBuilder.Entity<PeriodoVacaciones>()
                .Property(e => e.DiasDisfrutados)
                .HasPrecision(14, 2);

            modelBuilder.Entity<PeriodoVacaciones>()
                .HasMany(e => e.DiasReservadosVacaciones)
                .WithRequired(e => e.PeriodoVacaciones)
                .HasForeignKey(e => e.IdPeriodoVacaciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Antiguedad)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.BasificadoOE)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.ConsultaPlaza)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.CuentaPersona)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.CuentaPersonaBanamex)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DatosCedulaRegistro)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DatosTransferencia)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Dependiente)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DiasDerecho)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DiasLaborados)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DiasRealesVacaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DiasReservados)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.DiasReservadosVacaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Direccion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoBasificacion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoDiasEconomicos)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoFechaIngreso)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoFechaVacaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoFechaVacacionesSemes)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoSeguimientoLicencia)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.EmpleadoTarjetaObservaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FechasIngreso)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FechaVacaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.GuardiaPersonal)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HistoricoMovimientoPersonal)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HistoricoMovimientoPersonal_FormaPago)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HistoricoMovimientoPersonal_OpcionJubilacion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HistoricoMovimientoPersonal_SeccionSindical)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HistoricoMovimientoPersonal2)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.HojaUnicaServicio)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Incidencia)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Kardex)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Licencia)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.MovPreparado)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PeriodoVacaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaEscolaridad)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaResponsableArea)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaConstanciasISSSTE)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaControlLicencia)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaDosHoras)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaFirma)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaMasiva)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaOnomastico)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaPadecimiento)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaPlaza)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PrimaVacacional)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Vacaciones)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.FK_IdPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonaConstanciasISSSTE>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PersonaConstanciasISSSTE>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<PersonaDosHoras>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PersonaDosHoras>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<PersonaPlaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PlantillaPlaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Plaza>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Plaza>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.ConsultaPlaza)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.DetMovPlaza)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.EmpleadoBasificacion)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.Licencia)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.OrigenPlaza)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.PersonaConstanciasISSSTE)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.PersonaDosHoras)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plaza>()
                .HasMany(e => e.PersonaMasiva)
                .WithRequired(e => e.Plaza)
                .HasForeignKey(e => e.FK_IdPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PlazaAutorizada>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.KardexPlaza)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.MovPreparado)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.PlantillaPlaza)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.Plaza1)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.PlazaEstatus)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaAutorizada>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.PlazaAutorizada)
                .HasForeignKey(e => e.FK_IdPlazaAutorizada__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlazaEstatus>()
                .HasMany(e => e.ConsultaPlaza)
                .WithRequired(e => e.PlazaEstatus)
                .HasForeignKey(e => e.FK_IdPlazaEstatus__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrimaVacacional>()
                .Property(e => e.Importe)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Puesto>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.ComparativoPlaza)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.DatosMovto)
                .WithOptional(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.DatosTransferencia)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto_RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HistoricoMovimientoPersonal)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HistoricoMovimientoPersonal_FormaPago)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HistoricoMovimientoPersonal_OpcionJubilacion)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HistoricoMovimientoPersonal_SeccionSindical)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HistoricoMovimientoPersonal2)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.HojaUnicaServicio)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.KardexPlaza)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.MovimientoPlaza)
                .WithOptional(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.PlantillaPlaza)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.Plaza)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.PlazaAutorizada)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.PuestoCredencial)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.PuestoNombramiento)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.PuestoRetabular)
                .WithRequired(e => e.Puesto)
                .HasForeignKey(e => e.FK_IdPuesto__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.PuestoRetabular1)
                .WithRequired(e => e.Puesto1)
                .HasForeignKey(e => e.IdPuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PuestoValido>()
                .HasMany(e => e.PersonaPlaza)
                .WithOptional(e => e.PuestoValido)
                .HasForeignKey(e => e.FK_IdPuestoValido__RHCT);

            modelBuilder.Entity<QN_Empleado>()
                .Property(e => e.Horas)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RadicacionPago>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.RadicacionPago)
                .HasForeignKey(e => e.FK_IdRadicacionPago__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RadicacionPago>()
                .HasMany(e => e.DiasDescanso)
                .WithOptional(e => e.RadicacionPago)
                .HasForeignKey(e => e.FK_IdRadicacionPago__RHCT);

            modelBuilder.Entity<RadicacionPago>()
                .HasMany(e => e.HistoricoMovimientoPersonal_SeccionSindical)
                .WithRequired(e => e.RadicacionPago)
                .HasForeignKey(e => e.FK_IdRadicacionPago__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RadicacionPago>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.RadicacionPago)
                .HasForeignKey(e => e.FK_IdRadicacionPago__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rama>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.Rama)
                .HasForeignKey(e => e.FK_IdRama__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rama>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.Rama)
                .HasForeignKey(e => e.FK_IdRama__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionMovimiento>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.SituacionMovimiento)
                .HasForeignKey(e => e.FK_IdSituacionMovimiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionMovimiento>()
                .HasMany(e => e.DetMovPlaza)
                .WithRequired(e => e.SituacionMovimiento)
                .HasForeignKey(e => e.IdSituacionMovimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionMovimiento>()
                .HasMany(e => e.MovimientoPlaza)
                .WithRequired(e => e.SituacionMovimiento)
                .HasForeignKey(e => e.FK_IdSituacionMovimiento__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.HI_Empleado)
                .WithRequired(e => e.SituacionPersona)
                .HasForeignKey(e => e.FK_SituacionPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.SituacionPersona)
                .HasForeignKey(e => e.FK_IdSituacionPersona__RHCT);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.ParametrizacionPersona)
                .WithRequired(e => e.SituacionPersona)
                .HasForeignKey(e => e.FK_IdSituacionPersonaLee__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.ParametrizacionPersona1)
                .WithRequired(e => e.SituacionPersona1)
                .HasForeignKey(e => e.FK_IdSituacionPersonaGraba__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.ParametrizacionPersona2)
                .WithRequired(e => e.SituacionPersona2)
                .HasForeignKey(e => e.FK_IdSituacionPersonaCierra__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.PersonaMasiva)
                .WithRequired(e => e.SituacionPersona)
                .HasForeignKey(e => e.IdSituacionPersona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.SituacionPersona)
                .HasForeignKey(e => e.FK_IdSituacionPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPersona>()
                .HasMany(e => e.QN_Empleado)
                .WithRequired(e => e.SituacionPersona)
                .HasForeignKey(e => e.FK_SituacionPersona__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.KardexPlaza)
                .WithRequired(e => e.SituacionPlaza)
                .HasForeignKey(e => e.FK_IdSituacionPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.ParametrizacionPlaza)
                .WithRequired(e => e.SituacionPlaza)
                .HasForeignKey(e => e.FK_IdSituacionPlazaLee__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.ParametrizacionPlaza1)
                .WithRequired(e => e.SituacionPlaza1)
                .HasForeignKey(e => e.FK_IdSituacionPlazaGraba__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.ParametrizacionPlaza2)
                .WithRequired(e => e.SituacionPlaza2)
                .HasForeignKey(e => e.FK_IdSituacionPlazaCierra__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.ParametrizacionPlaza3)
                .WithRequired(e => e.SituacionPlaza3)
                .HasForeignKey(e => e.FK_IdSituacionPlazaGrabaA__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.PlazaAutorizada)
                .WithOptional(e => e.SituacionPlaza)
                .HasForeignKey(e => e.FK_IdSituacionPlaza__RHCT);

            modelBuilder.Entity<SituacionPlaza>()
                .HasMany(e => e.PlazaEstatus)
                .WithRequired(e => e.SituacionPlaza)
                .HasForeignKey(e => e.FK_IdSituacionPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TallaVestimenta>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.TallaVestimenta)
                .HasForeignKey(e => e.FK_IdTallaVestimenta__RHCT);

            modelBuilder.Entity<TipoDescanso>()
                .HasMany(e => e.DiasDescanso)
                .WithRequired(e => e.TipoDescanso)
                .HasForeignKey(e => e.FK_IdTipoDescanso__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDireccion>()
                .HasMany(e => e.Direccion)
                .WithRequired(e => e.TipoDireccion)
                .HasForeignKey(e => e.FK_IdTipoDireccion__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoIncidencia>()
                .HasMany(e => e.Incidencia)
                .WithRequired(e => e.TipoIncidencia)
                .HasForeignKey(e => e.FK_IdTipoIncidencia__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPersonal>()
                .HasMany(e => e.Persona)
                .WithRequired(e => e.TipoPersonal)
                .HasForeignKey(e => e.FK_IdTipoPersonal__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPlaza>()
                .HasMany(e => e.DetMovPlaza)
                .WithRequired(e => e.TipoPlaza)
                .HasForeignKey(e => e.FK_IdTipoPlaza__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPlaza>()
                .HasMany(e => e.PlantillaPlaza)
                .WithOptional(e => e.TipoPlaza)
                .HasForeignKey(e => e.FK_IdTipoPlaza__RHCT);

            modelBuilder.Entity<TipoVacaciones>()
                .HasMany(e => e.DiasReservados)
                .WithRequired(e => e.TipoVacaciones)
                .HasForeignKey(e => e.FK_IdTipoVacaciones__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoVacaciones>()
                .HasMany(e => e.PeriodoVacaciones)
                .WithRequired(e => e.TipoVacaciones)
                .HasForeignKey(e => e.FK_IdTipoVacaciones__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoVacaciones>()
                .HasMany(e => e.Vacaciones)
                .WithRequired(e => e.TipoVacaciones)
                .HasForeignKey(e => e.FK_IdTipoVacaciones__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.DatosMovto)
                .WithRequired(e => e.Turno)
                .HasForeignKey(e => e.FK_IdTurno__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.Kardex)
                .WithOptional(e => e.Turno)
                .HasForeignKey(e => e.FK_IdTurno__RHCT);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.PersonaConstanciasISSSTE)
                .WithRequired(e => e.Turno)
                .HasForeignKey(e => e.FK_IdTurno__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.PersonaDosHoras)
                .WithRequired(e => e.Turno)
                .HasForeignKey(e => e.FK_IdTurno__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.PersonaPlaza)
                .WithRequired(e => e.Turno)
                .HasForeignKey(e => e.FK_IdTurno__RHCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Dias)
                .HasPrecision(3, 0);
        }
    }
}
