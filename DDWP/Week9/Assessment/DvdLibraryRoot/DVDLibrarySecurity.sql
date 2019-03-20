use DVDLibrary
go

if exists (select * from sys.databases where name = N'DVDLibrary')
drop user DVDLibraryApp 
if exists (select * from sys.databases where name = N'DVDLibrary')
drop login DVDLibraryApp 

create user DVDLibraryApp for login DvdLibraryApp
go

create login DVDLibraryApp with password='Testing123'
go

GRANT EXECUTE ON DVDLibrarySelectAll TO DVDLibraryApp
GRANT EXECUTE ON DVDLibrarySelectById TO DVDLibraryApp
GRANT EXECUTE ON DVDLibraryCreate TO DVDLibraryApp
GRANT EXECUTE ON DVDLibraryUpdate TO DVDLibraryApp
GRANT EXECUTE ON DVDLibraryDelete TO DVDLibraryApp
GRANT EXECUTE ON DVDLibrarySelectByRating TO DVDLibraryApp
GRANT EXECUTE ON DVDLibrarySelectByTitle TO DVDLibraryApp
GRANT EXECUTE ON DVDLibrarySelectByDirector TO DVDLibraryApp
GRANT EXECUTE ON DVDLibrarySelectByRealeaseYear TO DVDLibraryApp
go

grant select on dvd to DVDLibraryApp
grant insert on dvd to DVDLibraryApp
grant update on dvd to DVDLibraryApp
grant delete on dvd to DVDLibraryApp
go