USE [sistemasdb]
GO
/****** Object:  StoredProcedure [dbo].[SPC01_InvPolizas]    Script Date: 04/08/2023 11:12:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Manuel Jacobo
-- Create date: <2023/08/02>
-- Description:	<Sistema InvPolizas>
-- =============================================
CREATE PROCEDURE [dbo].[SPC01_InvPolizas] @opcion int, @IdEmpleado Int, @NoEmpleado NVARCHAR(30), @APaterno NVARCHAR(30), @AMaterno NVARCHAR(30), @Puesto NVARCHAR(30), @IDSku INT, @InvNombre NVARCHAR(30), @Cantidad INT
AS
BEGIN
	IF @opcion = 1
	BEGIN
		INSERT INTO InvEmpleados (Nombres,Apellido_Paterno,Apellido_Materno,Puesto) VALUES (@NoEmpleado,@APaterno,@AMaterno,@Puesto)
	END
	IF @opcion = 2
	BEGIN
		SELECT * FROM InvPuesto
	END
	IF @opcion = 3
	BEGIN
		SELECT ISNULL(MAX(IdEmpleado)+1,1)IdEmpleado FROM InvEmpleados
	END
	IF @opcion = 4
	BEGIN
		SELECT IdEmpleado,Nombres,Apellido_Paterno,Apellido_Materno,Puesto FROM InvEmpleados WHERE Nombres=@NoEmpleado AND Apellido_Paterno=@APaterno  AND Apellido_Materno=@AMaterno AND Puesto=@Puesto
	END
	IF @opcion = 5
	BEGIN
		DELETE FROM InvEmpleados WHERE Nombres=@NoEmpleado AND Apellido_Paterno=@APaterno  AND Apellido_Materno=@AMaterno AND Puesto=@Puesto
	END
	IF @opcion = 6
	BEGIN
		UPDATE InvEmpleados SET Nombres=@NoEmpleado, Apellido_Paterno=@APaterno, Apellido_Materno=@AMaterno, Puesto=@Puesto  WHERE IdEmpleado=@NoEmpleado
	END
	IF @opcion = 7
	BEGIN
		INSERT INTO InvInventario (Nombre,Cantidad) VALUES (@InvNombre,@Cantidad)
	END
	IF @opcion = 8
	BEGIN
		SELECT ISNULL(MAX(Sku)+1,1)IDSku FROM InvInventario
	END
	IF @opcion = 9
	BEGIN
		SELECT Sku,Nombre,Cantidad FROM InvInventario WHERE NOMBRE=@InvNombre
	END
	IF @opcion = 10
	BEGIN
		DELETE FROM InvInventario WHERE SKU=@IDSku AND NOMBRE=@InvNombre
	END
	IF @opcion = 11
	BEGIN
		UPDATE InvInventario SET Cantidad=@Cantidad WHERE SKU=@IDSku AND NOMBRE=@InvNombre
	END
	IF @opcion = 12
	BEGIN
		SELECT Sku,Nombre,Cantidad FROM InvInventario
	END
	IF @opcion = 13
	BEGIN
		SELECT IdEmpleado,Nombres,Apellido_Paterno,Apellido_Materno,Puesto FROM InvEmpleados
	END
END
