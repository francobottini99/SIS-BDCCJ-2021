CREATE DEFINER=`root`@`localhost` PROCEDURE `verCamara`(
)
BEGIN
	SELECT
		*
	FROM
		Camara;
END