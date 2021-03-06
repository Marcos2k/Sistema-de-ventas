USE [SisVentas]
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Detalle_Venta]    Script Date: 03/31/2014 15:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Mostrar_Detalle_Venta]
as
SELECT     dbo.Detalle_venta.ID_Detalle, dbo.Detalle_venta.ID_Venta, dbo.Detalle_venta.ID_Producto, dbo.Producto.Nombre, dbo.Detalle_venta.Cantidad, 
                      dbo.Detalle_venta.Precio_unitario
FROM         dbo.Detalle_venta INNER JOIN
                      dbo.Producto ON dbo.Detalle_venta.ID_Producto = dbo.Producto.ID_Producto
                       order by ID_Detalle desc
