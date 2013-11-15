CREATE SCHEMA moustache_spice AUTHORIZATION gd
GO

-- -----------------------------------------------------
-- CREATE funciones
-- -----------------------------------------------------

-- Concatenar las funcionalidades de un rol para mostrar en el DataGridView de ABM Roles
CREATE FUNCTION moustache_spice.concatenarFuncionalidad(@rolID int) RETURNS varchar(500) AS
BEGIN
  declare @resultado varchar(500)
	set @resultado= ''
	select @resultado = @resultado + fun_nombre + ', '
	FROM moustache_spice.funcionalidad
		JOIN moustache_spice.rol_x_funcionalidad ON rxf_funcionalidad = fun_id
	WHERE rxf_rol = @rolID
	RETURN @resultado
END
GO

-- Concatenar las especialidades de un profesional para mostrar en el DataGridView de ABM Profesionales
CREATE FUNCTION moustache_spice.concatenarEspecialidades(@proID int) RETURNS varchar(500) AS
BEGIN
  declare @resultado varchar(500)
	set @resultado= ''
	select @resultado = @resultado + esp_descripcion + ', '
	FROM moustache_spice.especialidad
		LEFT JOIN moustache_spice.profesional_x_especialidad ON pxe_especialidad = esp_id
	WHERE pxe_profesional = @proID AND pxe_habilitado=1
	RETURN @resultado
END
GO

-- Funcion para obtener la cantidad de medicamentos que se usa como check de que sea menor que 5
CREATE FUNCTION moustache_spice.cantidadMedicamentos(@bonoFarmacia int) RETURNS int AS
BEGIN
  RETURN (SELECT COUNT(*) FROM moustache_spice.medicamento_x_bonoFarmacia WHERE mxb_bonoFarmacia = @bonoFarmacia)
END
GO

-- Funcion para obtener la carga horaria que se usa como check de que un profesional no este disponible mas de 48 horas semanales
CREATE FUNCTION moustache_spice.cargaHoraria(@agenda int) RETURNS int AS
BEGIN
	-- 0.5 porque son cada 30 minutos (media hora) y quiero devolverlo en horas
  RETURN 0.5*(SELECT COUNT(1)
			FROM moustache_spice.semanal
			WHERE sem_agenda = @agenda AND sem_habilitado=1)
END
GO

-- Funcion que se usa en el check para validar los horarios de atencion de la clinica
CREATE FUNCTION moustache_spice.semanalHabilitado(@dia INT, @hora TIME) RETURNS int AS
BEGIN
	IF (((@dia  BETWEEN 2 AND 6 AND
		@hora BETWEEN '07:00:00' AND '19:30:00')
	OR
	   (@dia = 7 AND
		@hora BETWEEN '10:00:00' AND '15:00:00')))
		RETURN 1
	RETURN 0
END
GO

-- Funcion que se usa en el check de bonoFarmacias para deshabilitar los que esten mal
CREATE FUNCTION moustache_spice.bonoFarmaciaHabilitado(@impresion DATE, @vencimiento DATE) RETURNS int AS
BEGIN
	IF (@impresion <= @vencimiento AND DATEDIFF(DAY, @impresion , @vencimiento ) <= 60)
		RETURN 1
	RETURN 0
END
GO

-- -----------------------------------------------------
-- creacion tabla usuario
-- -----------------------------------------------------
CREATE TABLE moustache_spice.usuario (
  usu_id INT NOT NULL Identity,
  usu_nombre VARCHAR(45) NULL,
  usu_apellido VARCHAR(45) NULL,
  usu_tipoDocumento char(3) NULL,-- 'DNI/LE/LC' *FALTA*
  usu_numeroDocumento NUMERIC(18, 0) NULL,
  usu_direccion VARCHAR(100) NULL,
  usu_telefono NUMERIC(18, 0) NULL,
  usu_mail VARCHAR(45) NULL,
  usu_fechaNacimiento DATE NULL,
  usu_sexo char(1) NULL,-- 'M/F' *FALTA*
  usu_nombreUsuario VARCHAR(45) UNIQUE,
  usu_contrasegna VARCHAR(100), -- SHA256
  usu_intentosFallidos INT NOT NULL DEFAULT 0,
  usu_habilitado TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (usu_id)
);

--Trigger para deshabilitar los logins con mas de 3 intentos fallidos
GO
CREATE TRIGGER moustache_spice.loginFallido ON moustache_spice.usuario AFTER UPDATE AS
BEGIN
	UPDATE moustache_spice.usuario SET usu_habilitado=0 WHERE usu_intentosFallidos>=3
END
GO

-- -----------------------------------------------------
-- creacion tabla rol
-- -----------------------------------------------------
CREATE TABLE moustache_spice.rol (
  rol_id INT NOT NULL Identity,
  rol_nombre VARCHAR(45) NOT NULL,
  rol_habilitado TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (rol_id)
);

-- "Se le debe quitar el rol inhabilitado a todos aquellos usuarios que lo posean."
-- "Esto no implica recuperar las asignaciones que existían en un pasado"
GO
CREATE TRIGGER moustache_spice.inhabilitarRol ON moustache_spice.rol AFTER UPDATE AS
BEGIN
	DELETE FROM moustache_spice.rol_x_usuario WHERE EXISTS (SELECT rol_id FROM inserted WHERE rol_habilitado=0 AND rol_id = rxu_rol)
END
GO

-- -----------------------------------------------------
-- creacion tabla rol_x_usuario
-- Relacion NxN que no se puede hacer en un modelo relacional
-- -----------------------------------------------------
CREATE TABLE moustache_spice.rol_x_usuario (
  rxu_rol INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.rol(rol_id),
  rxu_usuario INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.usuario(usu_id),
  PRIMARY KEY(rxu_rol, rxu_usuario)
);

-- -----------------------------------------------------
-- creacion tabla funcionalidad
-- -----------------------------------------------------
CREATE TABLE moustache_spice.funcionalidad (
  fun_id INT NOT NULL Identity,
  fun_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (fun_id)
);

-- -----------------------------------------------------
-- creacion tabla rol_x_funcionalidad
-- Relacion NxN que no se puede hacer en un modelo relacional
-- -----------------------------------------------------
CREATE TABLE moustache_spice.rol_x_funcionalidad (
  rxf_rol INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.rol(rol_id),
  rxf_funcionalidad INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.funcionalidad(fun_id),
  PRIMARY KEY (rxf_rol, rxf_funcionalidad)
);

-- -----------------------------------------------------
-- creacion tabla planMedico
-- -----------------------------------------------------
CREATE TABLE moustache_spice.planMedico (
  pla_id INT NOT NULL Identity,
  pla_codigo NUMERIC(18,0),
  pla_nombre VARCHAR(45) NOT NULL,
  pla_precioBonoConsulta INT NOT NULL,
  pla_precioBonoFarmacia INT NOT NULL,
  PRIMARY KEY (pla_id)
);

-- -----------------------------------------------------
-- creacion tabla tipoEspecialidad
-- -----------------------------------------------------
CREATE TABLE moustache_spice.tipoEspecialidad (
  tip_id INT NOT NULL,
  tip_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (tip_id)
);

-- -----------------------------------------------------
-- creacion tabla especialidad
-- -----------------------------------------------------
CREATE TABLE moustache_spice.especialidad (
  esp_id INT NOT NULL,
  esp_descripcion VARCHAR(45) NOT NULL,
  esp_tipo INT NULL FOREIGN KEY REFERENCES  moustache_spice.tipoEspecialidad(tip_id),
  PRIMARY KEY (esp_id)
);

-- -----------------------------------------------------
-- creacion tabla profesional
-- EL nombre, apellido y informacion esta en la tabla de usuario
-- -----------------------------------------------------
CREATE TABLE moustache_spice.profesional (
  pro_id INT NOT NULL Identity,
  pro_matricula INT NULL, -- *FALTA*
  pro_usuario INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.usuario(usu_id),
  pro_habilitado TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (pro_id),
  -- UNIQUE(matricula)
);

--Trigger para que si se baja un profesional, borrar la agenda, y esto trigerea a borrar todos los turnos que tenga
GO
CREATE TRIGGER moustache_spice.bajarProfesional ON moustache_spice.profesional AFTER UPDATE AS
BEGIN
	DELETE moustache_spice.semanal WHERE sem_agenda IN (SELECT age_id FROM moustache_spice.agenda WHERE age_profesional IN (SELECT pro_id FROM inserted WHERE pro_habilitado=0))
END
GO

-- -----------------------------------------------------
-- creacion tabla agenda
-- Una agenda es un periodo de tiempo, dentro de la cual valen las entradas de la tabla mas abajo "Semanal"
-- -----------------------------------------------------
CREATE TABLE moustache_spice.agenda (
  age_id INT NOT NULL Identity,
  age_profesional INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.profesional(pro_id),
  age_desde DATE NOT NULL,
  age_hasta DATE NOT NULL,
  PRIMARY KEY(age_id),
  CHECK ( (age_desde < age_hasta) AND (DATEDIFF(day, age_desde, age_hasta) <= 120) )
);

-- -----------------------------------------------------
-- creacion tabla semanal
-- Dia de la semana y hora en la que atiende. Hay una entrada por cada turno de 30 minutos que esta disponible
-- -----------------------------------------------------
CREATE TABLE moustache_spice.semanal (
  sem_agenda INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.agenda(age_id),
  sem_dia INT NOT NULL, -- 1: DOMINGO
  sem_hora TIME NOT NULL, --Se separan cada 30 minutos
  sem_habilitado TINYINT NOT NULL DEFAULT 1
  PRIMARY KEY(sem_agenda, sem_dia, sem_hora)
);

-- -----------------------------------------------------
-- creacion tabla profesional_x_especialidad
-- Relacion NxN que no se puede hacer en un modelo relacional
-- -----------------------------------------------------
CREATE TABLE moustache_spice.profesional_x_especialidad (
  pxe_profesional INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.profesional(pro_id),
  pxe_especialidad INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.especialidad(esp_id),
  pxe_habilitado TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (pxe_profesional, pxe_especialidad)
);

-- -----------------------------------------------------
-- creacion tabla estadoCivil
-- -----------------------------------------------------
CREATE TABLE moustache_spice.estadoCivil(
  est_id INT NOT NULL Identity,
  est_estado CHAR(20) NOT NULL,
  PRIMARY KEY(est_id)
);

-- -----------------------------------------------------
-- creacion tabla afiliado
-- -----------------------------------------------------
CREATE TABLE moustache_spice.afiliado (
  afi_id INT NOT NULL Identity,
  afi_grupoFamiliar2 INT NULL FOREIGN KEY REFERENCES  moustache_spice.afiliado(afi_id), -- *si tiene NULL, la vista usa el de afi_id*
  afi_orden INT NULL, -- *FALTA*
  afi_usuario INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.usuario(usu_id),
  afi_estadoCivil INT FOREIGN KEY REFERENCES  moustache_spice.estadoCivil(est_id), -- *FALTA*
  afi_planMedico INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.planMedico(pla_id),
  afi_familiaresACargo INT NULL,
  afi_habilitado TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (afi_id),
  --UNIQUE (afi_grupoFamiliar, afi_orden) Deveria, pero al tener ordenes en NULL por la migracion, no se puede poner UNIQUE
);

-- -----------------------------------------------------
-- creacion tabla afiliadoAudit
-- -----------------------------------------------------
CREATE TABLE moustache_spice.afiliadoAudit (
  afA_afiliado INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.afiliado(afi_id),
  afA_fecha DATETIME NOT NULL,
);

--Trigger para cambiar los planes medicos de todos los afiliados que esten en el mismo grupo, y deshabilitar todos los turnos que este tenga
-- y
--Trigger para guardar la baja de afiliado y cancelar los turnos que tenga
GO
CREATE TRIGGER moustache_spice.modificarAfiliado ON moustache_spice.afiliado AFTER UPDATE AS
BEGIN
	INSERT INTO moustache_spice.afiliadoAudit(afA_fecha, afA_afiliado) (SELECT GETDATE(), afi_id FROM inserted WHERE afi_habilitado=0)
	INSERT INTO moustache_spice.turnoAudit(tuA_razon, tuA_tipo, tuA_turno) (SELECT 'Baja de Afiliado', 'Sistema', tur_id FROM moustache_spice.turno WHERE tur_afiliado IN (SELECT afi_id FROM inserted WHERE afi_habilitado=0))
	UPDATE moustache_spice.turno SET tur_habilitado=0 WHERE tur_afiliado IN (SELECT afi_id FROM inserted WHERE afi_habilitado=0)


	UPDATE moustache_spice.afiliado
		SET afi_planMedico=(select TOP 1 afi_planMedico from inserted)
	WHERE afi_grupoFamiliar2 IN (SELECT afi_id FROM inserted)
	
	
	--"Recordar que los bonos solo pueden ser utilizados para el plan que tenía asignado el 
	--afiliado en el momento que realizó la compra, es decir, que si luego cambia de plan, sea 
	--por uno más alto o uno más bajo, dichos bonos no podrán ser utilizado por él"
	UPDATE moustache_spice.bonoConsulta
		SET bco_habilitado=0
	WHERE bco_comprador IN (SELECT afi_id FROM inserted)
	
	UPDATE moustache_spice.bonoFarmacia
		SET bfa_habilitado=0
	WHERE bfa_afiliado IN (SELECT afi_id FROM inserted)
END
GO

-- -----------------------------------------------------
-- creacion tabla planMedicoAudit
-- Se guarda el plan medico viejo del grupo familiar, junto ocn la razon
-- -----------------------------------------------------
CREATE TABLE moustache_spice.planMedicoAudit(
  grA_afiliado INT NOT NULL FOREIGN KEY REFERENCES moustache_spice.afiliado(afi_id),
  grA_plan_medicoViejo INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.planMedico(pla_id),
  grA_fecha DATETIME NOT NULL DEFAULT GETDATE(),
  grA_razon VARCHAR(255) NOT NULL,
);

-- -----------------------------------------------------
-- creacion tabla bonoConsulta
-- -----------------------------------------------------
CREATE TABLE moustache_spice.bonoConsulta (
  bco_id INT NOT NULL Identity,
  bco_fecha DATE NULL,
  bco_fechaCompa DATE NOT NULL,
  bco_comprador INT NOT NULL FOREIGN KEY REFERENCES moustache_spice.afiliado(afi_id),
  bco_afiliado INT NULL FOREIGN KEY REFERENCES  moustache_spice.afiliado(afi_id),
  bco_habilitado TINYINT NOT NULL DEFAULT 1, --Funciona de las veces de si esta o no consumido
  PRIMARY KEY (bco_id)
);

-- -----------------------------------------------------
-- creacion tabla bonoFarmacia
-- -----------------------------------------------------
CREATE TABLE moustache_spice.bonoFarmacia (
  bfa_id INT NOT NULL Identity,
  bfa_fechaImpresion DATE NOT NULL,
  bfa_fechaVencimiento DATE NOT NULL,
  bfa_comprador INT NOT NULL FOREIGN KEY REFERENCES moustache_spice.afiliado(afi_id),
  bfa_afiliado INT NULL FOREIGN KEY REFERENCES  moustache_spice.afiliado(afi_id),
  bfa_habilitado TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (bfa_id)
);

-- -----------------------------------------------------
-- creacion tabla turno
-- -----------------------------------------------------
CREATE TABLE moustache_spice.turno (
  tur_id INT NOT NULL Identity,
  tur_afiliado INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.afiliado(afi_id),
  tur_profesional INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.profesional(pro_id),
  tur_especialidad INT FOREIGN KEY REFERENCES moustache_spice.especialidad(esp_id),
  tur_fechaYHoraTurno DATETIME NOT NULL,
  tur_fechaYHoraLlegada DATETIME NULL,
  tur_fechaYHoraAtencion DATETIME NULL,
  tur_sintomas TEXT NULL,
  tur_diagnostico TEXT NULL,
  tur_bonoConsulta INT NULL FOREIGN KEY REFERENCES moustache_spice.bonoConsulta(bco_id),
  tur_habilitado TINYINT NOT NULL DEFAULT 1,-- Sería cuando se cancela un turno
  PRIMARY KEY (tur_id)
);

--Si se cancela el turno, se tiene que re-habilitar el bonoConsulta. El bonoFarmacia todavia no fue ni consumido (porque se tiene que cancelar ocn un dia de antelacion)
GO
CREATE TRIGGER moustache_spice.retribuirBono ON moustache_spice.turno AFTER UPDATE AS
BEGIN
	UPDATE moustache_spice.bonoConsulta
		SET bco_habilitado=1
		WHERE bco_id IN (SELECT tur_bonoConsulta FROM inserted WHERE tur_habilitado=0)
END
Go

-- -----------------------------------------------------
-- creacion tabla turnoAudit
-- Razones por la cancelacion, y un tipo que se cargue (Tanto del profesional como el afiliado)
-- -----------------------------------------------------
CREATE TABLE moustache_spice.turnoAudit(
	tuA_turno INT NOT NULL FOREIGN KEY REFERENCES moustache_spice.turno(tur_id),
	tuA_razon VARCHAR(255),
	tuA_tipo VARCHAR(255)
);
 
 -- Si el profesional cancela un semanal, se deshabilitan todos los turnos.
 -- Alguien tiene que mirar los inhabilitado y avisar al afiliado
GO
CREATE TRIGGER moustache_spice.cancelarTurnos ON moustache_spice.semanal FOR DELETE AS
BEGIN
	UPDATE moustache_spice.turno
		SET tur_habilitado=0
		WHERE DATEPART(dw, tur_fechaYHoraTurno) IN (SELECT sem_dia FROM deleted)
		AND CAST(tur_fechaYHoraTurno AS TIME) IN (SELECT sem_hora FROM deleted)
		AND tur_profesional IN (SELECT age_profesional FROM deleted LEFT JOIN moustache_spice.agenda ON sem_agenda = age_id)
END
GO

-- -----------------------------------------------------
-- creacion tabla medicamento
-- Todos los posibles medicamentos
-- -----------------------------------------------------
CREATE TABLE moustache_spice.medicamento (
  med_id INT NOT NULL Identity,
  med_nombre VARCHAR(255) NOT NULL,
  PRIMARY KEY(med_id)
);

-- -----------------------------------------------------
-- creacion tabla medicamento_x_bonoFarmacia
-- Relacion NxN que no se puede hacer en un modelo relacional
-- Sirve de las veces de "Receta"
-- -----------------------------------------------------
CREATE TABLE moustache_spice.medicamento_x_bonoFarmacia (
  mxb_medicamento INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.medicamento(med_id),
  mxb_bonoFarmacia INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.bonoFarmacia(bfa_id),
  mxb_unidades INT NOT NULL DEFAULT 1,
  mxb_prescripcion DATE NULL,
  PRIMARY KEY (mxb_medicamento, mxb_bonoFarmacia)
);

-- Si se crea una receta, el bono se da por consumido
GO
CREATE TRIGGER moustache_spice.consumirBono ON moustache_spice.medicamento_x_bonoFarmacia AFTER INSERT AS
BEGIN
	UPDATE moustache_spice.bonoFarmacia SET bfa_habilitado=0 WHERE bfa_id IN (SELECT DISTINCT mxb_bonoFarmacia FROM inserted)
END
GO

-- -----------------------------------------------------
-- creacion tabla pagos
-- -----------------------------------------------------
CREATE TABLE moustache_spice.pagos (
  pag_id INT NOT NULL Identity,
  pag_afiliado INT NOT NULL FOREIGN KEY REFERENCES  moustache_spice.afiliado(afi_id),
  pag_cantidadBonosFarmacia INT NOT NULL DEFAULT 0,
  pag_cantidadBonosConsulta INT NOT NULL DEFAULT 0,
  pag_fechaCompra DATETIME NOT NULL,
  PRIMARY KEY(pag_id)
);

-- -----------------------------------------------------
-- CREATE vistas
-- Todas estas sirven para mejorar un poco la performance, pero mas que nada para que el codigo en C# quede mas limpio
-- -----------------------------------------------------
GO
CREATE VIEW moustache_spice.vProfesional AS
		SELECT *, moustache_spice.concatenarEspecialidades(pro_id) AS especialidades
		FROM moustache_spice.profesional
			JOIN moustache_spice.usuario ON usu_id = pro_usuario
		WHERE pro_habilitado = 1
GO

CREATE VIEW moustache_spice.vAfiliado AS
		SELECT *, ISNULL(afi_grupoFamiliar2, afi_id) AS 'afi_grupoFamiliar' --Forma medio fea, pero caundo migramos Afiliados no tenemos una buena forma de saber en que ID se ingregan
		FROM moustache_spice.afiliado
			LEFT JOIN moustache_spice.usuario ON usu_id = afi_usuario
			LEFT JOIN moustache_spice.planMedico ON afi_planMedico = pla_id
			LEFT JOIN moustache_spice.estadoCivil ON afi_estadoCivil = est_id
		WHERE afi_habilitado=1
GO

CREATE VIEW moustache_spice.vAgenda AS
	SELECT age_id, age_desde, age_hasta, age_profesional, (usu_apellido + ', ' + usu_nombre) 'profesional', sem_dia, sem_hora
	FROM moustache_spice.agenda
		JOIN moustache_spice.semanal ON sem_agenda = age_id
		JOIN moustache_spice.vProfesional ON age_profesional = pro_id
GO

-- -----------------------------------------------------
-- INSERTs a mano
-- -----------------------------------------------------
PRINT 'INSERT a mano'
-- Se sabe que las funcionalidades no cambian.
INSERT moustache_spice.funcionalidad (fun_nombre) VALUES ('Abm_Rol')
														,('Abm_Usuario')
														,('Abm_Afiliado')
														,('Abm_Profesional')
														,('Abm_Especialidades_Medicas')
														,('Abm_Planes_Medicos')
														,('Agendas')
														,('Bonos')
														,('Turnos')
														,('Registro_de_Llegada')
														,('Registro_de_Resultado')
														,('Cancelar_atencion')
														,('Receta')
														,('Estadisticas');

INSERT moustache_spice.rol (rol_nombre, rol_habilitado) VALUES ('Administrativo', 1)
															  ,('Afiliado', 1)
															  ,('Profesional', 1);


INSERT moustache_spice.rol_x_funcionalidad(rxf_funcionalidad, rxf_rol)
	(SELECT fun_id,
			(SELECT rol_id FROM moustache_spice.rol WHERE rol_nombre='Administrativo')
	FROM moustache_spice.funcionalidad);
	
INSERT moustache_spice.rol_x_funcionalidad(rxf_funcionalidad, rxf_rol)
	(SELECT fun_id,
		    (SELECT rol_id FROM moustache_spice.rol WHERE rol_nombre='Afiliado')
	FROM moustache_spice.funcionalidad WHERE fun_nombre='Turnos'
											 OR fun_nombre='Cancelar_atencion'
											 OR fun_nombre='Bonos'
											 OR fun_nombre='Receta');

INSERT moustache_spice.rol_x_funcionalidad(rxf_funcionalidad, rxf_rol)
	(SELECT fun_id,
		    (SELECT rol_id FROM moustache_spice.rol WHERE rol_nombre='Profesional')
	FROM moustache_spice.funcionalidad WHERE fun_nombre='Agendas'
											 OR fun_nombre='Registro_de_Resultado'
											 OR fun_nombre='Cancelar_atencion');

-- Usuario que se nos impone
INSERT moustache_spice.usuario(usu_contrasegna, usu_habilitado, usu_intentosFallidos, usu_nombre, usu_nombreUsuario) VALUES
	('52d77462b24987175c8d7dab901a5967e927ffc8d0b6e4a234e07a4aec5e3724', 1, 0, 'Administrador General', 'admin');
--Le damos todas las funcionalidades
INSERT moustache_spice.rol_x_usuario(rxu_usuario, rxu_rol)
	(SELECT (SELECT TOP 1 usu_id FROM moustache_spice.usuario WHERE usu_nombreUsuario = 'admin'), rol_id FROM moustache_spice.rol)

INSERT moustache_spice.estadoCivil(est_estado) VALUES ('Soltero/a')
													 ,('Casado/a')
													 ,('Viudo/a')
													 ,('Concubinato')
													 ,('Divorciado/a');

-- -----------------------------------------------------
-- migracion tabla usuario
-- -----------------------------------------------------
PRINT 'migracion tabla usuario'
--Tanto afiliados como profesionales son usuarios, por eso el UNION
INSERT INTO moustache_spice.usuario(usu_numeroDocumento, usu_nombre, usu_apellido, usu_direccion, usu_telefono, usu_mail, usu_fechaNacimiento, usu_nombreUsuario)
        ((SELECT DISTINCT Paciente_Dni, Paciente_Nombre, Paciente_Apellido,
               Paciente_Direccion, Paciente_Telefono,
               Paciente_Mail, Paciente_Fecha_Nac,
               Paciente_Dni
        FROM gd_esquema.Maestra
        WHERE Paciente_Apellido IS NOT NULL)
        UNION
        (SELECT DISTINCT Medico_Dni, Medico_Nombre, Medico_Apellido,
				Medico_Direccion, Medico_Telefono,
				Medico_Mail, Medico_Fecha_Nac,
				Medico_Dni
        FROM gd_esquema.Maestra
        WHERE Medico_Apellido IS NOT NULL));

-- -----------------------------------------------------
-- migracion tabla planMedico
-- -----------------------------------------------------
PRINT 'migracion tabla planMedico'
--Levantar todos los planes medicos posibles, manteniendo el codigo legacy
INSERT INTO moustache_spice.planMedico(pla_codigo, pla_nombre, pla_precioBonoConsulta, pla_precioBonoFarmacia)
		(SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia
		FROM gd_esquema.Maestra WHERE Plan_Med_Codigo IS NOT NULL);

-- -----------------------------------------------------
-- migracion tabla afiliado 
-- -----------------------------------------------------
PRINT 'migracion tabla afiliado'
INSERT INTO moustache_spice.afiliado(afi_usuario, afi_planMedico, afi_orden)
	(SELECT DISTINCT usu_id, pla_id, 1 FROM gd_esquema.Maestra
	LEFT JOIN moustache_spice.usuario ON usu_numeroDocumento = Paciente_Dni
	LEFT JOIN moustache_spice.planMedico ON pla_codigo = Plan_Med_Codigo
	WHERE Paciente_Dni IS NOT NULL);
	
-- -----------------------------------------------------
-- migracion tabla profesional
-- -----------------------------------------------------	
PRINT 'migracion tabla profesional'
INSERT INTO moustache_spice.profesional(pro_usuario)
	(SELECT DISTINCT usu_id FROM gd_esquema.Maestra
	JOIN moustache_spice.usuario ON usu_numeroDocumento = Medico_Dni
	WHERE Medico_Dni IS NOT NULL);

-- -----------------------------------------------------
-- migracion tabla tipoEspecialidad
-- -----------------------------------------------------
PRINT 'migracion tabla tipoEspecialidad'
--Levantar todos los tipos de especialidad posibles, manteniendo el codigo legacy
INSERT INTO moustache_spice.tipoEspecialidad(tip_id, tip_nombre)
	(SELECT DISTINCT Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion FROM gd_esquema.Maestra WHERE Especialidad_Codigo IS NOT NULL);

-- -----------------------------------------------------
-- migracion tabla especialidad
-- -----------------------------------------------------
PRINT 'migracion tabla especialidad'
--Levantar todos las especialidades posibles, manteniendo el codigo legacy
INSERT INTO moustache_spice.especialidad(esp_id, esp_descripcion, esp_tipo)
	(SELECT DISTINCT Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo FROM gd_esquema.Maestra WHERE Especialidad_Codigo IS NOT NULL);

-- -----------------------------------------------------
-- migracion tabla profesional_x_especialidad
-- -----------------------------------------------------
PRINT 'migracion tabla profesional_x_especialidad'
INSERT INTO moustache_spice.profesional_x_especialidad(pxe_profesional, pxe_especialidad)
	(SELECT DISTINCT (SELECT pro_id FROM moustache_spice.vProfesional WHERE Medico_Dni = usu_numeroDocumento),
	Especialidad_Codigo FROM gd_esquema.Maestra
	WHERE Medico_Apellido IS NOT NULL);

-- -----------------------------------------------------
-- migracion tabla bonoConsulta
-- -----------------------------------------------------
PRINT 'migracion tabla bonoConsulta'
SET IDENTITY_INSERT moustache_spice.bonoConsulta ON
INSERT INTO moustache_spice.bonoConsulta(bco_id, bco_fechaCompa, bco_comprador, bco_afiliado, bco_fecha)
	(SELECT DISTINCT Bono_Consulta_Numero, Compra_Bono_Fecha, afi_id, afi_id, Bono_Consulta_Fecha_Impresion
        FROM gd_esquema.Maestra
			LEFT JOIN moustache_spice.vAfiliado ON usu_numeroDocumento = Paciente_Dni
        WHERE Bono_Consulta_Numero IS NOT NULL AND Compra_Bono_Fecha IS NOT NULL)
SET IDENTITY_INSERT moustache_spice.bonoConsulta OFF
       
-- -----------------------------------------------------
-- migracion tabla bonoFarmacia
-- -----------------------------------------------------
PRINT 'migracion tabla bonoFarmacia'
SET IDENTITY_INSERT moustache_spice.bonoFarmacia ON
INSERT INTO moustache_spice.bonoFarmacia(bfa_id, bfa_fechaImpresion, bfa_fechaVencimiento, bfa_afiliado, bfa_comprador, bfa_habilitado)
	(SELECT DISTINCT Bono_Farmacia_Numero, Bono_Farmacia_Fecha_Impresion, Bono_Farmacia_Fecha_Vencimiento, afi_id, afi_id, moustache_spice.bonoFarmaciaHabilitado(Bono_Farmacia_Fecha_Impresion, Bono_Farmacia_Fecha_Vencimiento)
	FROM gd_esquema.Maestra
		LEFT JOIN moustache_spice.vAfiliado ON usu_numeroDocumento = Paciente_Dni
	WHERE Bono_Farmacia_Numero IS NOT NULL)
SET IDENTITY_INSERT moustache_spice.bonoFarmacia OFF
--El constraint lo agregamos despues porque alentaba mucho la migracion
--La idea es que si no esta habilitado, nisiquiera revisa si es valido. Solo lo hace cuando el bono esta habilitado
ALTER TABLE moustache_spice.bonoFarmacia ADD CONSTRAINT CK_bfa_valido CHECK (bfa_habilitado=0 OR moustache_spice.bonoFarmaciaHabilitado( bfa_fechaImpresion, bfa_fechaVencimiento)=1 )

-- -----------------------------------------------------
-- migracion tabla agenda
-- -----------------------------------------------------
PRINT 'migracion tabla agenda'
--Creamos agendas para todos mas que naada a modo de debug, bien podriamos asumir no migrarlas y que la primera vez que un profesional ingrese al sistema, la cargue desde 0
INSERT INTO moustache_spice.agenda(age_profesional, age_hasta, age_desde)
	(SELECT pro_id, MAX(Turno_Fecha), DATEADD(DAY, -120, MAX(Turno_Fecha)) FROM gd_esquema.Maestra
		LEFT JOIN moustache_spice.vProfesional ON usu_numeroDocumento = Medico_Dni 
		WHERE Medico_Dni IS NOT NULL AND Turno_Fecha IS NOT NULL
	GROUP BY pro_id);

-- -----------------------------------------------------
-- migracion tabla turno
-- -----------------------------------------------------
PRINT 'migracion tabla turno'
--Aca hacemos algo medio feo con GROUP BY, el problema es que la misma fila aparece repetida con aveces NULL y aveces el sintoma, para "compactar" los nulls
--pero no perder cuales tiene sintomas, abusamos de la implementacion de MS SQL 2008 y su manejo de NULLs
SET IDENTITY_INSERT moustache_spice.turno ON
INSERT INTO moustache_spice.turno(tur_id, tur_bonoConsulta, tur_afiliado, tur_profesional, tur_fechaYHoraTurno, tur_fechaYHoraAtencion, tur_fechaYHoraLlegada, tur_sintomas, tur_diagnostico, tur_habilitado)
	(SELECT DISTINCT Turno_Numero, MAX(Bono_Consulta_Numero),
		afi_id, pro_id, Turno_Fecha, 
		(CASE WHEN MAX(Consulta_Sintomas) IS NOT NULL THEN Turno_Fecha ELSE NULL END),
		(CASE WHEN MAX(Consulta_Sintomas) IS NOT NULL THEN Turno_Fecha ELSE NULL END),
		MAX(Consulta_Sintomas), MAX(Consulta_Enfermedades),
		(CASE WHEN (CAST(Turno_Fecha AS DATE) > (SELECT TOP 1 age_desde FROM moustache_spice.agenda WHERE age_profesional = pro_id)
				AND CAST(Turno_Fecha AS DATE)  < (SELECT TOP 1 age_hasta FROM moustache_spice.agenda WHERE age_profesional = pro_id)) THEN 1 ELSE 0 END)
	FROM gd_esquema.Maestra
		LEFT JOIN moustache_spice.vAfiliado A ON A.usu_numeroDocumento = Paciente_Dni
		LEFT JOIN moustache_spice.vProfesional P ON P.usu_numeroDocumento = Medico_Dni
	WHERE Turno_Numero IS NOT NULL
	GROUP BY Turno_Numero, afi_id, pro_id, Turno_Fecha);
SET IDENTITY_INSERT moustache_spice.turno OFF
	
-- -----------------------------------------------------
-- migracion tabla semanal
-- -----------------------------------------------------
PRINT 'migracion tabla semanal'
-- Como con Agenda, lo inferimos mas que nada para poder testear, pero es una inferencia nuestra.
INSERT INTO moustache_spice.semanal(sem_agenda, sem_dia, sem_hora, sem_habilitado)
	(SELECT DISTINCT age_id, DATEPART(dw, tur_fechaYHoraTurno), CAST(tur_fechaYHoraTurno AS TIME),
	moustache_spice.semanalHabilitado(DATEPART(dw, tur_fechaYHoraTurno), CAST(tur_fechaYHoraTurno AS TIME))
	FROM moustache_spice.turno
		JOIN moustache_spice.agenda ON tur_profesional = age_profesional);
UPDATE moustache_spice.semanal SET sem_habilitado=0 WHERE moustache_spice.cargaHoraria(sem_agenda ) > 48;
ALTER TABLE moustache_spice.semanal ADD CONSTRAINT CK_sem_horarioValido CHECK(sem_habilitado=1 OR (moustache_spice.semanalHabilitado(sem_dia, sem_hora)=0 OR moustache_spice.cargaHoraria(sem_agenda ) > 48 ))

-- -----------------------------------------------------
-- migracion tabla medicamento
-- -----------------------------------------------------
PRINT 'migracion tabla medicamento'
INSERT INTO moustache_spice.medicamento(med_nombre)
	(SELECT DISTINCT Bono_Farmacia_Medicamento FROM gd_esquema.Maestra WHERE Bono_Farmacia_Medicamento IS NOT NULL);
		
-- -----------------------------------------------------
-- migracion tabla medicamento_x_bonoFarmacia
-- (Ya probamos que en la DB cada bono Farmacia tiene solo 1 medicamento)
-- -----------------------------------------------------
PRINT 'migracion tabla medicamento_x_bonoFarmacia'
INSERT INTO moustache_spice.medicamento_x_bonoFarmacia(mxb_bonoFarmacia, mxb_medicamento)
	(SELECT DISTINCT Bono_Farmacia_Numero, med_id
	FROM gd_esquema.Maestra
		LEFT JOIN moustache_spice.medicamento ON med_nombre = Bono_Farmacia_Medicamento
	WHERE Bono_Farmacia_Numero IS NOT NULL
	AND Bono_Farmacia_Medicamento IS NOT NULL);

GO
CREATE TRIGGER moustache_spice.checkearMedicamentos ON moustache_spice.medicamento_x_bonoFarmacia INSTEAD OF INSERT AS
BEGIN
	INSERT INTO moustache_spice.medicamento_x_bonoFarmacia(mxb_medicamento,mxb_bonoFarmacia,mxb_unidades,mxb_prescripcion) (SELECT * FROM inserted WHERE
																					(mxb_unidades <= 3 AND
																					moustache_spice.cantidadMedicamentos(mxb_bonoFarmacia) <= 5))
END
GO
