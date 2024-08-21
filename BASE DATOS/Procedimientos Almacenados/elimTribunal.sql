CREATE DEFINER=`root`@`localhost` PROCEDURE `elimTribunal`(
	in tIdT int(11)
)
BEGIN
	DELETE FROM Tribunal WHERE idTribunal = tIdT;
END