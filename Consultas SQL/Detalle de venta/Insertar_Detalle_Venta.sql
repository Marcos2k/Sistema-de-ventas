create proc Insertar_Detalle_Venta
@ID_Venta int,
@ID_Producto int,
@Cantidad decimal(18,2),
@Precio_unitario decimal(18,2)
as
insert into Detalle_venta(ID_Venta,ID_Producto,Cantidad,Precio_unitario)
values(@ID_Venta,@ID_Producto,@Cantidad,@Precio_unitario)
go
