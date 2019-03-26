if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'CarSelectAll')
		drop procedure CarSelectAll
go

create procedure CarSelectAll as
begin
	select CarId, Body, Year, ExColor, IntColor, Mileage, Transmission, Type, MSRP, Price, MakeId, ModelId, ImageFileName
	from Car
end
go


if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'SpecialSelectAll')
		drop procedure SpecialSelectAll
go

create procedure SpecialSelectAll as
begin
	select SpecialId, SpecialName, SpecialText
	from Special
	order by SpecialName
end
go