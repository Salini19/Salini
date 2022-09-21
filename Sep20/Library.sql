create database Library

use Library

--problem1
create table Member
(
MemberId numeric(5) primary key,
Member_Name char(25),
Acc_Open_Date Date,
Max_Book_sAllowed numeric(2),
Penalty_Amount numeric(7,2))

create table Book
(
Book_No numeric(6) primary key,
Book_Name varchar(30),
Author char(30),
Cost numeric(7,2),
Category char(10)
)

create Table Issue
(
Lib_Issue_Id numeric(10), 
Book_No numeric(6) ,
MemberId numeric(5)  ,
Issue_Date Date,
Return_Date Date
)

alter table Issue
add foreign key(MemberId) references Member(Memberid)


alter table Issue
add foreign key(Book_No) references Book(Book_No)

 --problem2
select * from Issue
EXEC sp_help Issue

--problem3
alter table Issue
add Comments char(100)


--problem4
alter table Member
alter column Member_Name char(30)

--problem5
alter table Issue
add Reference Char(30)

--problem6
alter table Issue
drop column Reference

--problem7
EXEC sp_rename 'Issue', 'Lib_Issue';

--problem8
insert into Member values(1,'Richa Sharma','2005-05-10',5,50)
insert into Member values(2,'Garima Sen',GETDATE(),3,null)
insert into Member values(3,'Sameer Ahmed','2000-11-19',3,100)
insert into Member values(4,'Rahul sharma',GETDATE(),5,null)
insert into Member values(5,'Anand varma','2009-09-16',4,150)

select * from Member

--problem 9
alter table Member
alter column Member_name char(20)

--problem10
insert into Member values(6,'salini',getdate(),110,100)
--Arithmetic overflow error converting int to data type numeric.
--(because it has 3 digit ,max book allowed  column  allow only 2 digit numbers.

--problem11
--select * into Member101 from Member
--select * into Member101 from Member where 1 = 2

create table Member101


--problem12
insert into Book values(101,'Let us C','Denis Ritchie',450,'System')
insert into Book values(102,'Oracle-complete Ref','Loni',550,'database')
insert into Book values(103,' Mastering SQL','Loni',250,'database')
insert into Book values(104,' PL SQL-Ref','Scott Urman',750,'database')

insert into Book values(106,'Oracle Ref','Denis Ritchie',550,'database') 
insert into Book values(107 &'SQL ref'&'Scott Urman'&250&'System')


--problem 14& 15
select * into Book101 from Book

select * from Book101
select * from Book
select * from Member
select * from Member101
select * from lib_Issue

--problem18
insert into Book values(105, 'National Geographic', 'Adis Scott', 1000, 'Science')

--problem20 // Modify the price of book with id 103 to Rs 300 and category to RDBMS

update Book
set cost=300 , category='RDBMS'
where Book_no=103 

--problem21
EXEC sp_rename 'Lib_Issue', 'Issue'


--problem22 &23
insert into Issue values(7001,101,1,'2006-12-10',null)
insert into Issue values(7002,102,2,'2006-12-25',null)
insert into Issue values(7003,104,1,'2006-01-15',null)
insert into Issue values(7004,101,1,'2006-07-04',null)
insert into Issue values(7005,104,2,'2006-11-06',null)
insert into Issue values(7006,101,3,'2006-02-18',null)

sp_help Issue

alter table issue drop constraint FK__Issue__Book_No__4CA06362

alter table issue 
add foreign key(Book_No) references Book(Book_No) on delete cascade

alter table Issue 
drop column Comments


select * from Issue

--problem24
update Issue
set Return_Date= dateadd(day,15,Issue_Date)
where Lib_Issue_Id=7004 

update Issue
set Return_Date= dateadd(day,15,Issue_Date)
where Lib_Issue_Id=7005

--problem25
update Member
set Penalty_Amount = 100
where member_Name = 'Garima Sen'

--Remove all the records from Issue table where member_ID is 1 and Issue date in before 10-Dec-06

--problem26
delete from Issue
where MemberId=1 and Issue_Date < '2006-12-10'



select * from Member
--Remove all the records from Book table with category other then RDBMS and Database.

--problem27
delete from Book
where Category!='RDBMS' and Category !='Database' 

select * from Book

--problem28
drop table Member101

--problem29
drop table Book101

--problem30
select * from Book
EXEC sp_help Book
select * from Member
EXEC sp_help Member	
select * from Issue
EXEC sp_help Issue

--problem31
SELECT *
FROM Library.INFORMATION_SCHEMA.TABLES


SELECT name
FROM sys.tables


