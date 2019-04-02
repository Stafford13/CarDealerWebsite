use GroupProject
go

if exists(select * from INFORMATION_SCHEMA.ROUTINES
	where ROUTINE_NAME = 'DbReset')
		drop procedure DbReset
go

create procedure DbReset as
begin
	delete from Customer;
	delete from Special;
	

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

