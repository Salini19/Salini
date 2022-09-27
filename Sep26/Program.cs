using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BLLlibrary;
using HelperLibrary;

namespace Sep26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BLL_Users user = new BLL_Users();
            BLL_Books book = new BLL_Books();
            BLL_Member member = new BLL_Member();
            BLL_Issue issue = new BLL_Issue();
            Helper_Books helper = new Helper_Books();
            Console.WriteLine("            Welcome To the Library");
            Console.WriteLine();
            Console.WriteLine("Enter userid");
            user.Userid = Console.ReadLine();
            Console.WriteLine("Enter password");
            user.Password = Console.ReadLine();
            helper.ValidateUser(user);

            Console.WriteLine();
            Console.WriteLine("Enter \n 1 AddBook   2 AddUSer   3 UpdateUser \n  5 ShowAllBooks 6 Borrow Book  7 Return Book");
            int choice = int.Parse(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter BookNo");
                    book.BookNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Bookname");
                    book.BookName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Author");
                    book.Author = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Cost");
                    book.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Category");
                    book.Category = Console.ReadLine();

                    bool queryStatus = helper.AddBook(book);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Memberid ");
                    member.MemberID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Membername");
                    member.MemberName= Console.ReadLine().Trim();
                    Console.WriteLine("Enter AccountOpen Date");
                    member.Acc_Open_Date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter Maximum allowed Books");
                    member.MaxBooksAllowed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Penalty Amount");
                    member.Penalty= Convert.ToInt32(Console.ReadLine());


                    queryStatus = helper.AddUser(member);
                    if (queryStatus)
                    {
                        Console.WriteLine("User addeed successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter Memberid ");
                    member.MemberID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Membername");
                    member.MemberName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter AccountOpen Date");
                    member.Acc_Open_Date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter Maximum allowed Books");
                    member.MaxBooksAllowed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Penalty Amount");
                    member.Penalty = Convert.ToInt32(Console.ReadLine());


                    queryStatus = helper.UpdateUser(member);
                    if (queryStatus)
                    {
                        Console.WriteLine("User updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                
                case 4:
                    List<BLL_Books> books = new List<BLL_Books>();
                    books=helper.Booklist();
                    foreach (var item in books)
                    {
                        Console.WriteLine(item.BookNo);
                        Console.WriteLine(item.BookName);
                        Console.WriteLine(item.Author);
                        Console.WriteLine(item.Cost);
                        Console.WriteLine(item.Category);
                        Console.WriteLine();

                    }

                    break;
                case 5:
                    Console.WriteLine("Enter LibraryIssueID ");
                    issue.Lib_Issue_Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter BookNo");
                    issue.Book_No = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter MemberID");
                    issue.Member_Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Issue Date");
                    issue.Issue_Date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter Return Date");
                    issue.Return_Date = Convert.ToDateTime(Console.ReadLine());
                    



                    queryStatus = helper.IssueBook(issue);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book Borrowed successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 6:
                    Console.WriteLine("Enter LibraryIssueID ");
                    issue.Lib_Issue_Id = Convert.ToInt32(Console.ReadLine());
                    queryStatus = helper.ReturnBook(issue);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book Returned successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            

            


            

            Console.ReadLine();
        }
    }
}
