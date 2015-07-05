create proc Eliminar_Venta
@ID_Venta int
as
delete from Ventas where ID_Venta=@ID_Venta
go