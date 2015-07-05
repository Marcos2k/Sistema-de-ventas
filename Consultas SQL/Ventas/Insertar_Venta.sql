create proc Insertar_Venta
@ID_Cliente int,
@Fecha_venta date,
@Tipo_Documento varchar(50),
@Nro_Documento varchar(50)
As
insert into Ventas(ID_Cliente,Fecha_Venta,Tipo_Documento,Nro_Documento)
values (@ID_Cliente,@Fecha_venta,@Tipo_Documento,@Nro_Documento)
go