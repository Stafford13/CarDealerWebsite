use HotelFyrirvara
go

select 
count(*),
HoldCard
from Guest
group by HoldCard

select *		
from Guest
where HoldCard is null


select
	count(PromotionCodeId)
from Reservation

1.)
select *
from Reservation
where EndDate = '2019-3-22'

2.)
select 
RoomNumber,
Guest.LastName
from Room
inner join RoomReservation on Room.RoomId = RoomReservation.RoomId
--inner join Reservation on RoomReservation.ReservationId = Reservation.ReservationId
inner join ReservationGuest on RoomReservation.ReservationId = ReservationGuest.ReservationId
inner join Guest on ReservationGuest.GuestId = Guest.GuestId
where Guest.LastName = 'Stafford'

select *
from Guest

select *
from Reservation
where LastName = 'Stafford'

5.)
select
PromotionCode.Name
count(PromotionCode)

3.)
select 
RoomNumber
from Room
left outer join RoomAmenity on Room.RoomId = RoomAmenity.RoomId
and RoomAmenity.AmenityId = 2
group by Room.RoomId, Room.RoomNumber
having count(RoomAmenity.AmenityId) = 0

select*
from RoomAmenity