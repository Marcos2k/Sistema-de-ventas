create proc Eliminar_Cliente
@ID_Cliente integer
as
Delete from Cliente where ID_Cliente=@ID_Cliente
go