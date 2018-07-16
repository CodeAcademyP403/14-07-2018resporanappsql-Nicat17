create database RestoranDB
use RestoranDB;
go

create table Products
(
Id int not null primary key identity,
Name nvarchar(50) not null,
Category nvarchar(50) not null,
Price decimal(6,2) not null
)

select * from Products;

insert into Products(Name,Category,Price)
					 Values('Dolma','MainEaten',3),
						   ('Kabab','MainEaten',4),
						   ('Pilov','MainEaten',5),
						   ('Coban Salati','Salad',4),
						   ('Sezar Salati','Salad',6),
						   ('Ereb Salati','Salad',7),
						   ('Pendir Salati','Salad',3),
						   ('Lobya Salati','Salad',5),
						   ('Merci Supu','Soup',2),
						   ('Eriste Supu','Soup',4),
						   ('Toyuq Supu','Soup',5),
						   ('Yasil Noxud Sorbasi','Soup',4),
						   ('Yebeniye Sorbasi','Soup',3),
						   ('Bulgur Sorbasi','Soup',4),
						   ('Fanta','Drink',1),
						   ('Cola','Drink',1),
						   ('Ayran','Drink',2),
						   ('Sprite','Drink',1),
						   ('Duses','Drink',1),
						   ('Cay','Drink',0.5),
						   ('Kofe','Drink',2)

go

create table People
(
Id int not null primary key identity,
Username nvarchar(50) not null,
Email varchar(100) not null,
Password int not null,
Role varchar(50) not null
)

select * from People;

ALTER TABLE People
ALTER COLUMN Password nvarchar(50);

-- insert into Person(Username,Email,Password,Role)Values('','',0,'')