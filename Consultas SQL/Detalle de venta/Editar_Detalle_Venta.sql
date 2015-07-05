create proc  Editar_Detalle_Venta
@ID_Detalle int,
@ID_Venta int,
@ID_Producto int,
@Cantidad decimal(18,2),
@Precio_unitario decimal(18,2)
as
update Detalle_venta set ID_Venta=@ID_Venta,ID_Producto=@ID_Producto,Cantidad=@Cantidad,
Precio_unitario=@Precio_unitario where ID_Detalle=@ID_Detalle
go