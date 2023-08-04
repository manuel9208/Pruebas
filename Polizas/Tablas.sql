Create table InvEmpleados (
IdEmpleado int identity (1,1),
Nombres NVARCHAR (30),
Apellido_Paterno NVARCHAR (30),
Apellido_Materno NVARCHAR (30),
Puesto NVARCHAR (30)
)

Create table InvPuesto (
IdPuesto int identity (0,1),
Puesto NVARCHAR (30) Primary key,
)

INSERT INTO InvPuesto (Puesto) VALUES ('Desarrollador')
INSERT INTO InvPuesto (Puesto) VALUES ('Arquitecto')
INSERT INTO InvPuesto (Puesto) VALUES ('Lider')

Create table InvInventario (
Sku int identity (0,1),
Nombre NVARCHAR (30) Primary key,
Cantidad INT ,
)

Create table InvPoliza (
IDPoliza int identity (0,1),
Empleado NVARCHAR (30),
IDSku INT ,
Cantidad INT,
Fecha Date
)
