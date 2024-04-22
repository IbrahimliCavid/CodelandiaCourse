--create database SupermarketsChainDB

use SupermarketsChainDB

----Markets (MarketID, MarketName,  Adress, TypeOfMarket, Employee, YearOfCreation, IsDeleted DateOfUpdate,)
----Employee(EmployeeID, Name,  PhoneNumber, Email, Position, Adress, DateOfEmployment, DateOfOtermination, IsDeleted, DateOfUpdate)
----Positions(PositionId, PositionName, PositionSalary, IsDeleted, DateOfUpdate) 
----MarketsTypes(TypeId, MarketTypeName, IsDeleted, DateOfUpdate)

--create table Markets(
--MarketID int primary key identity(1,1),
--MarketName nvarchar not null,
--MarketType int foreign key references MarketTypes(TypeID),
--MarketAdressID int foreign key references Regions(RegionID),
--YearOfCreation datetime default '2012' check (YearOfCreation < 2024) not null,
--IsDeleted int default 0, 
--DateOfUpdate datetime default getdate(),
--)

drop table MarketAndEmployees

--create table MarketTypes(
--TypeID int primary key identity(1,1),
--TypeName nvarchar(100) unique not null,
--Area nvarchar(100) not null,
--IsDeleted int default 0, 
--DateOfUpdate datetime default getdate()
--)

--create table Regions(
--RegionID int primary key identity(1,1),
--RegionName nvarchar(100) unique not null,
--RegionNumber nvarchar(100) unique not null,
--IsDeleted int default 0, 
--DateOfUpdate datetime default getdate()
--)

--create table Positions(
--PositionID int primary key identity(1,1),
--PositionName nvarchar(100) unique not null,
--PositionSalary nvarchar(100)  check (PositionSalary >= 345) not null,
--IsDeleted int default 0, 
--DateOfUpdate datetime default getdate()
--)


--create table Employees(

--EmployeeID  int primary key identity(1,1),
--EmployeeName  nvarchar(100)  not null,
--EmployeeSurname nvarchar(100)  not null,
--EmployeeAge tinyint check (EmployeeAge > 18)  not null,
--EmployeeEmail nvarchar(100)  not null,
--EmployeeNumber char(13) not null,
--EmployeeAdress nvarchar(100)  not null,
--IsDeleted int default 0, 
--DateOfUpdate datetime default getdate()
--)

--create table MarketAndEmpolyees(
--ID int primary key identity (1,1),
--MarketID int foreign key references Markets(MarketID),
--EmployeeID int foreign key references Employees(EmployeeID),
--StartDate datetime not null,
--EndDate Datetime not null,
--IsDeleted int default 0, 
--DateOfUpdate datetime default getdate()
--)

select * from MarketTypes
select * from Regions
