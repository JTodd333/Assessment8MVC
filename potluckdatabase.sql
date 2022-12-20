create database potluck;
use potluck;

create table TeamMember(
Id int not null auto_increment,
FirstName varchar(50),
LastName varchar(50),
EmailAddress varchar(50),
AttendanceDate datetime,
GuestName varchar(50), 
primary key (id)
);

create table Dish(
Id int not null auto_increment,
TMName varchar(50),
PhoneNumber varchar(25),
DishName varchar(50),
DishDescription varchar(100),
Category varchar(25),
primary key(Id)
);

select * from TeamMember;
select * from Dish;
