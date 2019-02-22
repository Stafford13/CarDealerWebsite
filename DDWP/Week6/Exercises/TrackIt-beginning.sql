use TrackIt
GO

create table Project(
ProjectId char(50) primary key,
[Name] varchar(100) not null,
Summary varchar(2000) null,
DueDate date not null,
IsActive bit not null default(1)
)

create table Worker (
WorkerId int primary key identity(1, 1),
FirstName varchar(50) not null,
LastName varchar(50) not null,
)

create table ProjectWorker (
	ProjectId char(50) not null,
	WorkerId int not null,
	constraint pk_ProjectWorker primary key (ProjectId, WorkerId),
	constraint fk_ProjectWorker_Project foreign key (ProjectId)
	references Project(ProjectId),
	constraint fk_ProjectWorker_Worker foreign key (WorkerId)
	references Worker(WorkerId)
)

create table Task (
TaskID INT primary key identity(1, 1),
Title VARCHAR(100) not null,
Details text null,
DueDate date not null,
EstimatedHours decimal(5, 2) null,
ProectId char(50) not null,
WorkerId int not null,
constraint fk_Task_Project foreign key (ProjectId, WorkerId)
references ProjectWorker(ProjectId, WorkerId)
)
