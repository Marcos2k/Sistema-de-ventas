create proc Editar_Producto
@ID_Producto int,
@ID_Categoria int,
@Nombre varchar(50),
@Descripcion varchar(255),
@Stock decimal(18,2),
@Precio_compra decimal(18,2),
@Precio_venta decimal(18,2),
@Fecha_vencimiento date,
@Imagen image
as 
update Producto set ID_Categoria=@ID_Categoria,Nombre=@Nombre,Descripcion=@Descripcion,
Stock=@Stock,Precio_compra=@Precio_compra,Precio_venta=@Precio_venta,
Fecha_vencimiento=@Fecha_vencimiento,Imagen=@Imagen 
where ID_Producto=@ID_Producto
go