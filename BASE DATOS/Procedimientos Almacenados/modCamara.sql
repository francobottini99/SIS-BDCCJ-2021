CREATE DEFINER=`root`@`localhost` PROCEDURE `modCamara`(
	in cIdC int(11),
	in cNom varchar(255),
    in cDir varchar(255),
    in cLoc varchar(255),
    in cCod varchar(50),
    in cPro varchar(50)
)
BEGIN
	UPDATE Camara
	SET 
		NombreCamara = cNom,
        Direccion = cDir,
        Localidad = cLoc,
        CP = cCod,
        Provincia = cPro
	WHERE 
		idCamara = cIdC;
END