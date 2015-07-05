create proc Eliminar_Producto
@ID_Producto int
as
delete from Producto where ID_Producto=@ID_Producto
go