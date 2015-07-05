create proc Editar_Venta
@ID_Venta int,
@ID_Cliente int,
@Fecha_venta date,
@Tipo_Documento varchar(50),
@Nro_Documento varchar(50)
as 
update Ventas set ID_Cliente=@ID_Cliente,Fecha_Venta=@Fecha_venta,Tipo_Documento=@Tipo_Documento,
Nro_Documento=@Nro_Documento where ID_Venta=@ID_Venta
go