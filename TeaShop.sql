create database TeaShop
go

use TeaShop
go

create table Account 
(
	id int primary key,
	name nvarchar(150),
	password nvarchar(100),
	kind nvarchar(100)
)

create table NhomThucUong(
	id int primary key,
	name nvarchar(150)
	)

create table ThucUong(
	id int primary key,
	name nvarchar(150),
	price float,
	idNhom INT
	)

	create table DSTable(
	id int primary key,
	name nvarchar(150),
	status nvarchar(100) -- trong || co ng
	)

	create table Bill(
	id int primary key,
	DateCheckIn Date not null default GETDATE(),
	DateCheckOut Date,
	idTable int not null,
	status int not null --1 la da thanh toan ||| 0: la chua thanh toan
	)
	

	create table InfoBill(
	id int primary key,
	idBill int not null,
	idThucUong int not null,
	soluong int not null default 0
	)