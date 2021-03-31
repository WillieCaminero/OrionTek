﻿IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INSERTAR_EMPRESA]') AND type in (N'P', N'PC'))
BEGIN	
	DROP PROCEDURE [dbo].[SP_INSERTAR_EMPRESA]
END

GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_EMPRESA]
(	
	@Empresa		NVARCHAR(50) = NULL
)
AS
BEGIN
	INSERT INTO Empresas(Empresa) VALUES (@Empresa);
END;