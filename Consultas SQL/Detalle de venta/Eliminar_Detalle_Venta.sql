create proc Eliminar_Detalle_Venta
@ID_Detalle int
as
Delete from Detalle_venta where ID_Detalle=@ID_Detalle
go