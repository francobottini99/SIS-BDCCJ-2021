CREATE DEFINER=`root`@`localhost` PROCEDURE `modTribunal`(
	in tIdT int(11),
	in tNom varchar(255),
    in tDir varchar(255),
    in tLoc varchar(255),
    in tCod varchar(50),
    in tPro varchar(50)
)
BEGIN
	UPDATE Tribunal
	SET 
		NombreTribunal = tNom,
        Direccion = tDir,
        Localidad = tLoc,
        CP = tCod,
        Provincia = tPro
	WHERE 
		idTribunal = tIdT;
END