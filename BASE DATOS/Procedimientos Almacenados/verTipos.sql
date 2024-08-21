CREATE DEFINER=`root`@`localhost` PROCEDURE `verTipos`(
)
BEGIN
	SELECT
		*
	FROM
		Tipos;
END
