IF OBJECT_ID('moustache_spice.inhabilitarRol', 'TR') IS NOT NULL
	DROP TRIGGER moustache_spice.inhabilitarRol
IF OBJECT_ID('moustache_spice.cambiarPlanMedico', 'TR') IS NOT NULL
	DROP TRIGGER moustache_spice.cambiarPlanMedico
IF OBJECT_ID('moustache_spice.loginFallido ', 'TR') IS NOT NULL
	DROP TRIGGER moustache_spice.loginFallido 

IF OBJECT_ID('moustache_spice.medicamento_x_bonoFarmacia', 'U') IS NOT NULL
	DROP TABLE moustache_spice.medicamento_x_bonoFarmacia
IF OBJECT_ID('moustache_spice.medicamento', 'U') IS NOT NULL
	DROP TABLE moustache_spice.medicamento
IF OBJECT_ID('moustache_spice.turnoAudit', 'U') IS NOT NULL
	DROP TABLE moustache_spice.turnoAudit
IF OBJECT_ID('moustache_spice.turno', 'U') IS NOT NULL
	DROP TABLE moustache_spice.turno
IF OBJECT_ID('moustache_spice.bonoConsulta', 'U') IS NOT NULL
	DROP TABLE moustache_spice.bonoConsulta
IF OBJECT_ID('moustache_spice.bonoFarmacia', 'U') IS NOT NULL
	DROP TABLE moustache_spice.bonoFarmacia
IF OBJECT_ID('moustache_spice.planMedicoAudit', 'U') IS NOT NULL
	DROP TABLE moustache_spice.planMedicoAudit
IF OBJECT_ID('moustache_spice.afiliadoAudit', 'U') IS NOT NULL
	DROP TABLE moustache_spice.afiliadoAudit
IF OBJECT_ID('moustache_spice.afiliado', 'U') IS NOT NULL
	DROP TABLE moustache_spice.afiliado
IF OBJECT_ID('moustache_spice.grupoFamiliarAudit', 'U') IS NOT NULL
	DROP TABLE moustache_spice.grupoFamiliarAudit
IF OBJECT_ID('moustache_spice.grupoFamiliar', 'U') IS NOT NULL
	DROP TABLE moustache_spice.grupoFamiliar
IF OBJECT_ID('moustache_spice.estadoCivil', 'U') IS NOT NULL
	DROP TABLE moustache_spice.estadoCivil
IF OBJECT_ID('moustache_spice.profesional_x_especialidad', 'U') IS NOT NULL
	DROP TABLE moustache_spice.profesional_x_especialidad
IF OBJECT_ID('moustache_spice.semanal', 'U') IS NOT NULL
	DROP TABLE moustache_spice.semanal
IF OBJECT_ID('moustache_spice.agenda', 'U') IS NOT NULL
	DROP TABLE moustache_spice.agenda
IF OBJECT_ID('moustache_spice.profesional', 'U') IS NOT NULL
	DROP TABLE moustache_spice.profesional
IF OBJECT_ID('moustache_spice.especialidad', 'U') IS NOT NULL
	DROP TABLE moustache_spice.especialidad
IF OBJECT_ID('moustache_spice.tipoEspecialidad', 'U') IS NOT NULL
	DROP TABLE moustache_spice.tipoEspecialidad
IF OBJECT_ID('moustache_spice.planMedico', 'U') IS NOT NULL
	DROP TABLE moustache_spice.planMedico
IF OBJECT_ID('moustache_spice.rol_x_funcionalidad', 'U') IS NOT NULL
	DROP TABLE moustache_spice.rol_x_funcionalidad
IF OBJECT_ID('moustache_spice.funcionalidad', 'U') IS NOT NULL
	DROP TABLE moustache_spice.funcionalidad
IF OBJECT_ID('moustache_spice.rol_x_usuario', 'U') IS NOT NULL
	DROP TABLE moustache_spice.rol_x_usuario
IF OBJECT_ID('moustache_spice.rol', 'U') IS NOT NULL
	DROP TABLE moustache_spice.rol
IF OBJECT_ID('moustache_spice.usuario', 'U') IS NOT NULL
	DROP TABLE moustache_spice.usuario

IF OBJECT_ID('moustache_spice.cargaHoraria') IS NOT NULL
	DROP FUNCTION moustache_spice.cargaHoraria
IF OBJECT_ID('moustache_spice.cantidadMedicamentos') IS NOT NULL
	DROP FUNCTION moustache_spice.cantidadMedicamentos
IF OBJECT_ID('moustache_spice.concatenarFuncionalidad') IS NOT NULL
	DROP FUNCTION moustache_spice.concatenarFuncionalidad
IF OBJECT_ID('moustache_spice.concatenarEspecialidades') IS NOT NULL
	DROP FUNCTION moustache_spice.concatenarEspecialidades
IF OBJECT_ID('moustache_spice.semanalHabilitado') IS NOT NULL
	DROP FUNCTION moustache_spice.semanalHabilitado
IF OBJECT_ID('moustache_spice.bonoFarmaciaHabilitado') IS NOT NULL
	DROP FUNCTION moustache_spice.bonoFarmaciaHabilitado	

IF OBJECT_ID('moustache_spice.vProfesional', 'V') IS NOT NULL
	DROP VIEW moustache_spice.vProfesional
IF OBJECT_ID('moustache_spice.vAfiliado', 'V') IS NOT NULL
	DROP VIEW moustache_spice.vAfiliado
IF OBJECT_ID('moustache_spice.vAgenda', 'V') IS NOT NULL
	DROP VIEW moustache_spice.vAgenda

	DROP SCHEMA moustache_spice