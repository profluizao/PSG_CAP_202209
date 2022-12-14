CREATE TABLE Municipio(
	CodigoMunicipio INT NOT NULL,
	NomeMunicipio VARCHAR(MAX) NOT NULL,
	CodigoIBGE6 INT NOT NULL,
	CodigoIBGE7 INT NOT NULL,
	CEP INT NOT NULL,
	CodigoUF INT NOT NULL,
	SiglaUF CHAR(2) NOT NULL,
	Regiao VARCHAR(255) NOT NULL,
	Populacao INT NULL,
	Porte VARCHAR(255) NULL,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	CONSTRAINT PK_Municipio PRIMARY KEY (CodigoMunicipio),
	CONSTRAINT FK_Municipio_Estado FOREIGN KEY (CodigoUF) REFERENCES Estado(CodigoUF)
)
