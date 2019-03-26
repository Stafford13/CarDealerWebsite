if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'DbReset')
		drop procedure DbReset
go

create procedure DbReset as
begin
	delete from Special;
	delete from Car;

	set IDENTITY_INSERT Special ON;
	insert into Special (SpecialId, SpecialName, SpecialText)
	values (1, 'OneTime', 'One time deal'),
	(2, 'FallSale', 'This is the Fall Sale'),
	(3, 'HondaSale', 'A sale just for hondas');

	set IDENTITY_INSERT Special OFF;

	set IDENTITY_INSERT Car ON;
	insert into Car (CarId, Body, Year, ExColor, IntColor, Mileage, Transmission, Type, MSRP, Price, MakeId, ModelId, ImageFileName)
	values (1, 'SUV', '2010', 'Black', 'Tan', '3500', '1', 'Used', '40000', '45000','1', '1', 'Car1'),
	(2, 'SUV', '2017', 'Silver', 'Tan', '3500', '0', 'Used', '40000', '45000','1', '2', 'Car2'),
	(3, 'SUV', '2015', 'Black', 'Grey', '50', '1', 'New', '50000', '60000','2', '1', 'Car3');

	set IDENTITY_INSERT Car OFF;
end