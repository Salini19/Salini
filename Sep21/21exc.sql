use Library

--1)	List the various categories and count of books in each category.
select category,count(Book_No)'no of Books' from book
group by Category

--2)	List the book_No and the number of times the book is issued in the descending order of count.

select Book_No, count(book_no) 'no of times the book is issued'from Issue
group by book_no
order by COUNT(book_no) desc

--3)	Find the maximum, minimum, total and average penalty amount in the member table.

select max(penalty_amount)'Max penalty',
min(penalty_amount)'min penalty',
sum(penalty_amount)'total penalty',
avg(penalty_amount)'avg penalty'
from Member

--4)	Display the member id and the no of books for each member that has issued more then 2 books.

insert into issue values(7006,107,5,'2008-11-21',null)
insert into issue values(7008,103,4,'2008-02-21',null)

select MemberId,count(Book_No) 'no of books' from Issue
group by MemberId
having count(Book_No)>=2

select * from issue

--5)	Display the member id, book no and no of times the same book is issued by the member in the descending order of count.

select memberid,Book_No,count(book_No) 'no of times book was issued' from issue
group by MemberId,Book_No
order by count(book_no) desc

--6)	Display the month and no of books issued each month in the descending order of count.

select DATEPART(month,issue_date)'month',count(book_no)'books issued' from issue
group by Issue_Date
order by COUNT(book_no) desc

--7)	  List the book_no of all the books that are not issued to any member so far. 
select * from issue
insert into issue values(7007,106,4,null,null)
insert into issue values(7009,102,3,null,null)

select book_no from issue
where Issue_Date is null

--8) List all the member id that exist in member table and has also at least one book issued by them. 
select * from member

select m.MemberId  from Member m
left outer join issue i 
on m.MemberId=i.MemberId
group by m.MemberId
having count(i.book_no) >=1

--9)	List the member ID with highest and lowest no of books issued. 

select m.memberId , min(i.book_no),max(i.book_no) from Member m
left outer join issue i
on m.MemberId=i.MemberId
group by m.MemberId

--10)  List all the Issue_details for books issued in December and July without using any arithmetic, Logical or comparison operator.

select * from issue
where month(Issue_Date)='12' or month(Issue_Date)='6'

--11)	 List the Book_No, Book_Name and Issue_date for all the books that are issued in month of December and belong to category Database.

select b.Book_no,b.Book_name,i.Issue_date from book b
join issue i 
on b.Book_No=i.Book_No
where MONTH( i.Issue_Date)='12' and b.Category='database'

--12)	 List the Member Id, Member Name and No of books Issued in the descending order of the count.

select m.MemberId,m.Member_Name,count(i.Book_no)'no of books issued' from Member m
join issue i
on m.MemberId=i.MemberId
group by m.MemberId,m.Member_Name
order by COUNT(i.book_no) desc

--13)	List the Book No, Book Name, Issue_date and Return_Date for all the books issued by Richa Sharma.

select b.Book_No,b.Book_Name,i.Issue_Date,i.Return_Date from book b
join issue i on b.Book_No=i.Book_No
join Member m on i.MemberId=m.MemberId
where m.Member_Name='Richa Sharma'

select * from Member
insert into issue values(7010,104,1,'2009-08-18','2009-11-21')
insert into issue values(7011,103,1,'2007-11-18','2007-11-30')

--14)	List the details of all the members that have issued books in Database category.

select m.* from Member m left outer join issue i on m.MemberId=i.MemberId
left outer join book b on b.Book_No=i.Book_No
where b.Category='database'

--15)	List all the books that have highest price in their own category.
select Category,max(cost)'highest price' from Book
group by Category


--16)	List all the Issue_Details where Issue_date is not within the Acc_open_date and Return_date for that member.

select i.* from issue i 
left outer join Member m on m.MemberId=i.MemberId
where Issue_Date not between m.Acc_Open_Date and i.Return_Date

--17)	List all the members that have not issued a single book so far.

select m.MemberId,m.Member_Name from Member m 
left outer join issue i on i.MemberId=m.MemberId
group by m.MemberId,m.Member_Name
having COUNT(i.Book_No)=0

select * from Member
insert into Member values(6,'Sunil sharma','2008-12-28',4,310)

--18)	List all the Members where No of books Issued exceeds the Max No of books allowed.

select m.Member_Name,m.Max_Books_Allowed,count(i.book_no)'books issued' from member m
left outer join issue i on m.MemberId=i.MemberId
group by Member_Name,m.Max_Books_Allowed
having count(i.book_no) > m.Max_Books_Allowed

select * from issue
select * from Member
insert into issue values(7012,103,2,'2006-12-31','2007-01-28')
insert into issue values(7013,104,2,'2006-11-30','2006-12-28')

--19)	List all the members that have issued the same book as issued by Garima.


--20)	List the Book_Name, Price of all the books that are not returned for more then 30 days.

select b.book_name, b.cost from book b
left outer join issue i on i.Book_No=b.Book_No
where datediff(day,Issue_Date,getdate()) >30 and Return_Date is null

select * from issue
select * from Book

--21)	List all the authors and book_name that has more then 1 book written by them.

select Author ,Book_Name from Book
group by Author,Book_Name
having COUNT(DISTINCT (author)) > 1
--having COUNT(Book_Name)>1

--22)	List the Member ID, Member Name of the people that have issued the highest and the lowest no of books.
--23)	List the details of highest 3 priced books.

--24)	List the total cost of all the books that are currently issued but not returned.

select sum(b.cost)'total cost' from book b
left outer join issue i on i.Book_No=b.Book_No
where i.Return_Date is null and i.issue_date is not null

select * from issue

--25)	List the details of the book that has been issued maximum no of times


