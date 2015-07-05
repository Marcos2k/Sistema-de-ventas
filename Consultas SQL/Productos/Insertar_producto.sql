create proc Insertar_Producto
@ID_Categoria int,
@Nombre varchar(50),
@Descripcion varchar(255),
@Stock decimal(18,2),
@Precio_Compra decimal(18,2),
@Precio_Venta decimal(18,2),
@Fecha_vencimiento date,
@Imagen image
as
insert into Producto(ID_Categoria,Nombre,Descripcion,Stock,Precio_compra,Precio_venta,
Fecha_vencimiento,Imagen) values(@ID_Categoria,@Nombre,@Descripcion,@Stock,@Precio_Compra,
@Precio_Venta,@Fecha_vencimiento,@Imagen)
go