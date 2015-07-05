create proc Insertar_Categoria
@Nombre_Categoria varchar(50)
as 
insert into Categoria(Nombre_Categoria) values(@Nombre_Categoria)
go