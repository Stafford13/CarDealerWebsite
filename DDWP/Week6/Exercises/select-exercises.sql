USE PersonalTrainer
GO

-- Select all rows and columns from the Exercise table.
-- 64 rows
--------------------
SELECT *
FROM Exercise

-- Select all rows and columns from the Client table.
-- 500 rows
--------------------
SELECT *
FROM Client

-- Select all columns from Client where the City is Metairie.
-- 29 rows
--------------------
SELECT *
FROM Client
WHERE City = 'Metairie'

-- Is there a Client with the ClientId '818a7faf-7b4b-48a2-bf12-7a26c92de20c'?
-- nope
--------------------
select *
from Client
where ClientId = '818a7faf-7b4b-48a2-bf12-7a26c92de20c'

-- How many rows in the Goal table?
-- 17 rows
--------------------
select *
from Goal

-- Select Name and LevelId from the Workout table.
-- 26 rows
--------------------
select LevelId,
Name
from Workout

-- Select Name, LevelId, and Notes from Workout where LevelId is 2.
-- 11 rows
--------------------
select Notes, Name, LevelID
from workout
where LevelID = 2

-- Select FirstName, LastName, and City from Client 
-- where City is Metairie, Kenner, or Gretna.
-- 77 rows
--------------------
select FirstName, LastName, City
from Client
where (City = 'Metairie' or City = 'Kenner' or City = 'Gretna')


-- Select FirstName, LastName, and BirthDate from Client
-- for Clients born in the 1980s.
-- 72 rows
--------------------
select FirstName, LastName, BirthDate
from Client
where BirthDate BETWEEN '1980-01-01' and '1989-12-31'

-- Write the query above in a different way. 
-- If you used BETWEEN, you can't use it again.
-- If you didn't use BETWEEN, use it!
-- Still 72 rows
--------------------
select FirstName, LastName, BirthDate
from Client
where (BirthDate >= '1980-01-01') and (BirthDate <= '1989-12-31')

-- How many rows in the Login table have a .gov EmailAddress?
-- 17 rows
--------------------
select EmailAddress
from Login
where EmailAddress LIKE '%.gov'

-- How many Logins do NOT have a .com EmailAddress?
-- 122 rows
--------------------
select EmailAddress
from Login
where EmailAddress NOT LIKE '%.com'

-- Select first and last name of Clients without a BirthDate.
-- 37 rows
--------------------
select FirstName, LastName
from Client
where BirthDate is null

-- Select the Name of each ExerciseCategory that has a parent.
-- (ParentCategoryId value is not null)
-- 12 rows
--------------------
select Name
from ExerciseCategory
where ParentCategoryId is not null

-- Select Name and Notes of each level 3 Workout that
-- contains the word 'you' in its Notes.
-- 4 rows
--------------------
select Name, Notes
from Workout
where LevelId = 3 
and Notes LIKE '%you%'

-- Select FirstName, LastName, City from Clients who have a LastName
-- that starts with L,M, or N and who live in LaPlace.
-- 5 rows
--------------------
select FirstName, LastName, City
from Client
where (LastName LIKE 'L%' or LastName LIKE 'M%' or LastName LIKE 'N%') and (City = 'LaPlace')

-- Select InvoiceId, Description, Price, Quantity, ServiceDate 
-- and the line item total, a calculated value, where the line item total
-- is between 15 and 25 dollars.
-- 667 rows
--------------------
select InvoiceID, Description, Price, Quantity, ServiceDate, (Price*Quantity)
from InvoiceLineItem
where (Price*Quantity) between 15 and 25

-- Does the Client, Estrella Bazely, have a Login? 
-- If so, what is her email address?
-- This requires two queries:
-- First, select a Client record for Estrella Bazely. Does it exist?
-- Second, if it does, select a Login record that matches its ClientId.
--------------------
select Firstname, LastName, ClientId
from Client
where FirstName like'e%a' and LastName like'b%y'

select EmailAddress
from Login
where ClientId = '87976C42-9226-4BC6-8B32-23A8CD7869A5'

-- What are the Goals of the Workout with the Name 'This Is Parkour'?
-- You need three queries!:
-- 1. Select the WorkoutId from Workout where Name equals 'This Is Parkour'.
-- 2. Select GoalId from WorkoutGoal where the WorkoutId matches the WorkoutId
--    from your first query.
-- 3. Select everything from Goal where the GoalId is one of the GoalIds from your
--    second query.
-- 1 row, 3 rows, 3 rows
--------------------
select WorkoutID
from Workout
where Name = 'This is Parkour'

select GoalID
from WorkoutGoal
where WorkoutId = 12

select *
from Goal
where (GoalID = 3 or GoalID = 8 or GoalID = 15)