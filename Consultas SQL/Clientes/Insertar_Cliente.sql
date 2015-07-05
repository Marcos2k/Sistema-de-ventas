create proc Insertar_Cliente
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(50),
@Telefono varchar(10),
@Dni varchar(8)
as
insert into Cliente (Nombre,Apellido,Direccion,Telefono,Dni) values (@Nombre,@Apellido,@Direccion,@Telefono,@Dni)
go
