create proc Mostrar_Cliente
as
Select *from Cliente order by ID_Cliente desc
go
