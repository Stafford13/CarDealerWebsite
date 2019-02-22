use MovieCatalogue
go

insert into Actor (FirstName, LastName, BirthDate) values 
('Bill', 'Murray', '1950-09-21'),
('Dan', 'Akroyd', '1952-07-01'),
('John', 'Candy', '1950-10-31'),
('Steve', 'Martin', null),
('Sylvester', 'Stallone', null);

insert into Director (FirstName, LastName, BirthDate) values
('Ivan', 'Reitman', '1946-10-27'),
('Ted', 'Kotcheff', null);

insert into Rating (RatingName) values
('G'),
('PG'),
('PG-13'),
('R');

insert into Genre (GenreName) values
('Action'),
('Comedy'),
('Drama'),
('Horror');

insert into Movie (GenreId, DirectorId, RatingId, Title, ReleaseDate) values
(1, 2, 4, 'Rambo: First Blood', '1982-10-22'),
(2, null, 4, 'Planes, Trains, and Automobiles', '1987-11-25'),
(2, 1, 2, 'Ghostbusters', null),
(2, null, 2, 'The Great Outdoors', '1988-06-17');

insert into CastMember (ActorId, MovieId, [Role]) values
(5, 1, 'John Rambo'),
(4, 2, 'Neil Page'),
(3, 2, 'Del Griffith'),
(1, 3, 'Dr. Peter Venkman'),
(2, 3, 'Dr. Raymond Stanz'),
(2, 4, 'Roman Craig'),
(3, 4, 'Chet Ripley');

update Movie set
Title = 'Ghostbusters (1984)',
ReleaseDate = '1984-06-08'
where MovieId = 3


update Genre set
GenreName = 'Action/Adventure'
where GenreId = 4

delete from Actor
where ActorId = 5

--delete from Director
--where DirectorId = 2

delete from CastMember
where CastMemberId = 1

delete from Movie
where MovieId = 1

alter table Actor
add DateofDeath date null

update Actor set
DateofDeath = '1994-03-04'
where ActorId = 3