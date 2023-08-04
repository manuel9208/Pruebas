USE [sistemasdb]
GO

/****** Object:  StoredProcedure [dbo].[SPC01_InvPolizasProceso]    Script Date: 03/08/2023 03:41:06 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Manuel Jacobo>
-- Create date: <20230802>
-- Description:	<Proceso de InvDePolzias>
-- =============================================
CREATE PROCEDURE [dbo].[SPC01_InvPolizasProceso] @Opcion INT, @AsiEmpleado INT, @AsiSku INT, @CantidadDes INT, @FechaCreo DATE, @IDPoliza INT
AS
BEGIN
	
	DECLARE @Empleado NVARCHAR(45)
	
	IF @Opcion = 1
	BEGIN
		SELECT IdEmpleado,Nombres +' '+ Apellido_Paterno +' '+ Apellido_Materno AS NombreEmpleado FROM InvEmpleados
	END
	IF @Opcion = 2
	BEGIN
		SELECT Sku,Nombre,Cantidad FROM InvInventario
	END
	IF @Opcion = 3
	BEGIN
		SELECT ISNULL(MAX(IDPoliza)+1,1)IDPoliza FROM InvPoliza
	END
	IF @Opcion = 4
	BEGIN
		SELECT IDPoliza,Empleado,IDSku,Cantidad,Fecha FROM InvPoliza
	END
	IF @Opcion = 5
	BEGIN
		SELECT Sku,Nombre,Cantidad FROM InvInventario WHERE Sku = @AsiSku
	END
	IF @Opcion = 6
	BEGIN
		
		SET @Empleado = (SELECT Nombres +' '+ Apellido_Paterno +' '+ Apellido_Materno FROM InvEmpleados WHERE IdEmpleado = @AsiEmpleado)

		INSERT INTO InvPoliza (Empleado,IDSku,Cantidad,Fecha) VALUES (@Empleado,@AsiSku,@CantidadDes,@FechaCreo)

		UPDATE InvInventario SET Cantidad = Cantidad - @CantidadDes WHERE Sku = @AsiSku
	END
	IF @Opcion = 7
	BEGIN
		SELECT Cantidad AS CantidadA,@CantidadDes AS CantidadR  FROM InvInventario WHERE Sku = @AsiSku
	END
	IF @Opcion = 8
	BEGIN
		DELETE FROM InvPoliza WHERE IDPoliza = @IDPoliza
	END
	IF @Opcion = 9
	BEGIN
		SELECT * FROM InvPoliza WHERE IDPoliza = @IDPoliza
	END
END

GO


