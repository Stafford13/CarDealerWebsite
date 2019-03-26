use [master]
go

if exists (select * from sys.databases where name = N'GuildCars')
begin
	drop database GuildCars;
end

IF EXISTS(
   SELECT *
   FROM sys.server_principals
   WHERE [Name] = 'CarApp')
BEGIN
   DROP LOGIN CarApp
END
GO

CREATE LOGIN CarApp WITH PASSWORD='Testing123'


create database GuildCars
go
use GuildCars
go

DROP USER IF EXISTS CarApp
GO
CREATE USER CarApp FOR LOGIN CarApp
GO
ALTER ROLE db_backupoperator ADD MEMBER CarApp
ALTER ROLE db_ddladmin ADD MEMBER CarApp
ALTER ROLE db_datareader ADD MEMBER CarApp
ALTER ROLE db_datawriter ADD MEMBER CarApp
GO
