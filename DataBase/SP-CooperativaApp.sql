-- Procedimientos Almacenodos
DELIMITER $$

-- SP AGREGAR DATO FINANCIERO
CREATE PROCEDURE USP_Add_Datos_Financieros
(
	TEA DECIMAL(10,2),
	TEM DECIMAL(10,2),
	TED DECIMAL(10,2),
	Seguro_Desgravamen DECIMAL(10,2),
	ITF DECIMAL(10,2),
	Otros DECIMAL(10,2),
	Estado INT
)
BEGIN
INSERT INTO tbl_datos_financieros(TEA,TEM,TED,Seguro_Desgravamen,ITF,Otros,Estado,Fecha_Registro) VALUES(TEA,TEM,TED,Seguro_Desgravamen,ITF,Otros,Estado,CURRENT_DATE());
END$$


-- SP EDITAR DATO FINANCIERO
CREATE PROCEDURE USP_Modify_Datos_Financieros
(
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
END$$

-- SP LISTAR DATOS FINANCIEROS
CREATE PROCEDURE USP_ToList_Datos_Financieros()
BEGIN
SELECT * FROM tbl_datos_financieros;
END$$

-- SP SELECCIONAR DATO FINANCIERO
CREATE PROCEDURE USP_Select_Datos_Financieros(ID INT)
BEGIN
SELECT * FROM tbl_datos_financieros WHERE Id_Dato_Financiero = ID;
END$$

DELIMITER ;




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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_cronograma_de_pagos: ~0 rows (aproximadamente)
DELETE FROM `tbl_cronograma_de_pagos`;
/*!40000 ALTER TABLE `tbl_cronograma_de_pagos` DISABLE KEYS */;
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
  `TEA` double DEFAULT NULL,
  `TEM` double DEFAULT NULL,
  `TED` double DEFAULT NULL,
  `Seguro_Desgravamen` double DEFAULT NULL,
  `Seguro_Multiriesgo` double DEFAULT NULL,
  `ITF` double DEFAULT NULL,
  `Otros` double DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Fecha_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Dato_Financiero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_datos_financieros: ~2 rows (aproximadamente)
DELETE FROM `tbl_datos_financieros`;
/*!40000 ALTER TABLE `tbl_datos_financieros` DISABLE KEYS */;
INSERT INTO `tbl_datos_financieros` (`Id_Dato_Financiero`, `TEA`, `TEM`, `TED`, `Seguro_Desgravamen`, `Seguro_Multiriesgo`, `ITF`, `Otros`, `Estado`, `Fecha_Registro`) VALUES
	(1, 12.2, 2, 2, 2, 2, 2, 2, '2', '2018-11-22'),
	(2, 3.33333333333333, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
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
  `Monto` decimal(10,2) DEFAULT NULL,
  `Num_De_Cuotas` int(11) DEFAULT NULL,
  `Observaciones` varchar(50) DEFAULT NULL,
  `Anexos` varchar(50) DEFAULT NULL,
  `Id_Dato_Financiero` int(11) DEFAULT NULL,
  `Fecha_De_Desembolso` date DEFAULT NULL,
  `Dias_De_Gracia` int(11) DEFAULT NULL,
  `Fecha_De_Pago` date DEFAULT NULL,
  `Cuota_Base` decimal(10,2) DEFAULT NULL,
  `Interes` decimal(10,2) DEFAULT NULL,
  `Interes_Diferido` decimal(10,2) DEFAULT NULL,
  `Cuota_Fija` decimal(10,2) DEFAULT NULL,
  `Saldo_Capital` decimal(10,2) DEFAULT NULL,
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_prestamos: ~0 rows (aproximadamente)
DELETE FROM `tbl_prestamos`;
/*!40000 ALTER TABLE `tbl_prestamos` DISABLE KEYS */;
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
  `Tipo_De_Documento` varchar(100) DEFAULT NULL,
  `Num_Documento` varchar(100) DEFAULT NULL,
  `Apellidos` varchar(100) DEFAULT NULL,
  `Nombres` varchar(100) DEFAULT NULL,
  `Fecha_De_Nacimiento` date DEFAULT NULL,
  `Sexo` varchar(50) DEFAULT NULL,
  `Estado_Civil` varchar(100) DEFAULT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Distrito` varchar(100) DEFAULT NULL,
  `Provincia` varchar(100) DEFAULT NULL,
  `Departamento` varchar(100) DEFAULT NULL,
  `Referencia` varchar(100) DEFAULT NULL,
  `Celular` varchar(100) DEFAULT NULL,
  `Telefono` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Envio_De_Cronogramas_De_Pago` varchar(100) DEFAULT NULL,
  `Nombre_De_Empresa` varchar(100) DEFAULT NULL,
  `Fecha_De_Ingreso` date DEFAULT NULL,
  `Ingreso_Mensual_Neto` decimal(10,2) DEFAULT NULL,
  `Cargo` varchar(100) DEFAULT NULL,
  `Area_De_Trabajo` varchar(100) DEFAULT NULL,
  `Direccion_De_Empresa` varchar(100) DEFAULT NULL,
  `Distrito_De_Empresa` varchar(100) DEFAULT NULL,
  `Provincia_De_Empresa` varchar(100) DEFAULT NULL,
  `Departamento_De_Empresa` varchar(100) DEFAULT NULL,
  `Referencia_De_Empresa` varchar(100) DEFAULT NULL,
  `Telefono_De_Empresa` varchar(100) DEFAULT NULL,
  `Modalidad_De_Contratacion` varchar(100) DEFAULT NULL,
  `Centro_De_Trabajo` varchar(100) DEFAULT NULL,
  `Monto_Acumulado` decimal(10,2) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Fecha_De_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Socio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_socios: ~0 rows (aproximadamente)
DELETE FROM `tbl_socios`;
/*!40000 ALTER TABLE `tbl_socios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_socios` ENABLE KEYS */;


-- Volcando estructura para tabla bd_cooperativa_app.tbl_tipo_de_usuario
CREATE TABLE IF NOT EXISTS `tbl_tipo_de_usuario` (
  `Id_Tipo_De_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Estado` int(11) NOT NULL,
  `Fecha_registro` date NOT NULL,
  PRIMARY KEY (`Id_Tipo_De_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_tipo_de_usuario: ~0 rows (aproximadamente)
DELETE FROM `tbl_tipo_de_usuario`;
/*!40000 ALTER TABLE `tbl_tipo_de_usuario` DISABLE KEYS */;
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
  `Estado` int(11) DEFAULT NULL,
  `Fecha_Registro` date DEFAULT NULL,
  PRIMARY KEY (`Id_Usuario`),
  KEY `fk_Id_Tipo_De_Usuario_U` (`Id_Tipo_De_Usuario`),
  CONSTRAINT `fk_Id_Tipo_De_Usuario_U` FOREIGN KEY (`Id_Tipo_De_Usuario`) REFERENCES `tbl_tipo_de_usuario` (`Id_Tipo_De_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_cooperativa_app.tbl_usuarios: ~0 rows (aproximadamente)
DELETE FROM `tbl_usuarios`;
/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;


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


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_Select_Datos_Financieros
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_Select_Datos_Financieros`(ID INT)
BEGIN
SELECT * FROM tbl_datos_financieros WHERE Id_Dato_Financiero = ID;
END//
DELIMITER ;


-- Volcando estructura para procedimiento bd_cooperativa_app.USP_ToList_Datos_Financieros
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ToList_Datos_Financieros`()
BEGIN
SELECT * FROM tbl_datos_financieros;
END//
DELIMITER ;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

