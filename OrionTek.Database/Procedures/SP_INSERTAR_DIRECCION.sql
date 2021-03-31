IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INSERTAR_DIRECCION]') AND type in (N'P', N'PC'))
BEGIN	
	DROP PROCEDURE [dbo].[SP_INSERTAR_DIRECCION]
END

GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_DIRECCION]
(
	@Cliente		INT,
	@Calle			NVARCHAR(50) = NULL,
	@Numero			NVARCHAR(50) = NULL,
	@Apartamento	NVARCHAR(50) = NULL,
	@Referencia		NVARCHAR(50) = NULL,
	@Sector			NVARCHAR(50) = NULL
)
AS
BEGIN
	INSERT INTO Direcciones(Cliente, Calle, Numero, Apartamento, Referencia, Sector)
	VALUES (@Cliente, @Calle, @Numero, @Apartamento, @Referencia, @Sector);
END;