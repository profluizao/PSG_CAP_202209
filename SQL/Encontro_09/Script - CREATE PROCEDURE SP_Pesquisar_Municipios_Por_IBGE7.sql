--DECLARE @CODIGO INT
--SET @CODIGO = 3527801
--SELECT CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
--FROM VW_Municipios_IBGE
--WHERE (CodigoIBGE7 = @CODIGO)
--GO

--CREATE PROCEDURE SP_Pesquisar_Municipios_Por_IBGE7
--@CODIGO CHAR(7)
--AS
--BEGIN
--	SELECT CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
--	FROM VW_Municipios_IBGE
--	WHERE (CodigoIBGE7 = @CODIGO)
--END
--GO

--EXEC DBO.SP_Pesquisar_Municipios_Por_IBGE7 '3527801'
--GO

ALTER PROCEDURE DBO.SP_Pesquisar_Municipios_Por_IBGE7
@CODIGO INT
AS BEGIN
	SELECT CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
	FROM VW_Municipios_IBGE
	WHERE (CodigoIBGE7 = @CODIGO)
END
GO

EXEC DBO.SP_Pesquisar_Municipios_Por_IBGE7 3527801
GO
