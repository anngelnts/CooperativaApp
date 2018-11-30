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
CREATE DATABASE IF NOT EXISTS `bd_cooperativa_app` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bd_cooperativa_app`;


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
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_cronograma_de_pagos: ~12 rows (aproximadamente)
DELETE FROM `tbl_cronograma_de_pagos`;
/*!40000 ALTER TABLE `tbl_cronograma_de_pagos` DISABLE KEYS */;
INSERT INTO `tbl_cronograma_de_pagos` (`Id_Cronograma`, `Id_Prestamo`, `Num_Cuota`, `Fecha_De_Vencimiento`, `Amortizacion`, `Interes`, `Interes_Diferido`, `Seg_Desgravamen`, `Seg_Multiriesgo`, `ITF`, `Otros`, `Saldo_Capital`, `Cuota_Fija`, `Dias`, `Dias_Acumulados`, `Dias_Morosidad`, `Monto_Morosidad`, `Cuota_Total`, `Fecha_De_Pago`, `Estado`) VALUES
	(50, 10003, 1, '2018-12-29', 1412.89, 600.05, 0.00, 18.00, 0.00, 0.05, 0.00, 18587.11, 2030.99, 30, 30, 1, 1.00, 1.00, '0000-00-00', 'asd'),
	(51, 10003, 2, '2019-01-29', 1436.41, 576.53, 0.00, 18.00, 0.00, 0.05, 0.00, 17150.70, 2030.99, 31, 61, 0, 0.00, 2030.99, '2018-11-30', 'PAGADO'),
	(52, 10003, 3, '2019-02-28', 1498.38, 514.56, 0.00, 18.00, 0.00, 0.05, 0.00, 15652.33, 2030.99, 30, 91, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(53, 10003, 4, '2019-03-29', 1559.21, 453.73, 0.00, 18.00, 0.00, 0.05, 0.00, 14093.12, 2030.99, 29, 120, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(54, 10003, 5, '2019-04-29', 1575.80, 437.14, 0.00, 18.00, 0.00, 0.05, 0.00, 12517.32, 2030.99, 31, 151, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(55, 10003, 6, '2019-05-29', 1637.39, 375.55, 0.00, 18.00, 0.00, 0.05, 0.00, 10879.93, 2030.99, 30, 181, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(56, 10003, 7, '2019-06-29', 1675.47, 337.47, 0.00, 18.00, 0.00, 0.05, 0.00, 9204.46, 2030.99, 31, 212, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(57, 10003, 8, '2019-07-29', 1736.78, 276.16, 0.00, 18.00, 0.00, 0.05, 0.00, 7467.68, 2030.99, 30, 242, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(58, 10003, 9, '2019-08-29', 1781.31, 231.63, 0.00, 18.00, 0.00, 0.05, 0.00, 5686.37, 2030.99, 31, 273, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(59, 10003, 10, '2019-09-29', 1836.56, 176.38, 0.00, 18.00, 0.00, 0.05, 0.00, 3849.81, 2030.99, 31, 304, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(60, 10003, 11, '2019-10-29', 1897.43, 115.50, 0.00, 18.00, 0.00, 0.05, 0.00, 1952.38, 2030.99, 30, 334, 0, 0.00, 0.00, NULL, 'PENDIENTE'),
	(61, 10003, 12, '2019-11-29', 1952.38, 60.56, 0.00, 18.00, 0.00, 0.05, 0.00, 0.00, 2030.99, 31, 365, 0, 0.00, 0.00, NULL, 'PENDIENTE');
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
  `Num_Boleta` varchar(50) DEFAULT NULL,
  `Id_Cronograma` int(11) DEFAULT NULL,
  `Observacion` varchar(500) DEFAULT NULL,
  `Tipo_De_Pago` varchar(50) DEFAULT NULL,
  `Cuota_Fija` decimal(10,2) DEFAULT NULL,
  `Dias_Morosidad` int(11) DEFAULT NULL,
  `Monto_Morosidad` decimal(10,2) DEFAULT NULL,
  `Monto_Total` decimal(10,2) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Id_Usuario` int(11) DEFAULT NULL,
  `Fecha_De_Registro` datetime DEFAULT NULL,
  PRIMARY KEY (`Id_Pago`),
  KEY `fk_Id_Cronograma_PG` (`Id_Cronograma`),
  KEY `fk_Id_Usuario_PG` (`Id_Usuario`),
  CONSTRAINT `fk_Id_Cronograma_PG` FOREIGN KEY (`Id_Cronograma`) REFERENCES `tbl_cronograma_de_pagos` (`Id_Cronograma`),
  CONSTRAINT `fk_Id_Usuario_PG` FOREIGN KEY (`Id_Usuario`) REFERENCES `tbl_usuarios` (`Id_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_pagos: ~9 rows (aproximadamente)
DELETE FROM `tbl_pagos`;
/*!40000 ALTER TABLE `tbl_pagos` DISABLE KEYS */;
INSERT INTO `tbl_pagos` (`Id_Pago`, `Num_Boleta`, `Id_Cronograma`, `Observacion`, `Tipo_De_Pago`, `Cuota_Fija`, `Dias_Morosidad`, `Monto_Morosidad`, `Monto_Total`, `Estado`, `Id_Usuario`, `Fecha_De_Registro`) VALUES
	(1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2018-11-29 23:21:50'),
	(3, '123', 50, '', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-29 23:30:55'),
	(4, '123', 50, 'asdasda', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-29 23:31:15'),
	(5, '1234324', 51, 'asdsad', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-29 23:47:04'),
	(6, '234324', 50, '', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-30 00:14:22'),
	(7, 'asd', 51, 'asdasdasd', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-30 00:14:56'),
	(8, 'as', 50, '', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-30 00:15:26'),
	(9, 'asdad', 51, 'asdsad', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-30 00:18:33'),
	(10, 'asdad', 51, 'asdsad', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-30 00:18:43'),
	(11, '445345', 51, 'ssadasd', 'EFECTIVO', 2030.99, 0, 0.00, 2030.99, 'PAGADO', 1, '2018-11-30 00:22:42');
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
) ENGINE=InnoDB AUTO_INCREMENT=10005 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_prestamos: ~2 rows (aproximadamente)
DELETE FROM `tbl_prestamos`;
/*!40000 ALTER TABLE `tbl_prestamos` DISABLE KEYS */;
INSERT INTO `tbl_prestamos` (`Id_Prestamo`, `Id_Socio`, `Monto`, `Num_De_Cuotas`, `Observaciones`, `Anexos`, `Id_Dato_Financiero`, `Fecha_De_Desembolso`, `Dias_De_Gracia`, `Fecha_De_Pago`, `Cuota_Base`, `Interes`, `Interes_Diferido`, `Cuota_Fija`, `Saldo_Capital`, `Usuario_Sol`, `Usuario_Val`, `Estado`, `Fecha_De_Registro`) VALUES
	(10003, 6, 20000.00, 12, NULL, '', 12, '2018-11-29', 0, '2018-11-29', 2012.94, 8656.84, 0.00, 2030.99, 20000.00, 1, 1, 'APROBADO', '2018-11-29'),
	(10004, 10, 5000.00, 18, '', 'aaa', 12, NULL, 0, NULL, 0.00, 0.00, 0.00, 0.00, 0.00, 1, 1, 'PENDIENTE', '2018-11-29');
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_socios: ~5 rows (aproximadamente)
DELETE FROM `tbl_socios`;
/*!40000 ALTER TABLE `tbl_socios` DISABLE KEYS */;
INSERT INTO `tbl_socios` (`Id_Socio`, `Tipo_De_Documento`, `Num_Documento`, `Apellidos`, `Nombres`, `Fecha_De_Nacimiento`, `Sexo`, `Estado_Civil`, `Profesion`, `Nivel_De_Instruccion`, `Direccion`, `Distrito`, `Provincia`, `Departamento`, `Referencia`, `Celular`, `Telefono`, `Email`, `Envio_De_Cronogramas_De_Pago`, `Nombre_De_Empresa`, `Fecha_De_Ingreso`, `Ingreso_Mensual_Neto`, `Cargo`, `Area_De_Trabajo`, `Direccion_De_Empresa`, `Distrito_De_Empresa`, `Provincia_De_Empresa`, `Departamento_De_Empresa`, `Referencia_De_Empresa`, `Telefono_De_Empresa`, `Modalidad_De_Contratacion`, `Centro_De_Trabajo`, `Monto_Acumulado`, `Nivel`, `Estado`, `Fecha_De_Registro`) VALUES
	(6, 'DNI', '70359383', 'Mamani Calisaya', 'Yonathan William', '2018-10-10', 'MASCULINO', 'CASADO', '33', 'PRIMARIO', '33', '33', '33', '33', '33', '33', NULL, '33', '1', '33', '2018-10-10', 3.00, '33', NULL, '33', '33', '33', '33', '33', '33', 'NOMBRADO', 'RED DE SALUD', 33.00, 'NIVEL 1', 'ACTIVO', '2018-10-10'),
	(7, 'vvvv', 'vvvv', 'vvvvv', 'vvvv', '2018-10-10', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '2018-10-10', 3.00, '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', 33.00, '33', '33', '2018-10-10'),
	(8, 'aaaaadddddaaaaa', 'vvvv', 'vvvvv', 'vvvv', '2018-10-10', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '2018-10-10', 3.00, '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', 33.00, '33', '33', '2018-10-10'),
	(9, 'aaaaaaaaaa', 'vvvv', 'vvvvv', 'vvvv', '2018-10-10', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', '2018-10-10', 3.00, '33', '33', '33', '33', '33', '33', '33', '33', '33', '33', 33.00, '33', '33', '2018-10-10'),
	(10, 'DNI', '87654321', 'DFDSFSD', 'ASDAD', '2018-11-29', 'MASCULINO', 'SOLTERO', '', 'SECUNDARIA', '', '', '', '', '', '', NULL, '', '1', '', '2018-11-29', 0.00, '', NULL, '', '', '', '', '', '', 'NOMBRADO', 'HOSPITAL', 0.00, 'NIVEL 1', 'ACTIVO', '2018-11-29');
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `UPS_ToList_Pagos_Pendientes`(IN `Tipo_Documento_` VARCHAR(50), IN `Num_Documento_` VARCHAR(50))
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Add_Cronograma_De_Pago`(IN `Id_Prestamo_` INT, IN `Num_Cuota_` INT, IN `Fecha_De_Vencimiento_` DATE, IN `Amortizacion_` DECIMAL(10,2), IN `Interes_` DECIMAL(10,2), IN `Interes_Diferido_` DECIMAL(10,2), IN `Seg_Desgravamen_` DECIMAL(10,2), IN `Seg_Multiriesgo_` DECIMAL(10,2), IN `ITF_` DECIMAL(10,2), IN `Otros_` DECIMAL(10,2), IN `Saldo_Capital_` DECIMAL(10,2), IN `Cuota_Fija_` DECIMAL(10,2), IN `Dias_` INT, IN `Dias_Acumulados_` INT, IN `Dias_Morosidad_` INT, IN `Monto_Morosidad_` DECIMAL(10,2), IN `Cuota_Total_` DECIMAL(10,2), IN `Estado_` VARCHAR(50))
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Add_Datos_Cooperativa`(
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Add_Datos_Financieros`(
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


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Pago
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Add_Pago`(IN `Num_Boleta_` VARCHAR(50), IN `Id_Cronograma_` INT(11), IN `Observacion_` VARCHAR(500), IN `Tipo_De_Pago_` VARCHAR(50), IN `Cuota_Fija_` DECIMAL(10,2), IN `Dias_Morosidad_` INT, IN `Monto_Morosidad_` DECIMAL(10,2), IN `Monto_Total_` DECIMAL(10,2), IN `Estado_` VARCHAR(50), IN `Id_Usuario_` INT(11)
)
BEGIN
INSERT INTO tbl_pagos(
Num_Boleta,
Id_Cronograma,
Observacion,
Tipo_De_Pago,
Cuota_Fija,
Dias_Morosidad,
Monto_Morosidad,
Monto_Total,
Estado,
Id_Usuario,
Fecha_De_Registro
) 
VALUES(
Num_Boleta_,
Id_Cronograma_,
Observacion_,
Tipo_De_Pago_,
Cuota_Fija_,
Dias_Morosidad_,
Monto_Morosidad_,
Monto_Total_,
Estado_,
Id_Usuario_,
NOW()
);
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Add_Prestamo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Add_Prestamo`(IN `Id_Socio` INT(11), IN `Monto` DECIMAL(10,2), IN `Num_De_Cuotas` INT(11), IN `Observaciones` VARCHAR(1000), IN `Anexos` VARCHAR(50), IN `Id_Dato_Financiero` INT(11), IN `Usuario_Sol` INT(11), IN `Usuario_Val` INT(11), IN `Estado` VARCHAR(10))
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Add_Socio`(IN `Tipo_De_Documento` VARCHAR(100), IN `Num_Documento` VARCHAR(100), IN `Apellidos` VARCHAR(100), IN `Nombres` VARCHAR(100), IN `Fecha_De_Nacimiento` DATE, IN `Sexo` VARCHAR(50), IN `Estado_Civil` VARCHAR(100), IN `Profesion` VARCHAR(100), IN `Nivel_De_Instruccion` VARCHAR(100), IN `Direccion` VARCHAR(100), IN `Distrito` VARCHAR(100), IN `Provincia` VARCHAR(100), IN `Departamento` VARCHAR(100), IN `Referencia` VARCHAR(100), IN `Celular` VARCHAR(100), IN `Telefono` VARCHAR(100), IN `Email` VARCHAR(100), IN `Envio_De_Cronogramas_De_Pago` VARCHAR(100), IN `Nombre_De_Empresa` VARCHAR(100), IN `Fecha_De_Ingreso` DATE, IN `Ingreso_Mensual_Neto` DECIMAL(10,2), IN `Cargo` VARCHAR(100), IN `Area_De_Trabajo` VARCHAR(100), IN `Direccion_De_Empresa` VARCHAR(100), IN `Distrito_De_Empresa` VARCHAR(100), IN `Provincia_De_Empresa` VARCHAR(100), IN `Departamento_De_Empresa` VARCHAR(100), IN `Referencia_De_Empresa` VARCHAR(100), IN `Telefono_De_Empresa` VARCHAR(100), IN `Modalidad_De_Contratacion` VARCHAR(100), IN `Centro_De_Trabajo` VARCHAR(100), IN `Monto_Acumulado` DECIMAL(10,2), IN `Nivel` VARCHAR(50), IN `Estado` VARCHAR(50)
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Modify_Datos_Financieros`(
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


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Search_Prestamos
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Search_Prestamos`(IN `Num_Documento_` VARCHAR(50))
BEGIN
SELECT p.Id_Prestamo,p.Id_Socio,p.Monto,p.Num_De_Cuotas,p.Estado,DATE_FORMAT(p.Fecha_De_Registro, "%d-%m-%Y") as Fecha_De_Registro,s.Tipo_De_Documento,s.Num_Documento,s.Apellidos,s.Nombres 
FROM tbl_prestamos as p
INNER JOIN tbl_socios as s ON s.Id_Socio = p.Id_Socio
WHERE p.Estado <> 'RECHAZADO' AND p.Estado <> 'PAGADO' AND s.Num_Documento  LIKE CONCAT('%', Num_Documento_ , '%')  ORDER BY p.Id_Prestamo DESC;

END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Search_Socio_Num_Documento
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Search_Socio_Num_Documento`(IN `Num_Documento_` VARCHAR(50))
BEGIN
SELECT * FROM tbl_socios WHERE Num_Documento LIKE CONCAT('%', Num_Documento_ , '%');
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Cronograma_De_Pago
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Select_Cronograma_De_Pago`(IN `Id_Cronograma_` INT)
BEGIN
SELECT c.Id_Cronograma,c.Id_Prestamo,c.Num_Cuota,DATE_FORMAT(c.Fecha_De_Vencimiento,'%d-%m-%Y') AS Fecha_De_Vencimiento,c.Amortizacion,c.Interes,c.Interes_Diferido,c.Seg_Desgravamen,c.Seg_Multiriesgo,c.ITF,c.Otros,c.Saldo_Capital,c.Cuota_Fija,c.Dias,c.Dias_Acumulados,c.Dias_Morosidad,c.Monto_Morosidad,c.Cuota_Total,c.Fecha_De_Pago,c.Estado FROM tbl_cronograma_de_pagos as c WHERE c.Id_Cronograma = Id_Cronograma_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Datos_Financieros
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Select_Datos_Financieros`(IN `Id_Dato_Financiero_` INT)
BEGIN
SELECT * FROM tbl_datos_financieros WHERE Id_Dato_Financiero = Id_Dato_Financiero_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Prestamo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Select_Prestamo`(
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


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Socio
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Select_Socio`(IN `Id_Socio_` INT)
BEGIN
SELECT * FROM tbl_socios WHERE Id_Socio = Id_Socio_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Socio_Por_Num_Documento
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Select_Socio_Por_Num_Documento`(IN `Tipo_De_Documento_` VARCHAR(100), IN `Num_Documento_` VARCHAR(100)
)
BEGIN
SELECT * FROM tbl_socios WHERE Tipo_De_Documento = Tipo_De_Documento_ AND Num_Documento = Num_Documento_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Cronograma_De_Pagos
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Cronograma_De_Pagos`(IN `Id_Prestamo_` INT)
BEGIN
SELECT * FROM tbl_cronograma_de_pagos WHERE Id_Prestamo = Id_Prestamo_ ORDER BY Num_Cuota ASC;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Datos_Cooperativa
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Datos_Cooperativa`()
BEGIN
SELECT * FROM tbl_datos_de_cooperativa;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Datos_Financieros
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Datos_Financieros`()
BEGIN
SELECT * FROM tbl_datos_financieros;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Dato_Financiero_Activo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Dato_Financiero_Activo`()
BEGIN
SELECT * FROM tbl_datos_financieros WHERE Estado = 'ACTIVO' ORDER BY Id_Dato_Financiero DESC LIMIT 1;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Pagos
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Pagos`()
BEGIN
SELECT p.Id_Pago, 
p.Num_Boleta,
p.Id_Cronograma,
p.Observacion,
p.Tipo_De_Pago,
p.Cuota_Fija,
p.Dias_Morosidad,
p.Monto_Morosidad,
p.Monto_Total,
p.Estado,
p.Id_Usuario,
p.Fecha_De_Registro,
pr.Id_Prestamo,
c.Num_Cuota,
s.Tipo_De_Documento,
s.Num_Documento,
s.Apellidos,
s.Nombres FROM tbl_pagos as p
INNER JOIN tbl_cronograma_de_pagos as c ON c.Id_Cronograma = p.Id_Cronograma
INNER JOIN tbl_prestamos as pr ON pr.Id_Prestamo = c.Id_Prestamo
INNER JOIN tbl_socios as s ON s.Id_Socio = pr.Id_Socio ORDER BY p.Id_Pago DESC;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Prestamos
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Prestamos`()
BEGIN
SELECT p.Id_Prestamo,p.Id_Socio,p.Monto,p.Num_De_Cuotas,p.Estado,DATE_FORMAT(p.Fecha_De_Registro, "%d-%m-%Y") as Fecha_De_Registro,s.Tipo_De_Documento,s.Num_Documento,s.Apellidos,s.Nombres 
FROM tbl_prestamos as p
INNER JOIN tbl_socios as s ON s.Id_Socio = p.Id_Socio
WHERE p.Estado <> 'RECHAZADO' AND p.Estado <> 'PAGADO' ORDER BY p.Id_Prestamo DESC;

END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Socios
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Socios`()
BEGIN
SELECT * FROM tbl_socios;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Update_Cronograma_De_Pago
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Update_Cronograma_De_Pago`(IN `Id_Cronograma_` INT, IN `Dias_Morosidad_` INT, IN `Monto_Morosidad_` DECIMAL(10,2), IN `Cuota_Total_` DECIMAL(10,2), IN `Estado_` VARCHAR(50), IN `Fecha_De_Pago_` DATE)
BEGIN
UPDATE tbl_cronograma_de_pagos SET
Dias_Morosidad = Dias_Morosidad_,
Monto_Morosidad = Monto_Morosidad_,
Cuota_Total = Cuota_Total_,
Fecha_De_Pago = Fecha_De_Pago_,
Estado = Estado_
WHERE Id_Cronograma = Id_Cronograma_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Update_Prestamo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Update_Prestamo`(IN `Id_Prestamo_` INT(11), IN `Monto_` DECIMAL(10,2), IN `Num_De_Cuotas_` INT(11), IN `Observaciones_` VARCHAR(1000), IN `Anexos_` VARCHAR(50), IN `Fecha_De_Desembolso_` DATE, IN `Dias_De_Gracia_` INT(11), IN `Fecha_De_Pago_` DATE, IN `Cuota_Base_` DECIMAL(10,2), IN `Interes_` DECIMAL(10,2), IN `Interes_Diferido_` DECIMAL(10,2), IN `Cuota_Fija_` DECIMAL(10,2), IN `Saldo_Capital_` DECIMAL(10,2), IN `Usuario_Val_` INT(11), IN `Estado_` VARCHAR(50)
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


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Update_Socio
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Update_Socio`(
IN `Id_Socio_` INT,   
IN `Tipo_De_Documento_` VARCHAR(100), 
IN `Num_Documento_` VARCHAR(100), 
IN `Apellidos_` VARCHAR(100), 
IN `Nombres_` VARCHAR(100), 
IN `Fecha_De_Nacimiento_` DATE, 
IN `Sexo_` VARCHAR(50), 
IN `Estado_Civil_` VARCHAR(100), 
IN `Profesion_` VARCHAR(100), 
IN `Nivel_De_Instruccion_` VARCHAR(100), 
IN `Direccion_` VARCHAR(100), 
IN `Distrito_` VARCHAR(100), 
IN `Provincia_` VARCHAR(100), 
IN `Departamento_` VARCHAR(100), 
IN `Referencia_` VARCHAR(100), 
IN `Celular_` VARCHAR(100), 
IN `Telefono_` VARCHAR(100), 
IN `Email_` VARCHAR(100), 
IN `Envio_De_Cronogramas_De_Pago_` VARCHAR(100), 
IN `Nombre_De_Empresa_` VARCHAR(100), 
IN `Fecha_De_Ingreso_` DATE, 
IN `Ingreso_Mensual_Neto_` DECIMAL(10,2), 
IN `Cargo_` VARCHAR(100), 
IN `Area_De_Trabajo_` VARCHAR(100), 
IN `Direccion_De_Empresa_` VARCHAR(100), 
IN `Distrito_De_Empresa_` VARCHAR(100), 
IN `Provincia_De_Empresa_` VARCHAR(100), 
IN `Departamento_De_Empresa_` VARCHAR(100), 
IN `Referencia_De_Empresa_` VARCHAR(100), 
IN `Telefono_De_Empresa_` VARCHAR(100), 
IN `Modalidad_De_Contratacion_` VARCHAR(100), 
IN `Centro_De_Trabajo_` VARCHAR(100), 
IN `Monto_Acumulado_` DECIMAL(10,2), 
IN `Nivel_` VARCHAR(50), 
IN `Estado_` VARCHAR(50),
IN `Fecha_De_Registro_` DATE)
BEGIN
UPDATE tbl_socios SET
Tipo_De_Documento = Tipo_De_Documento_,
Num_Documento = Num_Documento_,
Apellidos = Apellidos_,
Nombres = Nombres_,
Fecha_De_Nacimiento = Fecha_De_Nacimiento_,
Sexo = Sexo_,
Estado_Civil = Estado_Civil_,
Profesion = Profesion_,
Nivel_De_Instruccion = Nivel_De_Instruccion_,
Direccion = Direccion_,
Distrito = Distrito_,
Provincia = Provincia_,
Departamento = Departamento_,
Referencia = Referencia_,
Celular = Celular_,
Telefono = Telefono_,
Email = Email_,
Envio_De_Cronogramas_De_Pago = Envio_De_Cronogramas_De_Pago_,
Nombre_De_Empresa = Nombre_De_Empresa_,
Fecha_De_Ingreso = Fecha_De_Ingreso_,
Ingreso_Mensual_Neto = Ingreso_Mensual_Neto_,
Cargo = Cargo_,
Area_De_Trabajo = Area_De_Trabajo_,
Direccion_De_Empresa = Direccion_De_Empresa_,
Distrito_De_Empresa = Distrito_De_Empresa_,
Provincia_De_Empresa = Provincia_De_Empresa_,
Departamento_De_Empresa = Departamento_De_Empresa_,
Referencia_De_Empresa = Referencia_De_Empresa_,
Telefono_De_Empresa = Telefono_De_Empresa_,
Modalidad_De_Contratacion = Modalidad_De_Contratacion_,
Centro_De_Trabajo = Centro_De_Trabajo_,
Monto_Acumulado = Monto_Acumulado_,
Nivel = Nivel_,
Estado = Estado_,
Fecha_De_Registro = Fecha_De_Registro_ WHERE Id_Socio = Id_Socio_;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Validar_Prestamo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Validar_Prestamo`(IN `Tipo_De_Documento_` VARCHAR(50), IN `Num_Documento_` VARCHAR(50))
BEGIN
SELECT p.Id_Prestamo FROM tbl_prestamos as p
INNER JOIN tbl_socios as s ON s.Id_Socio = p.Id_Socio 
WHERE p.Estado <> 'RECHAZADO' AND p.Estado <> 'PAGADO'  AND  s.Tipo_De_Documento = Tipo_De_Documento_ AND s.Num_Documento = Num_Documento_;
END//
DELIMITER ;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
