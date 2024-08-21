CREATE DEFINER=`root`@`localhost` PROCEDURE `modTipos`(
	in tIdT int(11),
	in tDet varchar(255)
)
BEGIN
	UPDATE Tipos
	SET 
		DetalleTipo = tDet
	WHERE 
		idTipos = tIdT;
END