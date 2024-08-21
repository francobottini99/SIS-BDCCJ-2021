CREATE DEFINER=`root`@`localhost` PROCEDURE `verCasos`(
)
BEGIN
	SELECT
		Casos.idCasos,
        Casos.Instancia,
        Casos.Causa,
        Casos.Caratula,
        Casos.NumeroExpediente,
        Casos.HechosOrigen,
        Casos.FechaPublicacion,
        Casos.LinkCausa,
        Fueros.idFueros,
        Fueros.TipoFuero,
        Tipos.idTipos,
        Tipos.DetalleTipo
	FROM
		Casos JOIN Fueros ON Fueros.idFueros = Casos.Fueros_idFueros
			  JOIN Tipos ON Tipos.idTipos = Casos.Tipos_idTipos;
END