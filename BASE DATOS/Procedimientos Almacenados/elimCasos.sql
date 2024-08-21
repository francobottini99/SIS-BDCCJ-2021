CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCasos`(
	in cIdC int(11)
)
BEGIN
	DELETE FROM Casos WHERE idCasos = cIdC;
END