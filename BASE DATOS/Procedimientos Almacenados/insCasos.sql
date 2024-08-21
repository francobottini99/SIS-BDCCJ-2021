CREATE DEFINER=`root`@`localhost` PROCEDURE `insCasos`(
	in cIns varchar(255),
    in cCau varchar(255),
    in cCar varchar(255),
    in cNum varchar(100),
    in cHec mediumtext,
    in cFec date,
    in cLin varchar(255),
    in cIdF int,
    in cIdT int
    )
BEGIN
	INSERT INTO Casos (
		Instancia,
        Causa,
        Caratula,
        NumeroExpediente,
        HechosOrigen,
        FechaPublicacion,
        LinkCausa,
        Fueros_idFueros,
        Tipos_idTipos
)
	VALUES (cIns, cCau, cCar, cNum, cHec, cFec, cLin, cIdF, cIdT);
END