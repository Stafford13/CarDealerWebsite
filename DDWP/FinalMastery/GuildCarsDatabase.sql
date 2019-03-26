use [master]
go

if exists (select * from sys.databases where name = N'GuildCars')
begin
	drop database GuildCars;
end

create database GuildCars
go