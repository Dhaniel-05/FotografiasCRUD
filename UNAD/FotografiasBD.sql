Use FotografiasEvento

CREATE TABLE Fotografias (
	IdFotografias INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Foto VARBINARY (MAX) NULL,
	DescripcionImagen VARCHAR (100) UNIQUE NOT NULL,
	FechaEvento DATE NULL,
	Lugar VARCHAR (100) NULL,
	DescripcionEvento VARCHAR (500) NULL
	);
GO

----CONSULTAS-----

Select * From Fotografias

SELECT IdFotografias, Foto, DescripcionImagen, FechaEvento, Lugar, DescripcionEvento FROM Fotografias WHERE IdFotografias = 2

GO
