using BAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep29_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookOperations bp = new BookOperations();
            Book_BAL book = new Book_BAL();
            Console.WriteLine("Enter BookNo");
            book.BookID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter BookName");
            book.BookName = Console.ReadLine().Trim();
            Console.WriteLine("Enter Author");
            book.Author = Console.ReadLine().Trim();
            Console.WriteLine("Enter BookPrice");
            book.Cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category");
            book.Category = Console.ReadLine().Trim();

            bp.AddBooks(book);
            Console.WriteLine();
            Console.WriteLine("Book added Successfully");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
