IF OBJECT_ID('mustached_spice.inhabilitarRol', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.inhabilitarRol
IF OBJECT_ID('mustached_spice.modificarAfiliado', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.modificarAfiliado
IF OBJECT_ID('mustached_spice.loginFallido', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.loginFallido 
IF OBJECT_ID('mustached_spice.cancelarTurnos', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.cancelarTurnos 
IF OBJECT_ID('mustached_spice.consumirBono', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.consumirBono 	
IF OBJECT_ID('mustached_spice.retribuirBono', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.retribuirBono
IF OBJECT_ID('mustached_spice.bajarProfesional', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.bajarProfesional
IF OBJECT_ID('mustached_spice.checkearMedicamentos', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.checkearMedicamentos
IF OBJECT_ID('mustached_spice.agregarTurno', 'TR') IS NOT NULL
	DROP TRIGGER mustached_spice.agregarTurno

IF OBJECT_ID('mustached_spice.medicamento_x_bonoFarmacia', 'U') IS NOT NULL
	DROP TABLE mustached_spice.medicamento_x_bonoFarmacia
IF OBJECT_ID('mustached_spice.medicamento', 'U') IS NOT NULL
	DROP TABLE mustached_spice.medicamento
IF OBJECT_ID('mustached_spice.cancelacion', 'U') IS NOT NULL
	DROP TABLE mustached_spice.cancelacion
IF OBJECT_ID('mustached_spice.bonoFarmacia', 'U') IS NOT NULL
	DROP TABLE mustached_spice.bonoFarmacia
IF OBJECT_ID('mustached_spice.atencion', 'U') IS NOT NULL
	DROP TABLE mustached_spice.atencion
IF OBJECT_ID('mustached_spice.turno', 'U') IS NOT NULL
	DROP TABLE mustached_spice.turno
IF OBJECT_ID('mustached_spice.bonoConsulta', 'U') IS NOT NULL
	DROP TABLE mustached_spice.bonoConsulta
IF OBJECT_ID('mustached_spice.compra', 'U') IS NOT NULL
	DROP TABLE mustached_spice.compra
IF OBJECT_ID('mustached_spice.planMedicoAudit', 'U') IS NOT NULL
	DROP TABLE mustached_spice.planMedicoAudit
IF OBJECT_ID('mustached_spice.afiliadoAudit', 'U') IS NOT NULL
	DROP TABLE mustached_spice.afiliadoAudit
IF OBJECT_ID('mustached_spice.afiliado', 'U') IS NOT NULL
	DROP TABLE mustached_spice.afiliado
IF OBJECT_ID('mustached_spice.grupoFamiliar', 'U') IS NOT NULL
	DROP TABLE mustached_spice.grupoFamiliar
IF OBJECT_ID('mustached_spice.estadoCivil', 'U') IS NOT NULL
	DROP TABLE mustached_spice.estadoCivil
IF OBJECT_ID('mustached_spice.profesional_x_especialidad', 'U') IS NOT NULL
	DROP TABLE mustached_spice.profesional_x_especialidad
IF OBJECT_ID('mustached_spice.semanal', 'U') IS NOT NULL
	DROP TABLE mustached_spice.semanal
IF OBJECT_ID('mustached_spice.agenda', 'U') IS NOT NULL
	DROP TABLE mustached_spice.agenda
IF OBJECT_ID('mustached_spice.profesional', 'U') IS NOT NULL
	DROP TABLE mustached_spice.profesional
IF OBJECT_ID('mustached_spice.especialidad', 'U') IS NOT NULL
	DROP TABLE mustached_spice.especialidad
IF OBJECT_ID('mustached_spice.tipoEspecialidad', 'U') IS NOT NULL
	DROP TABLE mustached_spice.tipoEspecialidad
IF OBJECT_ID('mustached_spice.planMedico', 'U') IS NOT NULL
	DROP TABLE mustached_spice.planMedico
IF OBJECT_ID('mustached_spice.rol_x_funcionalidad', 'U') IS NOT NULL
	DROP TABLE mustached_spice.rol_x_funcionalidad
IF OBJECT_ID('mustached_spice.funcionalidad', 'U') IS NOT NULL
	DROP TABLE mustached_spice.funcionalidad
IF OBJECT_ID('mustached_spice.rol_x_usuario', 'U') IS NOT NULL
	DROP TABLE mustached_spice.rol_x_usuario
IF OBJECT_ID('mustached_spice.rol', 'U') IS NOT NULL
	DROP TABLE mustached_spice.rol
IF OBJECT_ID('mustached_spice.usuario', 'U') IS NOT NULL
	DROP TABLE mustached_spice.usuario


IF OBJECT_ID('mustached_spice.estEspecialidades') IS NOT NULL
	DROP FUNCTION mustached_spice.estEspecialidades
IF OBJECT_ID('mustached_spice.estVencidos') IS NOT NULL
	DROP FUNCTION mustached_spice.estVencidos
IF OBJECT_ID('mustached_spice.estRecetados') IS NOT NULL
	DROP FUNCTION mustached_spice.estRecetados
IF OBJECT_ID('mustached_spice.estNoEsTuyo') IS NOT NULL
	DROP FUNCTION mustached_spice.estNoEsTuyo
	
IF OBJECT_ID('mustached_spice.cargaHoraria') IS NOT NULL
	DROP FUNCTION mustached_spice.cargaHoraria
IF OBJECT_ID('mustached_spice.cantidadMedicamentos') IS NOT NULL
	DROP FUNCTION mustached_spice.cantidadMedicamentos
IF OBJECT_ID('mustached_spice.concatenarFuncionalidad') IS NOT NULL
	DROP FUNCTION mustached_spice.concatenarFuncionalidad
IF OBJECT_ID('mustached_spice.concatenarEspecialidades') IS NOT NULL
	DROP FUNCTION mustached_spice.concatenarEspecialidades
IF OBJECT_ID('mustached_spice.semanalHabilitado') IS NOT NULL
	DROP FUNCTION mustached_spice.semanalHabilitado
IF OBJECT_ID('mustached_spice.bonoFarmaciaHabilitado') IS NOT NULL
	DROP FUNCTION mustached_spice.bonoFarmaciaHabilitado	

IF OBJECT_ID('mustached_spice.vProfesional', 'V') IS NOT NULL
	DROP VIEW mustached_spice.vProfesional
IF OBJECT_ID('mustached_spice.vAfiliado', 'V') IS NOT NULL
	DROP VIEW mustached_spice.vAfiliado
IF OBJECT_ID('mustached_spice.vAgenda', 'V') IS NOT NULL
	DROP VIEW mustached_spice.vAgenda

	DROP SCHEMA mustached_spice
