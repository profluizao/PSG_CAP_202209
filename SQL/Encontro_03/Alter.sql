ALTER TABLE Categoria
	--ADD DataInsert DATETIME NOT NULL DEFAULT GETDATE()
	ADD CONSTRAINT DF_DATAINSERT
		DEFAULT GETDATE() FOR DataInsert
GO
