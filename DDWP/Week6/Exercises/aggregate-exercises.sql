use PersonalTrainer
GO

-- Use an aggregate to count the number of Clients.
-- 500 rows
--------------------
select 
count(ClientId)
from Client


-- Use an aggregate to count Client.BirthDate.
-- The number is different than total Clients. Why?
-- 463 rows
--------------------
select count(Client.BirthDate)
from Client

-- Group Clients by City and count them.
-- Order by the number of Clients desc.
-- 20 rows
--------------------
select 
City,
count(*)
from Client
group by City

-- Calculate a total per invoice using only the InvoiceLineItem table.
-- Group by InvoiceId.
-- You'll need an expression for the line item total: Price * Quantity.
-- Aggregate per group using SUM().
-- 1884 rows
--------------------
select
	InvoiceId,
	SUM(Price*Quantity)
from InvoiceLineItem
group by InvoiceId

-- Calculate a total per invoice using only the InvoiceLineItem table.
-- (See above.)
-- Only include totals greater than $500.00.
-- Order from lowest total to highest.
-- 234 rows
--------------------
select
	InvoiceId,
	SUM(Price*Quantity)
from InvoiceLineItem
group by InvoiceId
having SUM(Price*Quantity) > 500
order by InvoiceId asc

-- Calculate the average line item total
-- grouped by InvoiceLineItem.Description.
-- 3 rows
--------------------
select
AVG(Price*Quantity)
from InvoiceLineItem
group by InvoiceLineItem.Description

-- Select ClientId, FirstName, and LastName from Client
-- for clients who have *paid* over $1000 total.
-- Paid is Invoice.InvoiceStatus = 2.
-- Order by LastName, then FirstName.
-- 146 rows
--------------------
Select
c.ClientId,
FirstName,
LastName,
SUM(Price*Quantity)
from Client c
inner join Invoice on Invoice.ClientId = c.ClientId
inner join InvoiceLineItem on InvoiceLineItem.InvoiceId = Invoice.InvoiceId
where Invoice.InvoiceStatus = 2
group by c.ClientId, FirstName, LastName
having SUM(Price*Quantity) > 1000
order by LastName, FirstName

-- Count exercises by category.
-- Group by ExerciseCategory.Name.
-- Order by exercise count descending.
-- 13 rows
--------------------
select *
count(Exercise.Name) EX
from ExerciseCategory
group by ExerciseCategory.Name
order by count(EX) desc

-- Select Exercise.Name along with the minimum, maximum,
-- and average ExerciseInstance.Sets.
-- Order by Exercise.Name.
-- 64 rows
--------------------

-- Find the minimum and maximum Client.BirthDate
-- per Workout.
-- 26 rows
-- Sample: 
-- WorkoutName, EarliestBirthDate, LatestBirthDate
-- '3, 2, 1... Yoga!', '1928-04-28', '1993-02-07'
--------------------

-- Count client goals.
-- Be careful not to exclude rows for clients without goals.
-- 500 rows total
-- 50 rows with no goals
--------------------

-- Select Exercise.Name, Unit.Name, 
-- and minimum and maximum ExerciseInstanceUnitValue.Value
-- for all exercises with a configured ExerciseInstanceUnitValue.
-- Order by Exercise.Name, then Unit.Name.
-- 82 rows
--------------------

-- Modify the query above to include ExerciseCategory.Name.
-- Order by ExerciseCategory.Name, then Exercise.Name, then Unit.Name.
-- 82 rows
--------------------

-- Select the minimum and maximum age in years for
-- each Level.
-- To calculate age in years, use the T-SQL function DATEDIFF.
-- 4 rows
--------------------

-- Stretch Goal!
-- Count logins by email extension (.com, .net, .org, etc...).
-- Research SQL functions to isolate a very specific part of a string value.
-- 27 rows (27 unique email extensions)
--------------------

-- Stretch Goal!
-- Match client goals to workout goals.
-- Select Client FirstName and LastName and Workout.Name for
-- all workouts that match at least 2 of a client's goals.
-- Order by the client's last name, then first name.
-- 139 rows
--------------------