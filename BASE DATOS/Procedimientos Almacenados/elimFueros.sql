CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFueros`(
	in fIdF int(11)
)
BEGIN
	DELETE FROM Fueros WHERE idFueros = fIdF;
END
