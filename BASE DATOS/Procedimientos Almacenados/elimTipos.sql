CREATE DEFINER=`root`@`localhost` PROCEDURE `elimTipos`(
	in tIdT int(11)
)
BEGIN
	DELETE FROM Tipos WHERE idTipos = tIdT;
END