CREATE DEFINER=`root`@`localhost` PROCEDURE `insCamara`(
	in cNom varchar(255),
    in cDir varchar(255),
    in cLoc varchar(255),
    in cCod varchar(50),
    in cPro varchar(50)
    )
BEGIN
	INSERT INTO Camara (
		NombreCamara,
        Direccion,
        Localidad,
        CP,
        Provincia
)
	VALUES (cNom, cDir, cLoc, cCod, cPro);
END