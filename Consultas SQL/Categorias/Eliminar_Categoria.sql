create proc Eliminar_Categoria
@ID_Categoria integer
as
Delete from Categoria where ID_Categoria=@ID_Categoria
go