CREATE DEFINER=`root`@`localhost` PROCEDURE `modCasos`(
	in cIdC int(11),
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
	UPDATE Casos
	SET 
		Instancia = cIns,
        Causa = cCau,
        Caratula = cCar,
        NumeroExpediente = cNum,
        HechosOrigen = cHec,
        FechaPublicacion = cFec,
        LinkCausa = cLin,
        Fueros_idFueros = cIdF,
        Tipos_idTipos = cIdT
	WHERE 
		idCasos = cIdC;
END