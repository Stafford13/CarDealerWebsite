use HotelFyrirvara
GO

drop table Guest
create table Guest (
GuestId int primary key identity (1, 1),
LastName varchar(35) not null,
FirstName varchar(25) not null,
HoldCard bit not null default(1),
Age int not null
)
drop table PromotionCode
create table PromotionCode (
PromotionCodeId int primary key identity (1, 1),
Name varchar(50) not null,
isValidStart date not null,
isValidEnd date not null
)

drop table Reservation
create table Reservation (
ReservationId int primary key identity (100, 3),
LastName varchar(25) not null,
FirstName varchar(25) not null,
StartDate date not null,
EndDate date not null,
AllGuests int null,
PromotionCode bit default(0) null,
PromotionCodeId int not null,
constraint fk_reservation_promotionCode foreign key (PromotionCodeId)
references PromotionCode(PromotionCodeId)
)

drop table Amenity
create table Amenity (
AmenityId int primary key identity (1, 1),
BathType varchar(30) not null,
Minibar varchar(30) null,
ClosetType varchar(30) not null
)

drop table RoomType
create table RoomType (
RoomTypeId int primary key identity (1, 1),
RoomType varchar(30) not null
)

drop table Rate
create table Rate (
RateId int primary key identity (1, 1),
ColdSeason bit default(0) not null,
WarmSeason bit default(1) null
)

drop table Room
create table Room (
RoomId int primary key identity (1, 1),
RoomNumber int not null,
RoomFloor int not null,
Limit int null,
RoomTypeId int not null,
constraint fk_room_roomType foreign key (RoomTypeId)
references RoomType(RoomTypeId),
Reserved bit not null default(1),
RateId int not null,
constraint fk_room_rate foreign key (RateId)
references Rate(RateId),
AmenityId int not null,
constraint fk_room_amenity foreign key (AmenityId)
references Amenity(AmenityId)
)

drop table AddOn
create table AddOn (
AddOnId int primary key identity (1, 1),
Meal varchar(35) null,
Movie varchar(25) null,
Snack varchar (100) null,
MiniBar varchar(50) null
)

drop table Billing
create table Billing (
BillingId int primary key identity (1, 1),
Tax decimal null,
AddOnId int null,
constraint fk_billing_addOn foreign key (AddOnId)
references AddOn(AddOnId),
ReservationId int not null,
constraint fk_billing_reservation foreign key (ReservationId)
references Reservation(ReservationId)
)