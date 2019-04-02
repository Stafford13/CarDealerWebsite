use GuildCars
go

if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'DbReset')
		drop procedure DbReset
go

create procedure DbReset as
begin
	delete from Customer;
	delete from Special;
	delete from Car;
	delete from Make;
	delete from Model;
	delete from AspNetUsers where id = '00000000-0000-0000-0000-000000000000';

	DBCC checkident ('car', reseed, 1)

	set IDENTITY_INSERT Special ON;
	insert into Special (SpecialId, SpecialName, SpecialText)
	values (1, 'OneTime', 'One time deal'),
	(2, 'FallSale', 'This is the Fall Sale'),
	(3, 'HondaSale', 'A sale just for hondas');

	set IDENTITY_INSERT Special OFF;

	set IDENTITY_INSERT Make ON;
	insert into Make (MakeId, MakeName, DateAdded, ModelId)
	values (1, 'Honda', '2019-01-01', 1),
	(2, 'Subaru', '2019-01-01', 2),
	(3, 'Kia', '2019-01-01', 3);

	set IDENTITY_INSERT Make OFF;

	set IDENTITY_INSERT Model ON;
	insert into Model (ModelId, ModelName, DateAdded)
	values (1, 'Accord', '2019-01-01'),
	(2, 'Forester', '2019-01-01'),
	(3, 'Soul', '2019-01-01');

	set IDENTITY_INSERT Model OFF;

	set IDENTITY_INSERT Car ON;
	insert into Car (CarId, Body, Year, ExColor, IntColor, Mileage, Transmission, Type, MSRP, Price, MakeId, ModelId, ImageFileName)
	values (1, 'Sedan', '2010', 'Black', 'Tan', 3500, '1', 'Used', 40000, 45000, 1, 1, 'Car1'),
	(2, 'SUV', '2017', 'Silver', 'Tan', 3500, '0', 'Used', 40000, 45000, 2, 2, 'Car2'),
	(3, 'SUV', '2015', 'Black', 'Grey', 50, '1', 'New', 50000, 60000, 3, 3, 'Car3');

	set IDENTITY_INSERT Car OFF;

	insert into AspNetUsers(Id, EmailConfirmed, PhoneNumberConfirmed, Email, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, UserName)
	values('00000000-0000-0000-0000-000000000000', 0, 0, 'test@test.com', 0, 0, 0, 'test');

	set IDENTITY_INSERT Customer ON;
	insert into Customer ( CustomerId, LastName, Phone, Email, Message)
	values (1, 'Stafford', '555-111-5555', 'test@test.com', 'This website ROCKS!');

	set IDENTITY_INSERT Customer OFF;

end