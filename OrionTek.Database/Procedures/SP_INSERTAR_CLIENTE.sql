IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INSERTAR_CLIENTE]') AND type in (N'P', N'PC'))
BEGIN	
	DROP PROCEDURE [dbo].[SP_INSERTAR_CLIENTE]
END

GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_CLIENTE]
(	
	@Empresa		INT,
	@Nombres		NVARCHAR(50) = NULL,
	@Apellidos		NVARCHAR(50) = NULL
)
AS
BEGIN
	INSERT INTO Clientes(Empresa, Nombres, Apellidos)
	VALUES (@Empresa, @Nombres, @Apellidos);
END;