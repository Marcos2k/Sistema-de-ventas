create proc Editar_Categoria
@ID_Categoria integer,
@Nombre_Categoria varchar(50)
as
update Categoria set Nombre_Categoria=@Nombre_Categoria where ID_Categoria=@ID_Categoria
go
