use [master]
go

if exists (select * from sys.databases where name = N'GuildCars')
begin
	EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'GuildCars';
	ALTER DATABASE GuildCars SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE GuildCars;
end

create database GuildCars
go

use GuildCars
go

create table Special (
SpecialId int primary key identity(1,1),
SpecialName varchar(20) not null,
SpecialText varchar(450) not null
)


create table Model (
ModelId int primary key identity(1,1),
ModelName varchar(25) not null,
DateAdded date not null
)


create table Make (
MakeId int primary key identity(1,1),
MakeName varchar(20) not null,
DateAdded date not null,
ModelId int not null,
constraint fk_Make_Model foreign key (ModelId)
references Model(ModelId)
)


create table Car (
CarId int primary key identity(1,1),
Body varchar(10) not null,
[Year] int not null,
ExColor varchar(10) not null,
IntColor varchar(10) not null,
Mileage int not null,
Transmission bit not null,
[Type] varchar(5) not null,
MSRP int not null,
Price int not null,
MakeId int not null,
constraint fk_Car_Make foreign key (MakeId)
references Make(MakeId),
ModelId int not null,
constraint fk_Car_Model foreign key (ModelId)
references Model(ModelId),
ImageFileName varchar(50) not null
)


create table Sale (
SalesId int primary key identity(1,1),
Price int not null,
SpecialId int null,
constraint fk_Sale_Special foreign key (SpecialId)
references Special(SpecialId),
CarId int not null,
constraint fk_Sale_Car foreign key (CarId)
references Car(CarId),LastName nvarchar(20) not null,
Phone int not null,
Email nvarchar(35) not null,
Address1 varchar(60) not null,
Address2 nvarchar(35) null,
City varchar(25) not null,
[State] varchar(30) not null
)


create table Customer (
CustomerId int primary key identity(1,1),
LastName nvarchar(20) not null,
Phone int not null,
Email nvarchar(35) not null,
[Message] varchar(300) null
)
