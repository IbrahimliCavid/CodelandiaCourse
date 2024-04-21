use LibraryDB

--select * from Books

--insert into  Books(BookName, BookAuthor, PageOfBook, PriceOfBook, YearOfPublication)
--values('Bu şəhərdə kimsə yoxdur', 'Rövşən Abdullaoğlu', '346', '11.9', '2011')

--create table Libraries(
--ID int primary key identity(100,1),
--LibraryName nvarchar(100) not null,
--BookID int foreign key references Books(BookID) not null,
--BookCount smallint not null,
--IsDeleted int default 0,
--ChangedDate datetime default getdate()
--)






--select   books.BookAuthor, Books.BookName, Libraries.LibraryName, libraries.BookCount
--from Books
--Join Libraries on Books.BookID = libraries.BookID
--order by LibraryName, BookCount

--create view BooksView as
--select BookID, BookName, BookAuthor, PriceOfBook
--from Books 
--where isdeleted = 0;

--create view LibrariesView as
--select libraries.Id, libraries.LibraryName,Books.BookName, Books.BookAuthor
--from Books
--join Libraries on Books.BookID = libraries.BookId

create view BooksCountAtLibrary as
select libraries.libraryName, books.bookName, libraries.BookCount
from Books
join Libraries on Books.BookID = Libraries.bookID


select * from books
select * from Libraries
select * from booksview
select * from Librariesview
select * from BooksCountAtLibrary
where BooksCountAtLibrary.bookcount > 0
order by BooksCountAtLibrary.bookcount;