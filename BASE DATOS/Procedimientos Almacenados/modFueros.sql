CREATE DEFINER=`root`@`localhost` PROCEDURE `modFueros`(
	in fIdF int(11),
	in fTip varchar(150)
)
BEGIN
	UPDATE Fueros
	SET 
		TipoFuero = fTip
	WHERE 
		idFueros = fIdF;
END