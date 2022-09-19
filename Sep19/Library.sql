create database Library

use Library

create table Member
(
MemberId int primary key,
MemberName char(25),
AccOpenDate Date,
MaxbooksAllowed int,
penaltyAmount int)

create table Book
(
BookNo int primary key,
BookName varchar(30),
Author char(30),
Cost int,
Category char(10)
)

create Table Issue
(
LibIssueId int, 
BookNo int,
MemberId int,
IssueDate Date,
returnDate Date
)

alter table Issue
add foreign key(MemberId) references Member(Memberid)


alter table Issue
add foreign key(BookNo) references Book(BookNo)
