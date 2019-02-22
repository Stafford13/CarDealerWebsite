use MovieCatalogue
GO

create table Genre (
GenreId int primary key identity(1, 1),
GenreName nvarchar(30) not null
)

create table Director (
DirectorId int primary key identity(1, 1),
FirstName nvarchar(30) not null,
LastName nvarchar(30) not null,
BirthDate date null
)

create table Rating (
RatingId int primary key identity(1, 1),
RatingName varchar(5) not null
)

create table Movie (
MovieId int primary key identity(1,1),
GenreId int not null,
constraint fk_movie_genre foreign key (GenreId)
references Genre(GenreId),
DirectorId int null,
constraint fk_movie_director foreign key (DirectorId)
references Director(DirectorId),
RatingId int null,
constraint fk_movie_rating foreign key (RatingId)
references Rating(RatingId),
Title nvarchar(128) not null,
ReleaseDate date null
)

create table Actor (
ActorId int primary key identity(1, 1),
FirstName nvarchar(30) not null,
LastName nvarchar(30) not null,
BirthDate date null
)

create table CastMember (
CastMemberId int primary key identity(1, 1),
ActorId int not null,
constraint fk_CastMember_actor foreign key (ActorId)
references Actor(ActorId),
MovieId int not null,
constraint fk_CastMember_movie foreign key (MovieId)
references Movie(MovieId),
[Role] nvarchar(50) not null
)