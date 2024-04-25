--create database LibraryDB

use LibraryDB




--create table Authors(
--ID int primary key identity(1,1),
--Name nvarchar(100) not null,
--Surname nvarchar(100) not null,
--Age tinyint not null,
--Adress nvarchar(500),
--BrithOfCountryID int foreign  key references Countries(ID),
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table AuthorTitles(
--ID int primary key identity(1,1),
--Name nvarchar(100) Unique not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)
--create table Regions(
--ID int primary key identity(1,1),
--Name nvarchar(100) Unique not null,
--PostCode tinyint unique not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table Countries(
--ID int primary key identity(1,1),
--Name nvarchar(100) Unique not null,
--CountryCode nvarchar(4) unique not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table BookTypes(
--ID int  primary key identity(1,1),
--Name nvarchar(100) Unique not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table Days(
--ID int primary key identity(1,1),
--Name nvarchar(100) not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--Create table Languages(
--ID int primary key identity(1,1),
--Name nvarchar(100) not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--Create table Currencies(
--ID int primary key identity(1,1),
--Name nvarchar(100) not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table Books(
--ID int primary key identity(1,1),
--Name nvarchar(300) not null,
--PageOf tinyint check (PageOf > 20) not null,
--PriceOf float check (PriceOf > 0) not null,
--CurrencyID int foreign key references Currencies(ID),
--YearOfPublication tinyint check(YearOfPublication <= 2024) not null,
--DescriptionBook nvarchar(2000) not null,
--LanguageID int foreign key references Languages(ID),
--BookTypeID int foreign key references BookTypes(ID),
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)


--create table Libraries(
--ID int primary key identity(1,1),
--Name nvarchar(300) not null,
--Adress nvarchar(500) not null,
--RegionId int foreign key references Regions(ID),
--StartTime nvarchar(8) not null,
--EndTime   nvarchar(8) not null,
--NonWorkDayID int foreign key references Days(ID),
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table BooksAndAuthors(
--ID int primary key identity(1,1),
--BookID int foreign key references Books(ID),
--AuthorID int foreign key references Authors(ID),
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--create table LibrariesAndBooks(
--ID int primary key identity(1,1),
--LibraryID int foreign key references Libraries(ID),
--BookID int foreign key references Books(ID),
--BookCount smallint check (BookCount > 0),
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)


--Create table AuthorsAndTitles(
--ID int primary key identity(1,1),
--AuthorID int foreign key references Authors(ID),
--AuthorTitleID int foreign key references AuthorTitles(ID),
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)


Create table Customers(
ID int primary key identity(1,1),
Name nvarchar(100) not null,
Surname nvarchar(100) not null,
PhoneNumber nvarchar(13) unique not null,
IsDeleted int default 0,
CreateDate datetime default getdate()
)

Create table Customers_Libraries_Books
(
ID int primary key identity(1,1),
CustomerID int foreign key references Customers(ID),
LibraryID int foreign key references Libraries(ID),
BookID int foreign key references Books(ID),
DayOf tinyint not null,
TotalPrice smallint not null,
IsDeleted int default 0,
CreateDate datetime default getdate()
)


