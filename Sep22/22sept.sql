use Library

--1)	Create table Member_C with following constraints.
create table Member_C
(
Member_Id int Primary Key,
Acc_Open_Date date constraint d_accopendate default getdate(),
Max_Allowed_Books int constraint ch_maxbooks
check (max_allowed_Books < 100),
Penalty money constraint ch_penalty
check (penalty <1000)
);



--2)	Create table Book_C with following constraints.
Create table Book_C 
(
Book_No int Primary Key,
Book_Name varchar(30) Not Null,
Category varchar(25) 
);

--3)	Create table Issue_C with following constraints.
Create table Issue_C 
(
Lib_Issue_Id int Primary Key,
Member_Id int constraint fk_member Foreign Key references Member_c(member_id),
Book_No int constraint fk_book Foreign key references Book_c(Book_no),
Issue_Date date,
Return_date date,
constraint ch_date check (Issue_date < Return_date)
);

--4)	Add a constraint Price < 2500 to Book table.

alter table Book_c
add price numeric(7,2)  check(price<2500) ;


select * from Book_C
--5)	View all the constraints for table Issue_C using view User_Constraints.

create view User_Constraints
as
select  CONSTRAINT_TYPE,CONSTRAINT_NAME
From INFORMATION_SCHEMA.TABLE_CONSTRAINTS
Where TABLE_NAME='Issue_C';
go

select * from USer_constraints

exec sp_helpconstraint Issue_C

--6)	Disable constraint created in step 3-d

Alter table Issue_C
nocheck Constraint Ch_date

--7)	Create a Read Only view to display Lib_Issue_Id, Book_Name, Member_Name, Author and Issue_date for all the books that have price between 500 – 750 and category as Database or RDBMS.
insert into Member_C values(1,'2012-04-13',45,250),
(2,GETDATE(),3,NULL),
(3,Null,4,79.80),
(4,GETDATE(),null,56),
(5,'2018-06-09',4,50),
(6,'2005-12-10',5,50)


insert into Book_C values(101,'SQL help','RDBMS',250),
(102,'Oracle-complete Ref','Database',550),
(103,'Mastering SQL','Database',250),
(104,'PL SQL-Ref','Database',750),
(105,'Let us C','Science',450)

Insert into Issue_C values(7001,1,101,'2006-12-10',null),
(7002,2,102,'2006-12-25',null),
(7003,1,104,'2006-01-15',null),
(7004,1,101,'2006-06-04',null),
(7005,2,104,'2006-11-15',null),
(7006,3,103,'2006-02-18',null)

create view review1 
as
select distinct Lib_Issue_Id,Book_Name,I.Member_Id,Issue_Date from Member_C M inner join Issue_C I
on M.Member_Id=I.Member_Id INNER JOIN Book_C B on I.Book_No = B.Book_No
where Price Between 500 and 750
go 

select* from review1

--8)	Create a view with check option to display all the books that has price greater then 500.

create view Pricegreaterthan500 
as
select Book_No,Book_Name,Category,Price from Book_C
where Price >500
go

select* from Pricegreaterthan500


--9)	Perform DML operations to the view and evaluate the effect of Check Option

insert into Pricegreaterthan500(Book_No,Book_Name) values(107,'Helo RDBMS')

Update Pricegreaterthan500 set Category='RDBMS' where Book_No = 102;
go

delete Issue_C where Book_No=104
delete Pricegreaterthan500 where Book_No = 104
go

--10)	Create Index on Book_Name in book table.

create Index Bookname on Book_C(Book_Name)

--11)	Create Index on Member_Id, Book_No in Issue table.

create Index indexmembook on Issue_C(Member_Id,Book_No)

--12)	State difference between Index vs Unique Index.

-- unique index are like primary keys the data should be unique


--13)	Do we need to create index on Member_Id in Member_C table if not, state the reason for the same.

create Index index3 on Member_C(Member_Id)

--Member ID is already a primary key Therefore no need of creating a index for that

SELECT * 
FROM sys.indexes 
WHERE name='bookname' AND object_id = OBJECT_ID('Book_C')