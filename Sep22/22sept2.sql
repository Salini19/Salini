use pubs

--1) write a program to concat firstname and last name and print the concatenated String.

declare 
@str1 varchar(30) = 'Hello',
@str2 varchar(30) = 'Everyone',
@ans varchar(30)
begin
set @ans = CONCAT(@str1,' ',@str2) 
print @ans
end

--2)Write a batch that will check for the existence of the title “The Gourment Microwave” If it exists, print the cost of the book else display “Not Found”.

declare @title varchar(35)= 'The Gourmet Microwave',
@price money
if @title = 'The Gourmet Microwave'
begin 
select @price=price from titles where title = @title
print @price
end
else
begin
print 'Not found'
end

--3)Write a batch to display the titles of all the Psychology books if the average price of books is more than $15. Display the appropriate output.

declare
@title1 varchar(70),
@type varchar(30),
@price1 money
 begin
 select @title1=title,@type=[type], @price1=avg(price) from titles
 group by [type],price,title
 having avg(price)>15 and [type]='Psychology'
 print @title1
 print @type
 print @price1
 end

--4)Write a procedure which accepts the city name as a parameter and displays the names of publishers residing in the city

CREATE PROCEDURE Displaypublisherbycity
	@p_city varchar(20)
AS
BEGIN

	SELECT pub_name from publishers
	where @p_city=city
END

exec Displaypublisherbycity 'New York'


--5) Write a procedure which accepts the title_id as a parameter and displays the number of orders placed for the book.

CREATE PROCEDURE  displayordersbyid
	@t_id varchar(6)
AS
BEGIN

	SELECT title_id,sum(qty) as quantity from sales 
	group by title_id
	having @t_id=title_id
END

exec displayordersbyid PS2091

--6)Write a procedure which displays store names and the number of orders placed by the each store.

CREATE procedure Displaystorenames
AS
BEGIN
 SELECT stor_name,sum(qty) as 'number of orders' from stores join sales on sales.stor_id=stores.stor_id
 group by stor_name
 END

 EXEC Displaystorenames


--7)Write a procedure that take a title_id as a parameter and returns the number of orders placed for the book. Define two parameters @in_tid as an ordinary parameter and @tot_orders as a return parameter. 

ALTER procedure displayorders
 @int_tid varchar(6),
 @tot_orders smallint
 as
 begin
 select @tot_orders=sum(qty) from sales
 group by title_id
 having @int_tid=title_id

 return @tot_orders
 end

 declare @orders smallint
 exec disdisplayorders Ps2091,@tot_orders = @orders output select @orders as tot_orders
 go


--8)Writea User Defined Function to get the number of working days between two dates.Assume Saturaday and Sunday as holidays.

CREATE FUNCTION ShowWorkingDate
(
	@start_date date,@end_date date
)
RETURNS int
AS
BEGIN
	DECLARE @workingdays int=0;
	while(@start_date <=@end_date)
 begin
 if Datename(weekday,@start_date)in ('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday')
 begin 
 set @workingdays=@workingdays+1;
 end
 set @start_date=DATEADD(day,1,@start_date)
 end
 return @workingdays
 END

 print [dbo].[ShowWorkingDate] ('2022-07-16',getdate())

--9)Write a function that can calculate the yearly salary of a job if an applicant is    given the hourly salary. Consider that the yearly salary is based on 40 hours a week. In your function, if the hourly salary is given as a negative value, don't perform the calculation 
  go
  CREATE FUNCTION CalculateSalary(@hoursal money)
  returns money
  BEGIN
  DECLARE @yearsal money=0
  if(@hoursal>0)
  begin
  set @yearsal=40*@hoursal*52
  end
  else
  begin
  set @yearsal=0
  end
 return @yearsal
  END
  go

  print [dbo].[Calculatesalary] (100)
  go


--10)Write a  function that processes a cylinder. It calculates and displays the diameter of the base, the circumference of the base, the base area, the side area, the total area, and the volume, given the radius and the height of a cylinder 

CREATE FUNCTION Cylinder
(@radius numeric,@height numeric)
 returns @numeric
 as
 begin
 declare @dia numeric,@surface numeric
  set @dia = 2 * @radius
  set @surface= 2 * @radius * @radius * @height
  return 
  end




--11)You will create two new tables called NewCategories and NewProducts. Neither have the PRIMARY and FOREIGN KEY constraints of the Categories and Products tables. You will create a trigger on the NewCategories table. This trigger updates the Discontinued column in the NewProducts table whenever a category is deleted (whenever a record is deleted from the NewCategories table). All affected products are marked as 1, indicating that they are discontinued.


 use shopping

  create table NewCategories(
  catid int,
  catname varchar(20),
  )
  create table NewProducts(
  prodid int,
  prodname varchar(30),
  catid int)

  Insert into NewProducts values(101,'Rice',1),(102,'wheat',1),(103,'powder',2),(104,'slice',3),(105,'Cheetos',4),(106,'Fairness cream',2),
  (107,'dresses',5),(108,'Veggies',1)

  insert into NewCategories values(1,'Food'),(2,'skin care products'),(3,'liquids'),(4,'snacks'),(5,'others')


 
  create trigger deletecategory
  on NewCategories
  for delete
  as
  begin
  declare @id int
  select @id = catid from deleted
  update NewProducts
  set catid = 1,prodid = 1,prodname='1'
  where catid = @id
  end
  go

  select* from NewCategories
  select* from NewProducts
 
  

--13)You will create a DELETE trigger on the NewProducts table. This trigger determines whether an order history exists in the Order Details table before the trigger permits a deletion from the NewProducts table. 


CREATE TABLE Order_details(prodid int,deleted_by varchar(50),deleted_at datetime)
CREATE TABLE Order_details1(prodid int,inserted_by varchar(50),inserted_at datetime)


create trigger insertprod on NewProducts
for insert
as
begin
declare @id int
select @id=I.prodid from inserted I
insert into Order_details1 values(@id,'admin',getdate())
end
go


  create trigger deleteprod 
  on NewProducts
  instead of delete
  as
  begin
  declare @id int
  select @id = prodid from deleted
  update NewProducts
  set catid = 1,prodid = 1,prodname='1'
  where catid = @id
  end
  go

insert into NewProducts values(109,'something',5)
select*from NewProducts
select*from Order_details1

--14) Create a trigger on NewProducts table to restrict the deletion of more than 3 records at the same time

  create trigger deletecatval 
  on NewCategories
  for delete
  as
  begin
  declare @id int,@coun int
  select @coun = count(catid), @id = catid from deleted group by catid
  if(@coun<3)
  begin
  update NewProducts
  set catid = 1,prodid = 1,prodname='1'
  where catid = @id
  end
  else
  begin
  print 'More than 3 rows cant be deleted'
  end
  end
  go


  delete from  NewCategories
  where Catid = 1 and catid=2 and catid=3 and catid=4

  delete from  NewCategories
  where Catid = 1 

  select* from NewCategories
  select* from NewProducts




