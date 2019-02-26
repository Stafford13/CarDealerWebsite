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
('Getaway', '2019-5-1',' 2019-5-14'),
('MonthLong', '2019-3-1', '2019-8-12'),
('Lovebirds', '2019-2-1', '2019-2-28');

insert into AddOn (RoomService, Movie, Snacks, Price) values
(null, null, null, 0),
('MacNCheese', null, null, 10),
(null, 'Casablanca', null, 5),
(null, null, 'Champagne', 15),
('Hamburger', 'Jurassic World', 'Twizzlers', 30);

insert into Reservation (LastName, FirstName, StartDate, EndDate, AllGuests, PromotionCode, PromotionCodeId, AddOnId) values
('Stafford', 'Eric', '2019-3-15', '2019-3-22', 3, null, null, 1),
('Gaga', 'Lady', '2019-6-21', '2019-6-24', 3, null, null, 1),
('Bareilles', 'Sara','2019-5-12','2019-5-14', 1, 1, 1, 3),
('Kinsmore', 'Dan', '2019-3-21', '2019-3-27',1 , null, null, null),
('Cincotta', 'Jacob', '2019-3-21', '2019-3-28', 2, null, null, 2),
('Crampton', 'Cameron', '2019-3-20', '2019-4-20', 2, 1, 2, 4),
('Knowles', 'Beyonce', '2019-5-23', '2019-6-23', 2, 1, 2, 2);

insert into Amenity (BathType, Minibar, ClosetType, Price) values
('standard', 'standard', 'standard', 60),
('jacuzzi', 'deluxe', 'walkIn', 120),
('standard', 'deluxe', 'standard', 80),
('standard', 'deluxe', 'walkIn', 100),
('jacuzzi', null, 'walkIn', 80);

insert into RoomType (RoomType) values
('one single'),
('two singles'),
('one queen'),
('two queens'),
('one king');

insert into Rate (ColdSeason, WarmSeason) values
(1, null),
(0, 1);

insert into Room (RoomNumber, RoomFloor, Limit, RoomTypeId, Reserved, RateId, AmenityId) values
(10, 1, 1, 1, 0, 1, 1),
(14, 1, 4, 4, 1, 1, 4),
(20, 2, 2, 2, 1, 1, 5),
(21, 2, 2, 5, 0, 1, 3),
(35, 3, 2, 3, 0, 2, 4),
(40, 4, 2, 5, 1, 1, 2);

insert into RoomReservation (RoomId, ReservationId) values
(1, 102),
(2, 105),
(3, 103)

insert into Billing (Tax, AddOnId, ReservationId) values
(1.10, 2, 100),
(1.10, 4, 101),
(1.10, 1, 102),
(1.10, 5, 103);
