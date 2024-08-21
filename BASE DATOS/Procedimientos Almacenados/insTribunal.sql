CREATE DEFINER=`root`@`localhost` PROCEDURE `insTribunal`(
	in tNom varchar(255),
    in tDir varchar(255),
    in tLoc varchar(255),
    in tCod varchar(50),
    in tPro varchar(50)
    )
BEGIN
	INSERT INTO Tribunal (
		NombreTribunal,
        Direccion,
        Localidad,
        CP,
        Provincia
)
	VALUES (tNom, tDir, tLoc, tCod, tPro);
END