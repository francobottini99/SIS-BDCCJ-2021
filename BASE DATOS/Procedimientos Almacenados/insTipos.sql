CREATE DEFINER=`root`@`localhost` PROCEDURE `insTipos`(
	in tDet varchar(150)
    )
BEGIN
	INSERT INTO Tipos (
		DetalleTipo
)
	VALUES (tDet);
END