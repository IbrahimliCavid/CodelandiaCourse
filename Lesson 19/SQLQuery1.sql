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
--PriceOf float check (PriceOf > 0) not null,
--CurrencyID int foreign key references Currencies(ID),
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


--Create table Customers(
--ID int primary key identity(1,1),
--Name nvarchar(100) not null,
--Surname nvarchar(100) not null,
--PhoneNumber nvarchar(13) unique not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)

--Create table Customers_Libraries_Books
--(
--ID int primary key identity(1,1),
--CustomerID int foreign key references Customers(ID),
--LibraryID int foreign key references Libraries(ID),
--BookID int foreign key references Books(ID),
--DayOf tinyint not null,
--TotalPrice smallint not null,
--IsDeleted int default 0,
--CreateDate datetime default getdate()
--)


---COINTRIES INSERT-------


INSERT INTO Countries (Name, CountryCode) VALUES ('Brazil', 'BRA');
INSERT INTO Countries (Name, CountryCode) VALUES ('Russia', 'RUS');
INSERT INTO Countries (Name, CountryCode) VALUES ('China', 'CHN');
INSERT INTO Countries (Name, CountryCode) VALUES ('India', 'IND');
INSERT INTO Countries (Name, CountryCode) VALUES ('Mexico', 'MEX');
INSERT INTO Countries (Name, CountryCode) VALUES ('South Korea', 'KOR');
INSERT INTO Countries (Name, CountryCode) VALUES ('Argentina', 'ARG');
INSERT INTO Countries (Name, CountryCode) VALUES ('Turkey', 'TUR');
INSERT INTO Countries (Name, CountryCode) VALUES ('Saudi Arabia', 'SAU');
INSERT INTO Countries (Name, CountryCode) VALUES ('South Africa', 'ZAF');
INSERT INTO Countries (Name, CountryCode) VALUES ('Egypt', 'EGY');
INSERT INTO Countries (Name, CountryCode) VALUES ('Nigeria', 'NGA');
INSERT INTO Countries (Name, CountryCode) VALUES ('Indonesia', 'IDN');
INSERT INTO Countries (Name, CountryCode) VALUES ('Pakistan', 'PAK');
INSERT INTO Countries (Name, CountryCode) VALUES ('Bangladesh', 'BGD');
INSERT INTO Countries (Name, CountryCode) VALUES ('Philippines', 'PHL');
INSERT INTO Countries (Name, CountryCode) VALUES ('Vietnam', 'VNM');
INSERT INTO Countries (Name, CountryCode) VALUES ('Thailand', 'THA');
INSERT INTO Countries (Name, CountryCode) VALUES ('Iran', 'IRN');
INSERT INTO Countries (Name, CountryCode) VALUES ('Iraq', 'IRQ');
INSERT INTO Countries (Name, CountryCode) VALUES ('Afghanistan', 'AFG');
INSERT INTO Countries (Name, CountryCode) VALUES ('Ukraine', 'UKR');
INSERT INTO Countries (Name, CountryCode) VALUES ('Poland', 'POL');
INSERT INTO Countries (Name, CountryCode) VALUES ('Italy', 'ITA');
INSERT INTO Countries (Name, CountryCode) VALUES ('Spain', 'ESP');
INSERT INTO Countries (Name, CountryCode) VALUES ('Canada', 'CAN');
INSERT INTO Countries (Name, CountryCode) VALUES ('Australia', 'AUS');
INSERT INTO Countries (Name, CountryCode) VALUES ('Japan', 'JPN');
INSERT INTO Countries (Name, CountryCode) VALUES ('Azerbaijan', 'AZE');


---AUTHOR TITLE INSERT-------

INSERT INTO AuthorTitles (Name) VALUES ('Novelist');
INSERT INTO AuthorTitles (Name) VALUES ('Poet');
INSERT INTO AuthorTitles (Name) VALUES ('Playwright');
INSERT INTO AuthorTitles (Name) VALUES ('Essayist');
INSERT INTO AuthorTitles (Name) VALUES ('Biographer');
INSERT INTO AuthorTitles (Name) VALUES ('Journalist');
INSERT INTO AuthorTitles (Name) VALUES ('Historian');


---Region INSERT-------

INSERT INTO Regions (Name, PostCode) VALUES ('Ağcabedi', 10);
INSERT INTO Regions (Name, PostCode) VALUES ('Ağdaş', 20);
INSERT INTO Regions (Name, PostCode) VALUES ('Ağstafa', 30);
INSERT INTO Regions (Name, PostCode) VALUES ('Ağsu', 40);
INSERT INTO Regions (Name, PostCode) VALUES ('Babek', 60);
INSERT INTO Regions (Name, PostCode) VALUES ('Balaken', 70);
INSERT INTO Regions (Name, PostCode) VALUES ('Beylegan', 80);
INSERT INTO Regions (Name, PostCode) VALUES ('Bilesuvar', 90);
INSERT INTO Regions (Name, PostCode) VALUES ('Cebrayıl', 100);
INSERT INTO Regions (Name, PostCode) VALUES ('Celilabad', 110);
INSERT INTO Regions (Name, PostCode) VALUES ('Culfa', 120);
INSERT INTO Regions (Name, PostCode) VALUES ('Daşkesen', 130);
INSERT INTO Regions (Name, PostCode) VALUES ('Füzuli', 140);
INSERT INTO Regions (Name, PostCode) VALUES ('Goranboy', 150);
INSERT INTO Regions (Name, PostCode) VALUES ('Göyçay', 160);
INSERT INTO Regions (Name, PostCode) VALUES ('Göygöl', 170);
INSERT INTO Regions (Name, PostCode) VALUES ('Hacıkabul', 180);
INSERT INTO Regions (Name, PostCode) VALUES ('Hankendi', 190);
INSERT INTO Regions (Name, PostCode) VALUES ('Hocavend', 200);
INSERT INTO Regions (Name, PostCode) VALUES ('İmişli', 210);
INSERT INTO Regions (Name, PostCode) VALUES ('Kah', 220);
INSERT INTO Regions (Name, PostCode) VALUES ('Kazah', 230);
INSERT INTO Regions (Name, PostCode) VALUES ('Kebele', 240);
INSERT INTO Regions (Name, PostCode) VALUES ('Kengerli', 250);
INSERT INTO Regions (Name, PostCode) VALUES ('Kobustan', 260);
INSERT INTO Regions (Name, PostCode) VALUES ('Kusar', 270);
INSERT INTO Regions (Name, PostCode) VALUES ('Kürdemir', 280);
INSERT INTO Regions (Name, PostCode) VALUES ('Lerik', 290);
INSERT INTO Regions (Name, PostCode) VALUES ('Sabirabad', 300);
INSERT INTO Regions (Name, PostCode) VALUES ('Salyan', 310);
INSERT INTO Regions (Name, PostCode) VALUES ('Sederek', 320);
INSERT INTO Regions (Name, PostCode) VALUES ('Şabran', 330);
INSERT INTO Regions (Name, PostCode) VALUES ('Şemkir', 340);
INSERT INTO Regions (Name, PostCode) VALUES ('Şirvan', 350);
INSERT INTO Regions (Name, PostCode) VALUES ('Şuşa', 360);
INSERT INTO Regions (Name, PostCode) VALUES ('Ucar', 370);
INSERT INTO Regions (Name, PostCode) VALUES ('Yevlah', 380);
INSERT INTO Regions (Name, PostCode) VALUES ('Zakatala', 390);
INSERT INTO Regions (Name, PostCode) VALUES ('Zengilan', 400);
INSERT INTO Regions (Name, PostCode) VALUES ('Zerdab', 410);
INSERT INTO Regions (Name, PostCode) VALUES ('Ismailli', 420);
INSERT INTO Regions (Name, PostCode) VALUES ('Baku', 430);
INSERT INTO Regions (Name, PostCode) VALUES ('Ganja', 440);
INSERT INTO Regions (Name, PostCode) VALUES ('Sumgait', 450);



---Region INSERT-------


INSERT INTO BookTypes (Name) VALUES ('Roman');
INSERT INTO BookTypes (Name) VALUES ('Hekayə');
INSERT INTO BookTypes (Name) VALUES ('Şeir');
INSERT INTO BookTypes (Name) VALUES ('Drama');
INSERT INTO BookTypes (Name) VALUES ('Biografiya');
INSERT INTO BookTypes (Name) VALUES ('Məqalə');
INSERT INTO BookTypes (Name) VALUES ('Tarix');


---LANGUAGE INSERT-------


INSERT INTO Languages (Name) VALUES (N'Azərbaycan dili');
INSERT INTO Languages (Name) VALUES (N'Türkcə');
INSERT INTO Languages (Name) VALUES (N'Rus dili');
INSERT INTO Languages (Name) VALUES (N'İngilis dili');
INSERT INTO Languages (Name) VALUES (N'Alman dili');
INSERT INTO Languages (Name) VALUES (N'Fransız dili');
INSERT INTO Languages (Name) VALUES (N'İtalyan dili');
INSERT INTO Languages (Name) VALUES (N'İspan dili');
INSERT INTO Languages (Name) VALUES (N'Çin dili');
INSERT INTO Languages (Name) VALUES (N'Arabic');
INSERT INTO Languages (Name) VALUES (N'Pers dili');
INSERT INTO Languages (Name) VALUES (N'Hind dili');
INSERT INTO Languages (Name) VALUES (N'Ukrayna dili');
INSERT INTO Languages (Name) VALUES (N'Kazak dili');
INSERT INTO Languages (Name) VALUES (N'Gürcü dili');
INSERT INTO Languages (Name) VALUES (N'Fars dili');
INSERT INTO Languages (Name) VALUES (N'Erməni dili');
INSERT INTO Languages (Name) VALUES (N'Tacik dili');
INSERT INTO Languages (Name) VALUES (N'Özbek dili');
INSERT INTO Languages (Name) VALUES (N'Turkmen dili');
INSERT INTO Languages (Name) VALUES (N'Kırgız dili');
INSERT INTO Languages (Name) VALUES (N'Arapça');
INSERT INTO Languages (Name) VALUES (N'Çeçen dili');
INSERT INTO Languages (Name) VALUES (N'Kore dili');
INSERT INTO Languages (Name) VALUES (N'Japon dili');
INSERT INTO Languages (Name) VALUES (N'Vietnam dili');
INSERT INTO Languages (Name) VALUES (N'Türkmen dili');
INSERT INTO Languages (Name) VALUES (N'Luganda dili');
INSERT INTO Languages (Name) VALUES (N'Tagalog dili');
INSERT INTO Languages (Name) VALUES (N'Swahili dili');


---AUTHORS INSERT-------


INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Fatma', 'Aliyeva', 35, 'Baku, 123 Main St',         34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Emin', 'Abdullayev', 28, 'Ganja, 456 Elm St',       34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Ayten', 'Mammadova', 40, 'Sumgait, 789 Oak St',     34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Elchin', 'Mustafayev', 45, 'Sheki, 101 Pine St',    34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Nigar', 'Jafarova', 32, 'Lankaran, 202 Maple St',   34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Rashad', 'Hasanov', 37, 'Mingachevir, 303 Cedar St',34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Narmin', 'Rzayeva', 29, 'Nakhchivan, 404 Birch St', 34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Vugar', 'Ismayilov', 42, 'Goychay, 505 Fir St',     34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Aysel', 'Quliyeva', 38, 'Shamakhi, 606 Spruce St',  34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Anar', 'Rustamov', 31, 'Lerik, 707 Willow St',      34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Gulnar', 'Huseynova', 34, 'Imishli, 808 Oak St',    34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Togrul', 'Javadov', 39, 'Shusha, 909 Maple St',     34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Fidan', 'Mammadli', 36, 'Gabala, 1010 Cedar St',    34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Elvin', 'Hajiyev', 33, 'Khachmaz, 1111 Birch St',   34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Sevinj', 'Aliyeva', 30, 'Agjabadi, 1212 Fir St',    34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Nizami', 'Mammadov', 27, 'Goygol, 1313 Spruce St',  34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Aynur', 'Jafarova', 44, 'Agstafa, 1414 Willow St',  34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Orkhan', 'Hasanov', 41, 'Shaki, 1515 Oak St',       34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Leyla', 'Rzayeva', 26, 'Sumqayit, 1616 Maple St',   34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Eldar', 'Ismayilov', 43, 'Quba, 1717 Cedar St',     34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Nergiz', 'Quliyeva', 39, 'Baku, 1818 Birch St',     34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Murad', 'Rustamov', 36, 'Ganja, 1919 Fir St',       34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Gunay', 'Huseynova', 33, 'Sumgait, 2020 Spruce St', 34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Rasul', 'Javadov', 28, 'Baku, 2121 Willow St',      34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Feride', 'Mammadli', 45, 'Ganja, 2222 Oak St',      34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Emin', 'Hajiyev', 42, 'Sumgait, 2323 Maple St',     34);
INSERT INTO Authors (Name, Surname, Age, Adress, BrithOfCountryID) VALUES ('Aysel', 'Aliyeva', 29, 'Baku, 2424 Cedar St',       34);


---CURRENCIES INSERT-------

INSERT INTO Currencies (Name) VALUES ('AZN');
INSERT INTO Currencies (Name) VALUES ('USD');
INSERT INTO Currencies (Name) VALUES ('EUR');
INSERT INTO Currencies (Name) VALUES ('GBP');
INSERT INTO Currencies (Name) VALUES ('JPY');
INSERT INTO Currencies (Name) VALUES ('CNY');
INSERT INTO Currencies (Name) VALUES ('RUB');
INSERT INTO Currencies (Name) VALUES ('TRY');
INSERT INTO Currencies (Name) VALUES ('CAD');
INSERT INTO Currencies (Name) VALUES ('AUD');
INSERT INTO Currencies (Name) VALUES ('CHF');
INSERT INTO Currencies (Name) VALUES ('SEK');
INSERT INTO Currencies (Name) VALUES ('NOK');
INSERT INTO Currencies (Name) VALUES ('DKK');
INSERT INTO Currencies (Name) VALUES ('SGD');
INSERT INTO Currencies (Name) VALUES ('HKD');
INSERT INTO Currencies (Name) VALUES ('NZD');
INSERT INTO Currencies (Name) VALUES ('KRW');
INSERT INTO Currencies (Name) VALUES ('INR');
INSERT INTO Currencies (Name) VALUES ('BRL');
INSERT INTO Currencies (Name) VALUES ('ZAR');
INSERT INTO Currencies (Name) VALUES ('MXN');
INSERT INTO Currencies (Name) VALUES ('PLN');
INSERT INTO Currencies (Name) VALUES ('ARS');
INSERT INTO Currencies (Name) VALUES ('THB');
INSERT INTO Currencies (Name) VALUES ('IDR');
INSERT INTO Currencies (Name) VALUES ('MYR');
INSERT INTO Currencies (Name) VALUES ('PHP');
INSERT INTO Currencies (Name) VALUES ('AED');


---DAYS INSERT-------

INSERT INTO Days (Name) VALUES (N'Bazar ertəsi');
INSERT INTO Days (Name) VALUES (N'Çərşənbə axşamı');
INSERT INTO Days (Name) VALUES (N'Çərşənbə');
INSERT INTO Days (Name) VALUES (N'Cümə axşamı');
INSERT INTO Days (Name) VALUES (N'Cümə');
INSERT INTO Days (Name) VALUES (N'Şənbə');
INSERT INTO Days (Name) VALUES (N'Bazar');



---LIBRARIES INSERT-------



INSERT INTO Libraries (Name, Adress, RegionId, StartTime, EndTime, NonWorkDayID) VALUES (N'Nizami Gəncəvi Adına Respublika Elmi Kitabxanası', 'Nizami küçəsi, Bakı, Azərbaycan', 1, '09:00', '18:00', 7);
INSERT INTO Libraries (Name, Adress, RegionId, StartTime, EndTime, NonWorkDayID) VALUES (N'Azərbaycan Milli Elmlər Akademiyası Kitabxanası', 'Həsən Əliyev küçəsi, Bakı, Azərbaycan', 1, '09:00', '18:00', 7);
INSERT INTO Libraries (Name, Adress, RegionId, StartTime, EndTime, NonWorkDayID) VALUES (N'Əhməd Cavad Adına Gəncə Tarix-Diyarşünaslıq Muzeyi', 'Şərifzadə küçəsi, Gəncə, Azərbaycan', 2, '09:00', '18:00', 7);


select * from [dbo].[Authors]
select * from [dbo].[AuthorsAndTitles]
select * from [dbo].[AuthorTitles]
select * from [dbo].[Books]
select * from [dbo].[BooksAndAuthors]
select * from [dbo].[BookTypes]
select * from [dbo].[Countries]
select * from [dbo].[Customers_Libraries_Books]
select * from [dbo].[Customers]
select * from [dbo].[Days]
select * from [dbo].[Languages]
select * from [dbo].[Libraries]
select * from [dbo].[LibrariesAndBooks]
select * from [dbo].[Regions]
