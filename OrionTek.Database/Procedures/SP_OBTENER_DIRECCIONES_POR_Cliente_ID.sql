IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_OBTENER_CLIENTES_POR_EMPRESA_ID]') AND type in (N'P', N'PC'))
BEGIN	
	DROP PROCEDURE [dbo].[SP_OBTENER_CLIENTES_POR_EMPRESA_ID]
END

GO

CREATE PROCEDURE [dbo].[SP_OBTENER_DIRECCIONES_POR_Cliente_ID]
(	
	@Cliente		INT
)
AS
BEGIN
	SELECT Id, Cliente, Calle, Numero, Apartamento, Referencia, Sector
	FROM Direcciones
	WHERE Cliente = @Cliente;
END;