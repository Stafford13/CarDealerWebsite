use HotelFyrirvara
GO

insert into Guest (LastName, FirstName, HoldCard, Age) values
('Stafford', 'Eric', 1, 27),
('Kinsmore', 'Dan', 1, 30),
('Knowles', 'Beyonce', 1, 35),
('Gaga', 'Lady', 1, 35),
('Cincotta', 'Jacob', null, 25),
('Crampton', 'Cameron', 1, 40),
('Bareilles', 'Sara', 1, 35);

insert into PromotionCode (Name, isValidStart, isValidEnd) values
('Getaway', 5/01/2019, 5/15/2019),
('MonthLong', 3/01/2019, 8/01/2019),
('Lovebirds', 2/01/2019, 2/28/2019);

insert into Reservation (LastName, FirstName, StartDate, EndDate, AllGuests, PromotionCode, PromotionCodeId) values
('Stafford', 'Eric', 3/15/2019, 3/22/2019, 3, null, null),
('Gaga', 'Lady', 6/21/2019, 6/23/2019, 3, null, null),
('Bareilles', 'Sara', 5/12/2019, 5/14/2019, 1, 1, 1),
('Kinsmore', 'Dan', 3/21/2019, 3/27/2019,1 , null, null),
('Cincotta', 'Jacob', 3/21/2019, 3/30/2019, 2, null, null),
('Crampton', 'Cameron', 3/20/2019, 4/20/2019, 2, 1, 2),
('Knowles', 'Beyonce', 5/23/2019, 6/30/2019, 2, 1, 2);

insert into Amenity (BathType, Minibar, ClosetType) values
('standard', 'standard', 'standard'),
('jacuzzi', 'deluxe', 'walkIn'),
('standard', 'deluxe', 'standard'),
('standard', 'deluxe', 'walkIn'),
('jacuzzi', null, 'walkIn');

insert into RoomType (Type) values
('one single'),
('two singles'),
('one queen'),
('two queens'),
('one king');

insert into Rate (ColdSeason, WarmSeason) values
(1, null),
(0, 1);

insert into Room (Number, [Floor], Limit, RoomTypeId, Reserved, RateId, RoomAmenity) values
(10, 1, 1, 1, 0, 1, 1),
(14, 1, 4, 4, 1, 1, 4),
(20, 2, 2, 2, 1, 1, 5),
(21, 2, 2, 5, 0, 1, 3),
(35, 3, 2, 3, 0, 2, 4),
(40, 4, 2, 5, 1, 1, 2);


insert into AddOn (RoomService, Movie, Snacks) values
(null, null, null),
('MacNCheese', null, null),
(null, 'Casablanca', null),
(null, null, 'Champagne'),
('Hamburger', 'Jurassic World', 'Twizzlers');

insert into Billing (Tax, AddOnId, ReservationId) values
(1.10, 2, 1),
(1.10, 4, 2),
(1.10, 2, 3),
(1.10, 5, 4);
