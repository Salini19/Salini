create database Shopping


use Shopping

create table Customer
(custid int primary key,
custname varchar(20),
city varchar(20),
state varchar(20))

create table Products
(prodid int primary key,
prodname varchar(20),
unitprice int,
UnitOfMeasurement varchar(20),
QtyinStock int)

create table Sales_Header
(invno int primary key,
invdate date,
invamt int,
disPercent int)

create table Sales_Detail
(
invno int,
custid int,
prodid int,
qtysold int
)

alter table sales_detail
add foreign key(invno) references sales_header(invno)

alter table sales_detail
add foreign key(custid) references Customer(custid)

alter table sales_detail
add foreign key(prodid) references Products(prodid)

alter table sales_detail
drop column qtysold

drop table sales_detail


alter table sales_detail
add Qty int primary key






