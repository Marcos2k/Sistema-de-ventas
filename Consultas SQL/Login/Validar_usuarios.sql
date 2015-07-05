create proc Validar_usuarios
@Login varchar(50),
@Password varchar(50)
as 
select *from Usuarios
where Login=@Login and Password=@Password and Acesso='1'
go