CREATE DATABASE E_Commerce;

use E_Commerce
go
create table Products
(
	Id int IDENTITY(1,1)  primary key,
	Product_Name varchar (100) null,
	Product_Desc varchar (100) null,
	Price decimal (18,2),
	Category int foreign key References Catagory(CategoryID)
)


create table Catagory
(
	CategoryID int IDENTITY(1,1)  primary key,	
	Category_Desc varchar (100) null	
)

create table bundles
(
	bundleID int IDENTITY(1,1)  primary key,
	productId int ,
	bundlePrice decimal (18,2)
)




create table Customer
(
	Id int IDENTITY(1,1)  primary key,
	Cust_FName varchar (100) null,
	Cust_LName varchar (100) null,
	Cust_Email varchar (100) null,
	Cust_Tel varchar (100) null,
	Cust_Address varchar (500) null
)

--Cust
Insert into Customer
values('Sipho','Matseme','smatseme@gmail.com','0658168736','21 Ntshengu')
Insert into Customer
values('Tshego','Matseme','tmatseme@gmail.com','0791812551','21 Ntshengu')

--Cat
insert into Catagory
values('Tv'),('Radios'),('Cameras')

insert into Products
values('PlasmaTv','FlatScreenTv','1500.00',1),('Hi-fi','hi-fi system','900.00',2),('DigitalCamera','Digital','700.00',3)