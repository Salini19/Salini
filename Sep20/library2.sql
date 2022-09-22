use Library

--1.List all the members that became the member in the year 2006.

select * from Member
where Acc_Open_Date like 2006

select * from Member

--2) List all the books that are written by Author Loni and has price less then 600.

select * from Book
where Author='Loni'

--3) List the Issue details for the books that are not returned yet.

select * from Issue
where RETURN_DATE IS NULL ;

--4) Update all the blank return_date with 31-Dec-06 excluding 7005 and 7006.

update Issue
set Return_Date = '2006-12-31'
where lib_issue_id !=7005 and lib_issue_id !=7006

--5) List all the Issue details that have books issued for more then 30 days.

select * from Issue
where datediff(dd,Return_Date,Issue_Date) >30

--6) List all the books that have price in range of 500 to 750 and has category as Database.

select * from Book
where Cost between 500 and 750 and Category= 'database'

--7) List all the books that belong to any one of the following categories Science, Database, Fiction, Management.

select * from Book
where Category in ('Science' ,'database' ,'fiction' ,'management')

--8) List all the members in the descending order of Penalty due on them.

select * from Member
order by Penalty_Amount desc

--9) List all the books in ascending order of category and descending order of price.

select * from book
order by Category ,cost desc

--10) List all the books that contain word SQL in the name of the book

select * from Book
where Book_Name like '%SQL%'

--11) List all the members whose name starts with R or G and contains letter I in it.

select * from Member
where Member_Name like 'R%' or Member_Name like 'G%' and Member_Name like '%I%'

--12) List the entire book name in Init cap and author in upper case in the descending order of the book name.

select UPPER(Author) as Author from Book
order by Book_Name desc

--13) Show the data in the following format :

select Book_No,'Is written by' as '-------------',Author from Book

--14) List the Issue Details for all the books issue by member 101 with Issue_date and Return Date in following format. ‘Monday,July, 10, 2006’.




--15) List the data in the book table with category data displayed as D for Database, S for Science, R for RDBMS and O for all the others.

--17) Display the book name, Author name with spaces padded with *.
select Book_Name,Author from Book

--18) List the Lib_Issue_Id, Issue_Date, Return_Date and No of days Book was issued.

select Lib_Issue_Id,Issue_Date,Return_Date,datediff(dd,Issue_Date,Return_Date) as 'No of days book was issued' from Issue

--19) Find the details of the member of the Library in the order of their joining the library.

select * from Member
order by Acc_Open_Date

--20) Display the count of total no of books issued to Member 101.

select COUNT(Book_No) from issue
where MemberId=1

--21) Display the total penalty due for all the members.

select sum(penalty_amount) from Member

--22) Find the total cost of all the books that come under category Database.

select sum(cost) from Book
where Category='database'

--23) Find the cheapest book price in the library.

select min(cost) from book

--24) Find the date on which the very first book was issued in the library.

select min(Issue_date) from issue

--25) Find the date on which most recent the book was issued.

select max(Issue_date)  from Issue

--26) Find the average price of book in Database category.

select AVG(cost) as 'Average Price' from Book
where Category='database'