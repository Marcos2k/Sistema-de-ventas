create proc Aumentar_Stock
@ID_Producto int,
@Cantidad decimal(18,2)
as                /**Incrementa el stock al actual**/
update Producto set Stock=Stock+@Cantidad where ID_Producto=@ID_Producto
go