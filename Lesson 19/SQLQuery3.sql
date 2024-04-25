create database BookDb

use BookDb


create table Authors
(
ID int primary key identity(1,1),
Name nvarchar(100) not null,
Surname nvarchar(100) not null,
Email varchar(100) not null,

)


create table Books
(
ID int primary key identity(1,1),
Name nvarchar(100) not null,
AuthorID int foreign key references Authors(ID) not null,
PageOf smallint check (PageOf > 50) not null,

)

select * from Authors
select * from Books

