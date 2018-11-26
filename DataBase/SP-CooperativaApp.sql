

    -- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.7.15-log - MySQL Community Server (GPL)
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para bd_cooperativa_app



-- Volcando estructura para tabla bd_cooperativa_app.tbl_aportes
CREATE TABLE IF NOT EXISTS `tbl_aportes` (
  `Id_Aporte` int(11) NOT NULL AUTO_INCREMENT,
  `Num_Boleta` int(11) DEFAULT NULL,
  `Id_Socio` int(11) DEFAULT NULL,
  `Observacion` varchar(500) DEFAULT NULL,
  `Id_Dato_Cooperativa` int(11) DEFAULT NULL,
  `Monto_Aporte` decimal(10,2) DEFAULT NULL,
  `Monto_Fondo_De_Sepelio` decimal(10,2) DEFAULT NULL,
  `Otros` decimal(10,2) DEFAULT NULL,
  `Monto_Total` decimal(10,2) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Id_Usuario` int(11) DEFAULT NULL,
  `Fecha_De_Registro` datetime(3) DEFAULT NULL,
  PRIMARY KEY (`Id_Aporte`),
  KEY `fk_Id_Dato_Cooperativa_A` (`Id_Dato_Cooperativa`),
  KEY `fk_Id_Usuario_A` (`Id_Usuario`),
  KEY `fk_Id_Socio_A` (`Id_Socio`),
  CONSTRAINT `fk_Id_Dato_Cooperativa_A` FOREIGN KEY (`Id_Dato_Cooperativa`) REFERENCES `tbl_datos_de_cooperativa` (`Id_Dato_Cooperativa`),
  CONSTRAINT `fk_Id_Socio_A` FOREIGN KEY (`Id_Socio`) REFERENCES `tbl_socios` (`Id_Socio`),
  CONSTRAINT `fk_Id_Usuario_A` FOREIGN KEY (`Id_Usuario`) REFERENCES `tbl_usuarios` (`Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_aportes: ~0 rows (aproximadamente)
DELETE FROM `tbl_aportes`;
/*!40000 ALTER TABLE `tbl_aportes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_aportes` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_beneficiario
CREATE TABLE IF NOT EXISTS `tbl_beneficiario` (
  `Id_Beneficiario` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Socio` int(11) DEFAULT NULL,
  `Tipo_De_Documento` varchar(100) DEFAULT NULL,
  `Num_Documento` varchar(100) DEFAULT NULL,
  `Apellidos` varchar(100) DEFAULT NULL,
  `Nombres` varchar(100) DEFAULT NULL,
  `Celular` varchar(100) DEFAULT NULL,
  `Telefono` varchar(100) DEFAULT NULL,
  `Tipo_De_Beneficiario` varchar(100) DEFAULT NULL,
  `Parentesco` varchar(100) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Fecha_De_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Beneficiario`),
  KEY `fk_Id_Socio_B` (`Id_Socio`),
  CONSTRAINT `fk_Id_Socio_B` FOREIGN KEY (`Id_Socio`) REFERENCES `tbl_socios` (`Id_Socio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_beneficiario: ~0 rows (aproximadamente)
DELETE FROM `tbl_beneficiario`;
/*!40000 ALTER TABLE `tbl_beneficiario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_beneficiario` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_cierre_de_caja
CREATE TABLE IF NOT EXISTS `tbl_cierre_de_caja` (
  `Id_Cierre_De_Caja` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Usuario` int(11) DEFAULT NULL,
  `Fecha_De_Inicio` datetime DEFAULT NULL,
  `Fecha_De_Fin` datetime DEFAULT NULL,
  `Dinero_Inicial` decimal(10,2) DEFAULT NULL,
  `Pagos` decimal(10,2) DEFAULT NULL,
  `Aportes` decimal(10,2) DEFAULT NULL,
  `Cancelaciones` decimal(10,2) DEFAULT NULL,
  `Egresos` decimal(10,2) DEFAULT NULL,
  `Monto_Total` decimal(10,2) DEFAULT NULL,
  `Estado` decimal(10,2) DEFAULT NULL,
  `Fecha_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Cierre_De_Caja`),
  KEY `FK_Id_Usuario_CC` (`Id_Usuario`),
  CONSTRAINT `FK_Id_Usuario_CC` FOREIGN KEY (`Id_Usuario`) REFERENCES `tbl_usuarios` (`Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_cierre_de_caja: ~0 rows (aproximadamente)
DELETE FROM `tbl_cierre_de_caja`;
/*!40000 ALTER TABLE `tbl_cierre_de_caja` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cierre_de_caja` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_cronograma_de_pagos
CREATE TABLE IF NOT EXISTS `tbl_cronograma_de_pagos` (
  `Id_Cronograma` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Prestamo` int(11) DEFAULT NULL,
  `Num_Cuota` int(11) DEFAULT NULL,
  `Fecha_De_Vencimiento` date DEFAULT NULL,
  `Amortizacion` decimal(10,2) DEFAULT NULL,
  `Interes` decimal(10,2) DEFAULT NULL,
  `Interes_Diferido` decimal(10,2) DEFAULT NULL,
  `Seg_Desgravamen` decimal(10,2) DEFAULT NULL,
  `Seg_Multiriesgo` decimal(10,2) DEFAULT NULL,
  `ITF` decimal(10,2) DEFAULT NULL,
  `Otros` decimal(10,2) DEFAULT NULL,
  `Saldo_Capital` decimal(10,2) DEFAULT NULL,
  `Cuota_Fija` decimal(10,2) DEFAULT NULL,
  `Dias` int(11) DEFAULT NULL,
  `Dias_Acumulados` int(11) DEFAULT NULL,
  `Dias_Morosidad` int(11) DEFAULT NULL,
  `Monto_Morosidad` decimal(10,2) DEFAULT NULL,
  `Cuota_Total` decimal(10,2) DEFAULT NULL,
  `Fecha_De_Pago` date DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Cronograma`),
  KEY `fk_Id_Prestamo_C` (`Id_Prestamo`),
  CONSTRAINT `fk_Id_Prestamo_C` FOREIGN KEY (`Id_Prestamo`) REFERENCES `tbl_prestamos` (`Id_Prestamo`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_cronograma_de_pagos: ~12 rows (aproximadamente)
DELETE FROM `tbl_cronograma_de_pagos`;
/*!40000 ALTER TABLE `tbl_cronograma_de_pagos` DISABLE KEYS */;
INSERT INTO `tbl_cronograma_de_pagos` (`Id_Cronograma`, `Id_Prestamo`, `Num_Cuota`, `Fecha_De_Vencimiento`, `Amortizacion`, `Interes`, `Interes_Diferido`, `Seg_Desgravamen`, `Seg_Multiriesgo`, `ITF`, `Otros`, `Saldo_Capital`, `Cuota_Fija`, `Dias`, `Dias_Acumulados`, `Dias_Morosidad`, `Monto_Morosidad`, `Cuota_Total`, `Fecha_De_Pago`, `Estado`) VALUES
    (2, 5, 1, '2018-02-01', 2784.75, 1240.71, 0.00, 36.00, 0.00, 0.05, 0.00, 37215.25, 4061.51, 31, 31, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (3, 5, 2, '2018-03-01', 2984.38, 1041.08, 0.00, 36.00, 0.00, 0.05, 0.00, 34230.87, 4061.51, 28, 59, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (4, 5, 3, '2018-04-01', 2963.69, 1061.77, 0.00, 36.00, 0.00, 0.05, 0.00, 31267.18, 4061.51, 31, 90, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (5, 5, 4, '2018-05-01', 3087.37, 938.09, 0.00, 36.00, 0.00, 0.05, 0.00, 28179.81, 4061.51, 30, 120, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (6, 5, 5, '2018-06-01', 3151.38, 874.08, 0.00, 36.00, 0.00, 0.05, 0.00, 25028.42, 4061.51, 31, 151, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (7, 5, 6, '2018-07-01', 3274.55, 750.91, 0.00, 36.00, 0.00, 0.05, 0.00, 21753.87, 4061.51, 30, 181, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (8, 5, 7, '2018-08-01', 3350.70, 674.76, 0.00, 36.00, 0.00, 0.05, 0.00, 18403.17, 4061.51, 31, 212, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (9, 5, 8, '2018-09-01', 3454.63, 570.83, 0.00, 36.00, 0.00, 0.05, 0.00, 14948.54, 4061.51, 31, 243, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (10, 5, 9, '2018-10-01', 3576.97, 448.49, 0.00, 36.00, 0.00, 0.05, 0.00, 11371.57, 4061.51, 30, 273, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (11, 5, 10, '2018-11-01', 3672.74, 352.72, 0.00, 36.00, 0.00, 0.05, 0.00, 7698.83, 4061.51, 31, 304, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (12, 5, 11, '2018-12-01', 3794.48, 230.98, 0.00, 36.00, 0.00, 0.05, 0.00, 3904.35, 4061.51, 30, 334, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
    (13, 5, 12, '2019-01-01', 3904.35, 121.10, 0.00, 36.00, 0.00, 0.05, 0.00, 0.00, 4061.51, 31, 365, 0, 0.00, 0.00, NULL, 'PENDIENTE');
/*!40000 ALTER TABLE `tbl_cronograma_de_pagos` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_datos_de_cooperativa
CREATE TABLE IF NOT EXISTS `tbl_datos_de_cooperativa` (
  `Id_Dato_Cooperativa` int(11) NOT NULL AUTO_INCREMENT,
  `Fondo_De_Sepelio` decimal(10,2) DEFAULT NULL,
  `Aportacion` decimal(10,2) DEFAULT NULL,
  `Sepelio_Titular` decimal(10,2) DEFAULT NULL,
  `Sepelio_Familiar` decimal(10,2) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Fecha_De_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Dato_Cooperativa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_datos_de_cooperativa: ~0 rows (aproximadamente)
DELETE FROM `tbl_datos_de_cooperativa`;
/*!40000 ALTER TABLE `tbl_datos_de_cooperativa` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_datos_de_cooperativa` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_datos_financieros
CREATE TABLE IF NOT EXISTS `tbl_datos_financieros` (
  `Id_Dato_Financiero` int(11) NOT NULL AUTO_INCREMENT,
  `TEA` double DEFAULT '0',
  `TEM` double DEFAULT '0',
  `TED` double DEFAULT '0',
  `Seguro_Desgravamen` double DEFAULT '0',
  `Seguro_Multiriesgo` double DEFAULT '0',
  `ITF` double DEFAULT '0',
  `Otros` double DEFAULT '0',
  `Estado` varchar(50) DEFAULT '',
  `Fecha_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Dato_Financiero`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_datos_financieros: ~2 rows (aproximadamente)
DELETE FROM `tbl_datos_financieros`;
/*!40000 ALTER TABLE `tbl_datos_financieros` DISABLE KEYS */;
INSERT INTO `tbl_datos_financieros` (`Id_Dato_Financiero`, `TEA`, `TEM`, `TED`, `Seguro_Desgravamen`, `Seguro_Multiriesgo`, `ITF`, `Otros`, `Estado`, `Fecha_Registro`) VALUES
    (11, 42.58, 0.030002354651603502, 0.09858552464132586, 5, 5, 5, 5, 'ACTIVO', '2018-11-23'),
    (12, 42.58, 0.0300023546516035, 0.000985855246413259, 0.0009, 0, 0, 0, 'ACTIVO', '2018-11-23');
/*!40000 ALTER TABLE `tbl_datos_financieros` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_documentos
CREATE TABLE IF NOT EXISTS `tbl_documentos` (
  `Id_Documento` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Descripcion` varchar(500) DEFAULT NULL,
  `Pdf` varchar(50) DEFAULT NULL,
  `Estado` int(11) DEFAULT NULL,
  `Fecha_Registro` date DEFAULT NULL,
  KEY `Id_Documento` (`Id_Documento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_documentos: ~0 rows (aproximadamente)
DELETE FROM `tbl_documentos`;
/*!40000 ALTER TABLE `tbl_documentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_documentos` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_egresos
CREATE TABLE IF NOT EXISTS `tbl_egresos` (
  `Id_Egreso` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(500) DEFAULT NULL,
  `Observacion` varchar(500) DEFAULT NULL,
  `Monto` decimal(10,2) DEFAULT NULL,
  `Estado` int(11) DEFAULT NULL,
  `Id_Usuario` int(11) DEFAULT NULL,
  `Fecha_De_Registro` datetime(3) DEFAULT NULL,
  PRIMARY KEY (`Id_Egreso`),
  KEY `fk_Id_Usuario_E` (`Id_Usuario`),
  CONSTRAINT `fk_Id_Usuario_E` FOREIGN KEY (`Id_Usuario`) REFERENCES `tbl_usuarios` (`Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_egresos: ~0 rows (aproximadamente)
DELETE FROM `tbl_egresos`;
/*!40000 ALTER TABLE `tbl_egresos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_egresos` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_pagos
CREATE TABLE IF NOT EXISTS `tbl_pagos` (
  `Id_Pago` int(11) NOT NULL AUTO_INCREMENT,
  `Num_Boleta` int(11) DEFAULT NULL,
  `Id_Cronograma` int(11) DEFAULT NULL,
  `Observacion` varchar(500) DEFAULT NULL,
  `Tipo_De_Pago` int(11) DEFAULT NULL,
  `Cuota_Fija` decimal(10,2) DEFAULT NULL,
  `Dias_Morosidad` decimal(10,2) DEFAULT NULL,
  `Monto_Morosidad` decimal(10,2) DEFAULT NULL,
  `Monto_Total` decimal(10,2) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Id_Usuario` int(11) DEFAULT NULL,
  `Fecha_De_Registro` datetime(3) DEFAULT NULL,
  PRIMARY KEY (`Id_Pago`),
  KEY `fk_Id_Cronograma_PG` (`Id_Cronograma`),
  KEY `fk_Id_Usuario_PG` (`Id_Usuario`),
  CONSTRAINT `fk_Id_Cronograma_PG` FOREIGN KEY (`Id_Cronograma`) REFERENCES `tbl_cronograma_de_pagos` (`Id_Cronograma`),
  CONSTRAINT `fk_Id_Usuario_PG` FOREIGN KEY (`Id_Usuario`) REFERENCES `tbl_usuarios` (`Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_pagos: ~0 rows (aproximadamente)
DELETE FROM `tbl_pagos`;
/*!40000 ALTER TABLE `tbl_pagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pagos` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_prestamos
CREATE TABLE IF NOT EXISTS `tbl_prestamos` (
  `Id_Prestamo` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Socio` int(11) DEFAULT NULL,
  `Monto` decimal(10,2) DEFAULT '0.00',
  `Num_De_Cuotas` int(11) DEFAULT '0',
  `Observaciones` varchar(1000) DEFAULT '',
  `Anexos` varchar(50) DEFAULT '',
  `Id_Dato_Financiero` int(11) DEFAULT NULL,
  `Fecha_De_Desembolso` date DEFAULT NULL,
  `Dias_De_Gracia` int(11) DEFAULT '0',
  `Fecha_De_Pago` date DEFAULT NULL,
  `Cuota_Base` decimal(10,2) DEFAULT '0.00',
  `Interes` decimal(10,2) DEFAULT '0.00',
  `Interes_Diferido` decimal(10,2) DEFAULT '0.00',
  `Cuota_Fija` decimal(10,2) DEFAULT '0.00',
  `Saldo_Capital` decimal(10,2) DEFAULT '0.00',
  `Usuario_Sol` int(11) DEFAULT NULL,
  `Usuario_Val` int(11) DEFAULT NULL,
  `Estado` varchar(10) DEFAULT NULL,
  `Fecha_De_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Prestamo`),
  KEY `fk_Id_Socio_P` (`Id_Socio`),
  KEY `fk_Id_Usuario_Sol_P` (`Usuario_Sol`),
  KEY `fk_Id_Usuario_Val_P` (`Usuario_Val`),
  KEY `fk_Id_Dato_Financiero_P` (`Id_Dato_Financiero`),
  CONSTRAINT `fk_Id_Dato_Financiero_P` FOREIGN KEY (`Id_Dato_Financiero`) REFERENCES `tbl_datos_financieros` (`Id_Dato_Financiero`),
  CONSTRAINT `fk_Id_Socio_P` FOREIGN KEY (`Id_Socio`) REFERENCES `tbl_socios` (`Id_Socio`),
  CONSTRAINT `fk_Id_Usuario_Sol_P` FOREIGN KEY (`Usuario_Sol`) REFERENCES `tbl_usuarios` (`Id_Usuario`),
  CONSTRAINT `fk_Id_Usuario_Val_P` FOREIGN KEY (`Usuario_Val`) REFERENCES `tbl_usuarios` (`Id_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=10000 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_prestamos: ~4 rows (aproximadamente)
DELETE FROM `tbl_prestamos`;
/*!40000 ALTER TABLE `tbl_prestamos` DISABLE KEYS */;
INSERT INTO `tbl_prestamos` (`Id_Prestamo`, `Id_Socio`, `Monto`, `Num_De_Cuotas`, `Observaciones`, `Anexos`, `Id_Dato_Financiero`, `Fecha_De_Desembolso`, `Dias_De_Gracia`, `Fecha_De_Pago`, `Cuota_Base`, `Interes`, `Interes_Diferido`, `Cuota_Fija`, `Saldo_Capital`, `Usuario_Sol`, `Usuario_Val`, `Estado`, `Fecha_De_Registro`) VALUES
    (2, 6, 20000.00, 12, NULL, '', 12, '2018-01-01', 0, '2018-01-01', 2012.73, 8656.84, 0.00, 2030.78, 20000.00, 1, 1, 'APROBADO', '2018-11-24'),
    (3, 6, 20000.00, 12, NULL, '', 12, '2018-01-01', 0, '2018-01-01', 2012.73, 8656.84, 0.00, 2030.78, 20000.00, 1, 1, 'APROBADO', '2018-11-24'),
    (4, 6, 20000.00, 12, NULL, '', 12, '2018-01-01', 0, '2018-01-01', 2012.73, 8656.84, 0.00, 2030.78, 20000.00, 1, 1, 'APROBADO', '2018-11-24'),
    (5, 6, 50000.00, 12, NULL, '', 12, '2018-01-01', 0, '2018-01-01', 5031.82, 21642.10, 0.00, 5076.87, 50000.00, 1, 1, 'APROBADO', '2018-11-24');
/*!40000 ALTER TABLE `tbl_prestamos` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_sepelio
CREATE TABLE IF NOT EXISTS `tbl_sepelio` (
  `Id_Sepelio` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Socio` int(11) DEFAULT NULL,
  `Id_Beneficiario` int(11) DEFAULT NULL,
  `Tipo` int(11) DEFAULT NULL,
  `Fecha_De_Desembolso` date DEFAULT NULL,
  `Doc_Adjunto` varchar(50) DEFAULT NULL,
  `Monto` decimal(10,0) DEFAULT NULL,
  `Observacion` varchar(500) DEFAULT NULL,
  `Id_Usuario` int(11) DEFAULT NULL,
  `Estado` int(11) DEFAULT NULL,
  `Fecha_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Sepelio`),
  KEY `Fk_Id_Usuario_SP` (`Id_Socio`),
  CONSTRAINT `Fk_Id_Usuario_SP` FOREIGN KEY (`Id_Socio`) REFERENCES `tbl_socios` (`Id_Socio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_sepelio: ~0 rows (aproximadamente)
DELETE FROM `tbl_sepelio`;
/*!40000 ALTER TABLE `tbl_sepelio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_sepelio` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_socios
CREATE TABLE IF NOT EXISTS `tbl_socios` (
  `Id_Socio` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo_De_Documento` varchar(100) DEFAULT '',
  `Num_Documento` varchar(100) DEFAULT '',
  `Apellidos` varchar(100) DEFAULT '',
  `Nombres` varchar(100) DEFAULT '',
  `Fecha_De_Nacimiento` date DEFAULT NULL,
  `Sexo` varchar(50) DEFAULT '',
  `Estado_Civil` varchar(100) DEFAULT '',
  `Profesion` varchar(100) DEFAULT '',
  `Nivel_De_Instruccion` varchar(100) DEFAULT '',
  `Direccion` varchar(100) DEFAULT '',
  `Distrito` varchar(100) DEFAULT '',
  `Provincia` varchar(100) DEFAULT '',
  `Departamento` varchar(100) DEFAULT '',
  `Referencia` varchar(100) DEFAULT '',
  `Celular` varchar(100) DEFAULT '',
  `Telefono` varchar(100) DEFAULT '',
  `Email` varchar(100) DEFAULT '',
  `Envio_De_Cronogramas_De_Pago` varchar(100) DEFAULT '',
  `Nombre_De_Empresa` varchar(100) DEFAULT '',
  `Fecha_De_Ingreso` date DEFAULT NULL,
  `Ingreso_Mensual_Neto` decimal(10,2) DEFAULT '0.00',
  `Cargo` varchar(100) DEFAULT '',
  `Area_De_Trabajo` varchar(100) DEFAULT '',
  `Direccion_De_Empresa` varchar(100) DEFAULT '',
  `Distrito_De_Empresa` varchar(100) DEFAULT '',
  `Provincia_De_Empresa` varchar(100) DEFAULT '',
  `Departamento_De_Empresa` varchar(100) DEFAULT '',
  `Referencia_De_Empresa` varchar(100) DEFAULT '',
  `Telefono_De_Empresa` varchar(100) DEFAULT '',
  `Modalidad_De_Contratacion` varchar(100) DEFAULT '',
  `Centro_De_Trabajo` varchar(100) DEFAULT '',
  `Monto_Acumulado` decimal(10,2) DEFAULT '0.00',
  `Nivel` varchar(50) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Fecha_De_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Socio`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_socios: ~1 rows (aproximadamente)
DELETE FROM `tbl_socios`;
/*!40000 ALTER TABLE `tbl_socios` DISABLE KEYS */;
INSERT INTO `tbl_socios` (`Id_Socio`, `Tipo_De_Documento`, `Num_Documento`, `Apellidos`, `Nombres`, `Fecha_De_Nacimiento`, `Sexo`, `Estado_Civil`, `Profesion`, `Nivel_De_Instruccion`, `Direccion`, `Distrito`, `Provincia`, `Departamento`, `Referencia`, `Celular`, `Telefono`, `Email`, `Envio_De_Cronogramas_De_Pago`, `Nombre_De_Empresa`, `Fecha_De_Ingreso`, `Ingreso_Mensual_Neto`, `Cargo`, `Area_De_Trabajo`, `Direccion_De_Empresa`, `Distrito_De_Empresa`, `Provincia_De_Empresa`, `Departamento_De_Empresa`, `Referencia_De_Empresa`, `Telefono_De_Empresa`, `Modalidad_De_Contratacion`, `Centro_De_Trabajo`, `Monto_Acumulado`, `Nivel`, `Estado`, `Fecha_De_Registro`) VALUES
    (6, 'DNI', '70359383', 'mamani calisaya', 'yonathan william', '1996-03-03', 'MASCULINO', 'SOLTERO', 'ing de sistemas', 'SECUNDARIA', 'tacna', 'tacna', 'tacna', 'tacna', 'tacna', 'tacna', NULL, 'yonathanwilliammc@gmail.com', '1', 'rj diseñadores', '2013-03-03', 1000.00, 'programador', NULL, 'tacna', 'tacna', 'tacna', 'tacna', 'tacna', '96786789', 'NOMBRADO', 'HOSPITAL', 100.00, 'NIVEL 1', 'ACTIVO', '2013-03-03');
/*!40000 ALTER TABLE `tbl_socios` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_tipo_de_usuario
CREATE TABLE IF NOT EXISTS `tbl_tipo_de_usuario` (
  `Id_Tipo_De_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Estado` varchar(50) NOT NULL,
  `Fecha_registro` date NOT NULL,
  PRIMARY KEY (`Id_Tipo_De_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_tipo_de_usuario: ~1 rows (aproximadamente)
DELETE FROM `tbl_tipo_de_usuario`;
/*!40000 ALTER TABLE `tbl_tipo_de_usuario` DISABLE KEYS */;
INSERT INTO `tbl_tipo_de_usuario` (`Id_Tipo_De_Usuario`, `Nombre`, `Estado`, `Fecha_registro`) VALUES
    (1, 'ADMINISTRADOR', 'ACTIVO', '2018-11-24');
/*!40000 ALTER TABLE `tbl_tipo_de_usuario` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_usuarios
CREATE TABLE IF NOT EXISTS `tbl_usuarios` (
  `Id_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Tipo_De_Usuario` int(11) DEFAULT NULL,
  `Usuario` varchar(50) DEFAULT NULL,
  `Clave` varchar(50) DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `Celular` varchar(50) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Fecha_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Usuario`),
  KEY `fk_Id_Tipo_De_Usuario_U` (`Id_Tipo_De_Usuario`),
  CONSTRAINT `fk_Id_Tipo_De_Usuario_U` FOREIGN KEY (`Id_Tipo_De_Usuario`) REFERENCES `tbl_tipo_de_usuario` (`Id_Tipo_De_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_usuarios: ~1 rows (aproximadamente)
DELETE FROM `tbl_usuarios`;
/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
INSERT INTO `tbl_usuarios` (`Id_Usuario`, `Id_Tipo_De_Usuario`, `Usuario`, `Clave`, `Nombre`, `Apellido`, `Celular`, `Estado`, `Fecha_Registro`) VALUES
    (1, 1, 'ADMIN', '123', 'ADMINISTRADOR', NULL, '988507326', 'ACTIVO', '2018-11-24');
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;


-- Volcando estructura para procedimiento bd_cooperativa_app.UPS_ToList_Pagos_Pendientes
DELIMITER //
CREATE PROCEDURE `UPS_ToList_Pagos_Pendientes`(IN `Tipo_Documento_` VARCHAR(50), IN `Num_Documento_` VARCHAR(50))
BEGIN
SELECT c.Id_Cronograma,c.Id_Prestamo,c.Num_Cuota,c.Fecha_De_Vencimiento,c.Amortizacion,c.Interes,c.Interes_Diferido,c.Seg_Desgravamen,c.Seg_Multiriesgo,c.ITF,c.Otros,c.Saldo_Capital,c.Cuota_Fija,c.Dias,c.Dias_Acumulados,c.Dias_Morosidad,c.Monto_Morosidad,c.Cuota_Total,c.Fecha_De_Pago,c.Estado
 ,s.Apellidos,s.Nombres
 FROM tbl_cronograma_de_pagos AS c 
 INNER JOIN tbl_prestamos AS p ON p.Id_Prestamo = c.Id_Prestamo
 INNER JOIN tbl_socios as s ON s.Id_Socio = p.Id_Socio 
 WHERE c.Estado = "PENDIENTE" AND p.Estado = "APROBADO" AND s.Tipo_De_Documento = Tipo_Documento_ AND s.Num_Documento = Num_Documento_ ORDER BY c.Num_Cuota ASC LIMIT 3;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Cronograma_De_Pago
DELIMITER //
CREATE PROCEDURE `USP_Add_Cronograma_De_Pago`(IN `Id_Prestamo_` INT, IN `Num_Cuota_` INT, IN `Fecha_De_Vencimiento_` DATE, IN `Amortizacion_` DECIMAL(10,2), IN `Interes_` DECIMAL(10,2), IN `Interes_Diferido_` DECIMAL(10,2), IN `Seg_Desgravamen_` DECIMAL(10,2), IN `Seg_Multiriesgo_` DECIMAL(10,2), IN `ITF_` DECIMAL(10,2), IN `Otros_` DECIMAL(10,2), IN `Saldo_Capital_` DECIMAL(10,2), IN `Cuota_Fija_` DECIMAL(10,2), IN `Dias_` INT, IN `Dias_Acumulados_` INT, IN `Dias_Morosidad_` INT, IN `Monto_Morosidad_` DECIMAL(10,2), IN `Cuota_Total_` DECIMAL(10,2), IN `Estado_` VARCHAR(50))
BEGIN
INSERT INTO tbl_cronograma_de_pagos(
Id_Prestamo,
Num_Cuota,
Fecha_De_Vencimiento,
Amortizacion,
Interes,
Interes_Diferido,
Seg_Desgravamen,
Seg_Multiriesgo,
ITF,
Otros,
Saldo_Capital,
Cuota_Fija,
Dias,
Dias_Acumulados,
Dias_Morosidad,
Monto_Morosidad,
Cuota_Total,
Estado)
VALUES(
Id_Prestamo_,
Num_Cuota_,
Fecha_De_Vencimiento_,
Amortizacion_,
Interes_,
Interes_Diferido_,
Seg_Desgravamen_,
Seg_Multiriesgo_,
ITF_,
Otros_,
Saldo_Capital_,
Cuota_Fija_,
Dias_,
Dias_Acumulados_,
Dias_Morosidad_,
Monto_Morosidad_,
Cuota_Total_,
Estado_
);
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Datos_Cooperativa
DELIMITER //
CREATE PROCEDURE `USP_Add_Datos_Cooperativa`(
    Fondo_De_Sepelio DECIMAL(10,2),
    Aportacion DECIMAL(10,2),
    Sepelio_Titular DECIMAL(10,2),
    Sepelio_Familiar DECIMAL(10,2),
    Estado VARCHAR(50)
)
BEGIN
INSERT INTO tbl_datos_de_cooperativa(Fondo_De_Sepelio,Aportacion,Sepelio_Titular,Sepelio_Familiar,Estado,Fecha_Registro) 
VALUES(Fondo_De_Sepelio,Aportacion,Sepelio_Titular,Sepelio_Familiar,Estado,CURRENT_DATE());
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Datos_Financieros
DELIMITER //
CREATE PROCEDURE `USP_Add_Datos_Financieros`(
    TEA DOUBLE,
    TEM DOUBLE,
    TED DOUBLE,
    Seguro_Desgravamen DOUBLE,
    Seguro_Multiriesgo DOUBLE,
    ITF DOUBLE,
    Otros DOUBLE,
    Estado VARCHAR(50)
)
BEGIN
INSERT INTO tbl_datos_financieros
(TEA,TEM,TED,Seguro_Desgravamen,Seguro_Multiriesgo,ITF,Otros,Estado,Fecha_Registro) 
VALUES
(TEA,TEM,TED,Seguro_Desgravamen,Seguro_Multiriesgo,ITF,Otros,Estado,CURRENT_DATE());
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Prestamo
DELIMITER //
CREATE PROCEDURE `USP_Add_Prestamo`(IN `Id_Socio` INT(11), IN `Monto` DECIMAL(10,2), IN `Num_De_Cuotas` INT(11), IN `Observaciones` VARCHAR(1000), IN `Anexos` VARCHAR(50), IN `Id_Dato_Financiero` INT(11), IN `Usuario_Sol` INT(11), IN `Usuario_Val` INT(11), IN `Estado` VARCHAR(10))
BEGIN
INSERT INTO tbl_prestamos(
Id_Socio,
Monto,
Num_De_Cuotas,
Observaciones,
Anexos,
Id_Dato_Financiero,
Usuario_Sol,
Usuario_Val,
Estado,
Fecha_De_Registro
) 
VALUES(
Id_Socio,
Monto,
Num_De_Cuotas,
Observaciones,
Anexos,
Id_Dato_Financiero,
Usuario_Sol,
Usuario_Val,
Estado,
CURRENT_DATE()
);
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Socio
DELIMITER //
CREATE PROCEDURE `USP_Add_Socio`(IN `Tipo_De_Documento` VARCHAR(100), IN `Num_Documento` VARCHAR(100), IN `Apellidos` VARCHAR(100), IN `Nombres` VARCHAR(100), IN `Fecha_De_Nacimiento` DATE, IN `Sexo` VARCHAR(50), IN `Estado_Civil` VARCHAR(100), IN `Profesion` VARCHAR(100), IN `Nivel_De_Instruccion` VARCHAR(100), IN `Direccion` VARCHAR(100), IN `Distrito` VARCHAR(100), IN `Provincia` VARCHAR(100), IN `Departamento` VARCHAR(100), IN `Referencia` VARCHAR(100), IN `Celular` VARCHAR(100), IN `Telefono` VARCHAR(100), IN `Email` VARCHAR(100), IN `Envio_De_Cronogramas_De_Pago` VARCHAR(100), IN `Nombre_De_Empresa` VARCHAR(100), IN `Fecha_De_Ingreso` DATE, IN `Ingreso_Mensual_Neto` DECIMAL(10,2), IN `Cargo` VARCHAR(100), IN `Area_De_Trabajo` VARCHAR(100), IN `Direccion_De_Empresa` VARCHAR(100), IN `Distrito_De_Empresa` VARCHAR(100), IN `Provincia_De_Empresa` VARCHAR(100), IN `Departamento_De_Empresa` VARCHAR(100), IN `Referencia_De_Empresa` VARCHAR(100), IN `Telefono_De_Empresa` VARCHAR(100), IN `Modalidad_De_Contratacion` VARCHAR(100), IN `Centro_De_Trabajo` VARCHAR(100), IN `Monto_Acumulado` DECIMAL(10,2), IN `Nivel` VARCHAR(50), IN `Estado` VARCHAR(50)
, IN `Fecha_De_Registro` DATE)
BEGIN
INSERT INTO tbl_socios(
Tipo_De_Documento,
Num_Documento,
Apellidos,
Nombres,
Fecha_De_Nacimiento,
Sexo,
Estado_Civil,
Profesion,
Nivel_De_Instruccion,
Direccion,
Distrito,
Provincia,
Departamento,
Referencia,
Celular,
Telefono,
Email,
Envio_De_Cronogramas_De_Pago,
Nombre_De_Empresa,
Fecha_De_Ingreso,
Ingreso_Mensual_Neto,
Cargo,
Area_De_Trabajo,
Direccion_De_Empresa,
Distrito_De_Empresa,
Provincia_De_Empresa,
Departamento_De_Empresa,
Referencia_De_Empresa,
Telefono_De_Empresa,
Modalidad_De_Contratacion,
Centro_De_Trabajo,
Monto_Acumulado,
Nivel,
Estado,
Fecha_De_Registro
) 
VALUES(
Tipo_De_Documento,
Num_Documento,
Apellidos,
Nombres,
Fecha_De_Nacimiento,
Sexo,
Estado_Civil,
Profesion,
Nivel_De_Instruccion,
Direccion,
Distrito,
Provincia,
Departamento,
Referencia,
Celular,
Telefono,
Email,
Envio_De_Cronogramas_De_Pago,
Nombre_De_Empresa,
Fecha_De_Ingreso,
Ingreso_Mensual_Neto,
Cargo,
Area_De_Trabajo,
Direccion_De_Empresa,
Distrito_De_Empresa,
Provincia_De_Empresa,
Departamento_De_Empresa,
Referencia_De_Empresa,
Telefono_De_Empresa,
Modalidad_De_Contratacion,
Centro_De_Trabajo,
Monto_Acumulado,
Nivel,
Estado,
Fecha_De_Registro
);
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Modify_Datos_Financieros
DELIMITER //
CREATE PROCEDURE `USP_Modify_Datos_Financieros`(
    ID INT,
    TEA DECIMAL(10,2),
    TEM DECIMAL(10,2),
    TED DECIMAL(10,2),
    Seguro_Desgravamen DECIMAL(10,2),
    ITF DECIMAL(10,2),
    Otros DECIMAL(10,2),
    Estado INT
)
BEGIN
UPDATE tbl_datos_financieros SET 
TEA = TEA,
TEM = TEM,
TED = TED,
Seguro_Desgravamen = Seguro_Desgravamen,
ITF = ITF,
Otros = Otros,
Estado = Estado
WHERE Id_Dato_Financiero = ID;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Datos_Financieros
DELIMITER //
CREATE PROCEDURE `USP_Select_Datos_Financieros`(IN `Id_Dato_Financiero_` INT)
BEGIN
SELECT * FROM tbl_datos_financieros WHERE Id_Dato_Financiero = Id_Dato_Financiero_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Prestamo
DELIMITER //
CREATE PROCEDURE `USP_Select_Prestamo`(
Id_Prestamo INT(11)
)
BEGIN
SELECT p.Id_Prestamo,p.Id_Socio,p.Monto,p.Num_De_Cuotas,p.Observaciones,p.Anexos,p.Id_Dato_Financiero,p.Fecha_De_Desembolso,p.Dias_De_Gracia,p.Fecha_De_Pago,p.Cuota_Base,p.Interes,p.Interes_Diferido,p.Cuota_Fija,p.Saldo_Capital,p.Usuario_Sol,p.Usuario_Val,p.Estado,p.Fecha_De_Registro 
,s.Tipo_De_Documento,s.Num_Documento,s.Apellidos,s.Nombres,d.TEA,d.TEM,d.TED,d.Seguro_Desgravamen,d.Seguro_Multiriesgo,d.ITF,d.Otros
FROM tbl_prestamos AS p
INNER JOIN tbl_socios AS s ON p.Id_Socio = s.Id_Socio
INNER JOIN tbl_datos_financieros AS d ON d.Id_Dato_Financiero = p.Id_Dato_Financiero

 WHERE p.Id_Prestamo = Id_Prestamo;



END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Socio_Por_Num_Documento
DELIMITER //
CREATE PROCEDURE `USP_Select_Socio_Por_Num_Documento`(
Tipo_Documento VARCHAR(100),
Num_Documento VARCHAR(100)
)
BEGIN
SELECT * FROM tbl_socios WHERE Tipo_Documento = Tipo_Documento AND Num_Documento = Num_Documento;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Cronograma_De_Pagos
DELIMITER //
CREATE PROCEDURE `USP_ToList_Cronograma_De_Pagos`(IN `Id_Prestamo_` INT)
BEGIN
SELECT * FROM tbl_cronograma_de_pagos WHERE Id_Prestamo = Id_Prestamo_ ORDER BY Num_Cuota ASC;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Datos_Cooperativa
DELIMITER //
CREATE PROCEDURE `USP_ToList_Datos_Cooperativa`()
BEGIN
SELECT * FROM tbl_datos_de_cooperativa;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Datos_Financieros
DELIMITER //
CREATE PROCEDURE `USP_ToList_Datos_Financieros`()
BEGIN
SELECT * FROM tbl_datos_financieros;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Dato_Financiero_Activo
DELIMITER //
CREATE PROCEDURE `USP_ToList_Dato_Financiero_Activo`()
BEGIN
SELECT * FROM tbl_datos_financieros WHERE Estado = 'ACTIVO' ORDER BY Id_Dato_Financiero DESC LIMIT 1;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Prestamos
DELIMITER //
CREATE PROCEDURE `USP_ToList_Prestamos`()
BEGIN
SELECT p.Id_Prestamo,p.Id_Socio,p.Monto,p.Num_De_Cuotas,p.Estado,DATE_FORMAT(p.Fecha_De_Registro, "%d-%m-%Y") as Fecha_De_Registro,s.Tipo_De_Documento,s.Num_Documento,s.Apellidos,s.Nombres 
FROM tbl_prestamos as p
INNER JOIN tbl_socios as s ON s.Id_Socio = p.Id_Socio ORDER BY p.Id_Prestamo DESC;

END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Socios
DELIMITER //
CREATE PROCEDURE `USP_ToList_Socios`()
BEGIN
SELECT * FROM tbl_socios;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Update_Prestamo
DELIMITER //
CREATE PROCEDURE `USP_Update_Prestamo`(IN `Id_Prestamo_` INT(11), IN `Monto_` DECIMAL(10,2), IN `Num_De_Cuotas_` INT(11), IN `Observaciones_` VARCHAR(1000), IN `Anexos_` VARCHAR(50), IN `Fecha_De_Desembolso_` DATE, IN `Dias_De_Gracia_` INT(11), IN `Fecha_De_Pago_` DATE, IN `Cuota_Base_` DECIMAL(10,2), IN `Interes_` DECIMAL(10,2), IN `Interes_Diferido_` DECIMAL(10,2), IN `Cuota_Fija_` DECIMAL(10,2), IN `Saldo_Capital_` DECIMAL(10,2), IN `Usuario_Val_` INT(11), IN `Estado_` VARCHAR(50)
)
BEGIN
UPDATE tbl_prestamos SET 
Monto = Monto_,
Num_De_Cuotas = Num_De_Cuotas_,
Observaciones = Observaciones_,
Anexos = Anexos_,
Fecha_De_Desembolso = Fecha_De_Desembolso_,
Dias_De_Gracia = Dias_De_Gracia_,
Fecha_De_Pago = Fecha_De_Pago_,
Cuota_Base = Cuota_Base_,
Interes = Interes_,
Interes_Diferido = Interes_Diferido_,
Cuota_Fija = Cuota_Fija_,
Saldo_Capital = Saldo_Capital_,
Usuario_Val = Usuario_Val_,
Estado = Estado_
wHERE Id_Prestamo = Id_Prestamo_;

END//
DELIMITER ;