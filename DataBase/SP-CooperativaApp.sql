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