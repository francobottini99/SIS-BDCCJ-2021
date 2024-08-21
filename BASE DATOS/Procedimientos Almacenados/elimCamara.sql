CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCamara`(
	in cIdC int(11)
)
BEGIN
	DELETE FROM Camara WHERE idCamara = cIdC;
END
