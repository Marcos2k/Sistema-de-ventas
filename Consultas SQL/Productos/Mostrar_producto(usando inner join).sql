create proc Mostrar_producto
as
select Producto.ID_Producto,Producto.ID_Categoria,Categoria.Nombre_Categoria,
Producto.Nombre,Producto.Descripcion,Producto.Stock,Producto.Precio_compra,Producto.Precio_venta,
Producto.Fecha_vencimiento,Producto.Imagen
from Producto inner join Categoria on Producto.ID_Categoria=Categoria.ID_Categoria
order by Producto.ID_Categoria desc

