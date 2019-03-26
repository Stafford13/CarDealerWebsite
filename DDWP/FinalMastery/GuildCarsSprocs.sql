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


if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'CarInsert')
		drop procedure CarInsert
go

create procedure CarInsert (
@CarId int output,
@Body varchar(10),
@Year int,
@ExColor varchar(10),
@IntColor varchar(10),
@Mileage int,
@Transmission bit,
@Type varchar(5),
@MSRP int,
@Price int,
@MakeId int,
@ModelId int,
@ImageFileName varchar(50)
)
as

begin
	INSERT INTO Car (Body, Year, ExColor, IntColor, Mileage, Transmission, Type, MSRP, Price, MakeId, ModelId, ImageFileName)
	values(@Body, @Year, @ExColor, @IntColor, @Mileage, @Transmission, @Type, @MSRP, @Price, @MakeId, @ModelId, @ImageFileName);

	set @carId = SCOPE_IDENTITY();
end
go

if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'CarUpdate')
		drop procedure CarUpdate
go

create procedure CarUpdate (
@CarId int,
@Body varchar(10),
@Year int,
@ExColor varchar(10),
@IntColor varchar(10),
@Mileage int,
@Transmission bit,
@Type varchar(5),
@MSRP int,
@Price int,
@MakeId int,
@ModelId int,
@ImageFileName varchar(50)
)
as

begin
	UPDATE Car set
	Body = @Body, 
	Year = @Year, 
	ExColor = @ExColor, 
	IntColor = @IntColor, 
	Mileage = @Mileage, 
	Transmission = @Transmission, 
	Type = @Type, 
	MSRP = @MSRP, 
	Price = @Price, 
	MakeId = @MakeId, 
	ModelId = @ModelId, 
	ImageFileName = @ImageFileName
	where CarId = @CarId
end
go


if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'CarDelete')
		drop procedure CarDelete
go

create procedure CarDelete (
@CarId int
)as

begin
	begin transaction

	delete from Car where CarId = @CarId;

	commit transaction
end
go


if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'CarSelect')
		drop procedure CarSelect
go

create procedure CarSelect (
@CarId int
)as

begin
	select CarId, Body, Year, ExColor, IntColor, Mileage, Transmission, Type, MSRP, Price, MakeId, ModelId, ImageFileName
	from Car
	where CarId = @CarId
end
go