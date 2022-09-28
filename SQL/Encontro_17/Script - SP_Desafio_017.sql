DECLARE @ListaNomes TABLE(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
)

INSERT INTO @ListaNomes VALUES 
('Akira'),
('Ad�o'),
('Jo�o'),
('Jos�'),
('Rafael'),
('Rafaela'),
('Bruno'),
('Bruna'),
('Thiago'),
('Manoel'),
('Manoela'),
('Joana'),
('Paulo'),
('Paula'),
('Paolo'),
('Paola'),
('Marlon'),
('Marlene'),
('Larissa'),
('Iami'),
('Yumi')

DECLARE @ListaSorteados TABLE(
	Id INT NOT NULL PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
)

DECLARE @Contador INT
SET @Contador = 0

DECLARE @QtdSorteios INT
SET @QtdSorteios = 0

WHILE (@Contador < 4)
BEGIN
	DECLARE @Registros INT 
	SELECT @Registros = COUNT(*) FROM @ListaNomes

	DECLARE @Chave INT 
	SET @Chave = FLOOR(RAND() * (@Registros + 1))
	SET @QtdSorteios = @QtdSorteios + 1

	WHILE (@Chave = 0)
	BEGIN
		SET @Chave = FLOOR(RAND() * (@Registros + 1))
		SET @QtdSorteios = @QtdSorteios + 1
	END

	IF ((SELECT COUNT(*) FROM @ListaSorteados) = 0)
	BEGIN
		INSERT INTO @ListaSorteados(Id, Nome)
			SELECT Id, Nome FROM @ListaNomes WHERE Id = @Chave
		SET @Contador = @Contador + 1
	END
	ELSE
	BEGIN
		IF ((SELECT COUNT(*) FROM @ListaSorteados WHERE Id = @Chave) = 0)
		BEGIN
			INSERT INTO @ListaSorteados(Id, Nome)
				SELECT Id, Nome FROM @ListaNomes WHERE Id = @Chave
			SET @Contador = @Contador + 1
		END
	END
END

SELECT @QtdSorteios AS [Qtd Sorteios]
SELECT * FROM @ListaSorteados
GO

