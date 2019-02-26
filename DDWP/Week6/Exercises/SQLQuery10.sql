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