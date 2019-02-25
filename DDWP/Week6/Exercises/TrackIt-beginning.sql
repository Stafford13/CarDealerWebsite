use TrackIt
GO

--create table Project (
--ProjectId char(50) primary key,
--[Name] varchar(100) not null,
--Summary varchar(2000) null,
--DueDate date not null,
--IsActive bit not null default(1)
--)

--create table Worker (
--WorkerId int primary key identity(1, 1),
--FirstName varchar(50) not null,
--LastName varchar(50) not null,
--)

--create table ProjectWorker (
--	ProjectId char(50) not null,
--	WorkerId int not null,
--	constraint pk_ProjectWorker primary key (ProjectId, WorkerId),
--	constraint fk_ProjectWorker_Project foreign key (ProjectId)
--	references Project(ProjectId),
--	constraint fk_ProjectWorker_Worker foreign key (WorkerId)
--	references Worker(WorkerId)
--)

--create table Task (
--TaskID INT primary key identity(1, 1),
--Title VARCHAR(100) not null,
--Details text null,
--DueDate date not null,
--EstimatedHours decimal(5, 2) null,
--ProectId char(50) not null,
--WorkerId int not null,
--constraint fk_Task_Project foreign key (ProjectId, WorkerId)
--references ProjectWorker(ProjectId, WorkerId)
--)

INSERT INTO Worker (FirstName, LastName) VALUES
    ('Rosemonde', 'Featherbie'),
	('Kingsly', 'Besantie'),
	('Goldi','Pilipets'),
    ('Dorey','Rulf'),
    ('Panchito','Ashtonhurst')

SET IDENTITY_INSERT Worker ON

INSERT INTO Worker (WorkerId, FirstName, LastName)
    VALUES (50, 'Valentino', 'Newvill')

SET IDENTITY_INSERT Worker OFF

INSERT INTO Project (ProjectId, [Name], DueDate)
    VALUES ('db-milestone', 'Database Material', '2018-12-31')

INSERT INTO Project (ProjectId, [Name], DueDate)
	VALUES ('kitchen', 'Kitchen Remodel', '2025-07-15'); 
    
INSERT INTO ProjectWorker (ProjectId, WorkerId) VALUES 
    ('db-milestone', 1), -- Rosemonde, Database
    ('kitchen', 2),      -- Kingsly, Kitchen
    ('db-milestone', 3), -- Goldi, Database
    ('db-milestone', 4); -- Dorey, Database

UPDATE Project SET
    Summary = 'All lessons and exercises for the relational database milestone.',
    DueDate = '2018-10-15'
WHERE ProjectId = 'db-milestone';

UPDATE Worker SET
    LastName = 'Oaks'
WHERE WorkerId = 2;

UPDATE Project SET
    IsActive = 0
WHERE DueDate BETWEEN '2017-01-01' AND '2017-12-31'
AND IsActive = 1

UPDATE Task SET
    EstimatedHours = EstimatedHours * 1.25
WHERE WorkerId = 2