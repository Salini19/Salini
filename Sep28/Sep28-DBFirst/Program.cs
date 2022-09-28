using BAL_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep28_DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 Insert 2 Update 3 Delete 4 Showlist 5 BookCount 6 Exit");
            int choice = int.Parse(Console.ReadLine());
            BookOperations op = new BookOperations();
            List<Book_BAL> booklist = new List<Book_BAL>();
            Book_BAL book = new Book_BAL();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter BookNo");
                    book.BookNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter BookName");
                    book.BookName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Author");
                    book.Author = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Category");
                    book.Category = Console.ReadLine().Trim();

                    op.InsertBook(book);
                    Console.WriteLine();
                    Console.WriteLine("Book added Successfully");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter BookNo");
                    book.BookNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter BookName");
                    book.BookName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Author");
                    book.Author = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Category");
                    book.Category = Console.ReadLine().Trim();

                    op.UpdateBook(book);
                    Console.WriteLine("Book Updated Successfully");
                    Console.WriteLine();

                    break;
                case 3:
                    Console.WriteLine("Enter BookNo");
                    int BookNo = int.Parse(Console.ReadLine());

                    op.DeleteBook(BookNo);
                    Console.WriteLine();
                    Console.WriteLine("Deleted Successfully");
                    break;
                case 4:

                    booklist= op.GetBooks();
                    foreach (var item in booklist)
                    {
                        Console.WriteLine(item.BookNo);
                        Console.WriteLine(item.BookName);
                        Console.WriteLine(item.Author);
                        Console.WriteLine(item.Category);
                        Console.WriteLine();

                    } 
                    break;
                case 5:
                    int count=op.BookCount();
                    Console.WriteLine("Count of Books : "+count);
                    break;

                case 6:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            
            
            Console.ReadLine();
        }
    }
}
