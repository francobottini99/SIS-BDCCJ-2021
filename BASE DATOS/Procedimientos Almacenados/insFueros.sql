CREATE DEFINER=`root`@`localhost` PROCEDURE `insFueros`(
	in fTip varchar(150)
    )
BEGIN
	INSERT INTO Fueros (
		TipoFuero
)
	VALUES (fTip);
END