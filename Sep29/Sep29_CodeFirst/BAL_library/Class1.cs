using DAL_Library;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_library
{
    public class Book_BAL
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Cost { get; set; }
        public string Category { get; set; }
    }
    public class BookOperations
    {
        MyBooks context = new MyBooks();

        public void AddBooks(Book_BAL bal)
        {
            Book b = new Book();
            b.BookID = bal.BookID;
            b.BookName = bal.BookName;
            b.Author = bal.Author;
            b.Cost = bal.Cost;
            b.Category = bal.Category;

            context.Booktable.Add(b);
            context.SaveChanges();
        }
    }
}
