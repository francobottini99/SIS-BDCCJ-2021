CREATE DEFINER=`root`@`localhost` PROCEDURE `verFueros`(
)
BEGIN
	SELECT
		*
	FROM
		Fueros;
END
