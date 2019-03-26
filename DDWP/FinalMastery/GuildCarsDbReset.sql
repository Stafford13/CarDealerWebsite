if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'DbReset')
		drop procedure DbReset
go

create procedure DbReset as
begin
	delete from Customer;
	delete from Special;
	delete from Car;
	delete from AspNetUsers where id = '00000000-0000-0000-0000-000000000000';

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

	insert into AspNetUsers(Id, EmailConfirmed, PhoneNumberConfirmed, Email, CarId, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, UserName)
	values('00000000-0000-0000-0000-000000000000', 0, 0, 'test@test.com', 1 , 0, 0, 0, 'test');

	set IDENTITY_INSERT Customer ON;
	insert into Customer ( CustomerId, LastName, Phone, Email, Message)
	values (1, 'Stafford', '555-111-5555', 'test@test.com', 'This website ROCKS!');

	set IDENTITY_INSERT Customer OFF;

end