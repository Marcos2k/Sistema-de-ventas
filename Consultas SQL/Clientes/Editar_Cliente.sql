create proc Editar_Cliente
@ID_Cliente integer,
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(100),
@Telefono varchar(10),
@Dni varchar(8)
as
Update Cliente set Nombre=@Nombre,Apellido=@Apellido,Direccion=@Direccion,Telefono=@Telefono,Dni=@Dni where ID_Cliente=@ID_Cliente
go
