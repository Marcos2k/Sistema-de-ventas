create proc Generar_Comprobante
@ID_Venta int
as
SELECT     dbo.Ventas.ID_Venta, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.Cliente.Dni, dbo.Ventas.Fecha_Venta, dbo.Ventas.Tipo_Documento, dbo.Ventas.Nro_Documento, 
                      dbo.Producto.Nombre AS Descripcion, dbo.Detalle_venta.Cantidad, dbo.Detalle_venta.Precio_unitario, 
                      dbo.Detalle_venta.Cantidad * dbo.Detalle_venta.Precio_unitario AS Total_parcial
FROM         dbo.Ventas INNER JOIN
                      dbo.Detalle_venta ON dbo.Ventas.ID_Venta = dbo.Detalle_venta.ID_Venta INNER JOIN
                      dbo.Producto ON dbo.Detalle_venta.ID_Producto = dbo.Producto.ID_Producto INNER JOIN
                      dbo.Cliente ON dbo.Ventas.ID_Cliente = dbo.Cliente.ID_Cliente
                      WHERE Ventas.ID_Venta=@ID_Venta 
                      go
