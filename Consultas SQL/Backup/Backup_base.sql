create proc Backup_base
as
Backup database [SisVentas]
To disk = N'C:\SisVentas\Backup\SisVentas.bak'
With description=N'Respaldo del Sistema de ventas',
NoFormat,
Init,
Name=N'SisVentas',
Skip,
Norewind,
Nounload,
Stats=10,
Checksum