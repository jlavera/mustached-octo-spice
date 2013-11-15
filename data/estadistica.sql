--Top 5 de las especialidades que más se registraron cancelaciones, tanto de pacientes como de profesionales

-- Dentro del FORM elije cuales son las especialidades que quire evaluar, en el intervalo pedido.
-- Una vez que sabe que especailidades son, hace el producto cartesiano con una tabla de 6 meses par aque por cada especialidad en el TOP5
-- Por cada uno de los meses, en un subquery busca cuantas cencelaciones hubieron en ese mes en particular
SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes',
	   X.esp_descripcion 'Especialidad',
	   (SELECT COUNT(1) FROM moustache_spice.turnoAudit JOIN moustache_spice.turno ON tur_id = tuA_turno WHERE tur_especialidad=x.esp_id AND DATEPART(MONTH, tur_fechaYHoraTurno) = t.Mes AND DATEPART(YEAR, tur_fechaYHoraTurno)=2013) 'Cantidad de Cancelaciones'
FROM (SELECT TOP 5 esp_descripcion, esp_id FROM moustache_spice.turnoAudit
			JOIN moustache_spice.turno ON tur_id = tuA_turno
			JOIN moustache_spice.especialidad ON tur_especialidad = esp_id
		WHERE DATEPART(MONTH, tur_fechaYHoraTurno)>=7 AND DATEPART(MONTH, tur_fechaYHoraTurno)<=12 AND DATEPART(YEAR, tur_fechaYHoraTurno)=2013
		GROUP BY esp_descripcion, esp_id
		ORDER BY COUNT(esp_descripcion) DESC) X,
	 (SELECT 7 'Mes' UNION SELECT 8 UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12) T




----------------------------------------
--Top 5 de la cantidad total de bonos farmacia vencidos por afiliado

-- Devuelta, dentro del FORM esta la seleccion del TOP 5 de los bonos que no estan consumidos, pero estan vencidos al dia de la fecha, y que pertenezcan al semestre del año elejido
-- Despues de le hace un producto cartesiano con los meses
-- y con un subselect se calcula la cantidad de bonos vencidos por mes
SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes',
	   X.Afiliado 'Afiliado',
	   (SELECT COUNT(1) FROM moustache_spice.bonoFarmacia WHERE bfa_habilitado=1 AND bfa_fechaVencimiento<GETDATE() AND bfa_comprador=X.afi_id AND DATEPART(MONTH, bfa_fechaImpresion)=T.Mes AND DATEPART(YEAR, bfa_fechaImpresion)=2013) 'Cantidad bonos vencidos'
FROM (SELECT TOP 5 afi_id, usu_apellido + ', ' + usu_nombre 'Afiliado' FROM moustache_spice.bonoFarmacia
			JOIN moustache_spice.vAfiliado ON bfa_comprador=afi_id
			WHERE bfa_habilitado=1 AND bfa_fechaVencimiento<GETDATE() AND bfa_comprador=afi_id  AND DATEPART(MONTH, bfa_fechaImpresion)>=7 AND DATEPART(MONTH, bfa_fechaImpresion)<=12 AND DATEPART(YEAR, bfa_fechaImpresion)=2013
			GROUP BY afi_id, usu_apellido + ', ' + usu_nombre
		ORDER BY  COUNT(1) DESC) X ,
	 (SELECT 7 'Mes' UNION SELECT 8 UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12) T



----------------------------------------
--Top 5 de las especialidades de médicos con más bonos de farmacia recetados. 
--Misma estrategia, dentro del FORM esta el query para elejir el TOP 5, y despues por producto cartesiano se desglosa cada uno, mostrando la cantidad con un subselect
SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes',
	   X.esp_descripcion 'Especialidad',
	   (SELECT COUNT(1) FROM moustache_spice.turno WHERE tur_especialidad=X.esp_id AND DATEPART(MONTH, tur_fechaYHoraTurno)=T.Mes AND DATEPART(YEAR, tur_fechaYHoraTurno)=2013) 'Cantidad de bonos farmacia recetados'
FROM (SELECT TOP 5 esp_id, esp_descripcion FROM moustache_spice.turno
			JOIN moustache_spice.especialidad ON esp_id=tur_especialidad
		WHERE tur_bonoConsulta IS NOT NULL AND DATEPART(MONTH, tur_fechaYHoraTurno)>=7 AND DATEPART(MONTH, tur_fechaYHoraTurno)<=12 AND DATEPART(YEAR, tur_fechaYHoraTurno)=2013
		GROUP BY esp_descripcion, esp_id
		ORDER BY COUNT(1) DESC) X,
	(SELECT 7 'Mes' UNION SELECT 8 UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12) T



----------------------------------------
--Top 10 de los afiliados que utilizaron bonos que ellos mismo no compraron. 
--Me repito
SELECT DATENAME(month,  DateAdd( month , T.Mes , 0 ) - 1) 'Mes',
	   X.Afiliado 'Afiliado',
	   (SELECT COUNT(bfa_id)+COUNT(bco_id) FROM moustache_spice.afiliado
			LEFT JOIN moustache_spice.bonoConsulta ON bco_comprador=afi_id AND bco_afiliado!=afi_id AND DATEPART(MONTH, bco_fechaCompa)=T.Mes AND DATEPART(YEAR, bco_fechaCompa)=2013
			LEFT JOIN moustache_spice.bonoFarmacia ON bfa_comprador=afi_id AND bfa_afiliado!=afi_id AND DATEPART(MONTH, bfa_fechaImpresion)=T.mes AND DATEPART(YEAR, bfa_fechaImpresion)=2013
		WHERE afi_id=X.afi_id) 'Cantidad de bonos no cobrados por el'
FROM (SELECT TOP 10 afi_id, usu_apellido + ', ' + usu_nombre 'Afiliado' FROM moustache_spice.vAfiliado
			LEFT JOIN moustache_spice.bonoConsulta ON bco_comprador=afi_id AND bco_afiliado!=afi_id AND DATEPART(MONTH, bco_fechaCompa)>=7 AND DATEPART(MONTH, bco_fechaCompa)<=12 AND DATEPART(YEAR, bco_fechaCompa)=2013
			LEFT JOIN moustache_spice.bonoFarmacia ON bfa_comprador=afi_id AND bfa_afiliado!=afi_id AND DATEPART(MONTH, bfa_fechaImpresion)>=7 AND DATEPART(MONTH, bfa_fechaImpresion)<=12 AND DATEPART(YEAR, bfa_fechaImpresion)=2013
		GROUP BY afi_id, usu_apellido + ', ' + usu_nombre
		ORDER BY COUNT(bfa_id)+COUNT(bco_id) DESC) X,
	(SELECT 7 'Mes' UNION SELECT 8 UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12) T