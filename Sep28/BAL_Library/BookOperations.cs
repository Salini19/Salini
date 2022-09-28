using DAL_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_Library
{
    public class BookOperations
    {
        public List<Book_BAL> GetBooks()
        {
            LibraryEntities context = new LibraryEntities();
            List<Book> books= context.Books.ToList();
            List<Book_BAL> booklist = new List<Book_BAL>();

            foreach (var item in books)
            {
                booklist.Add(new Book_BAL
                {
                    BookNo = item.Book_No,
                    BookName = item.Book_Name,
                    Author = item.Author,
                    Category = item.Category
                });
            }
            return booklist;
        }
        public void InsertBook(Book_BAL bal)
        {
            LibraryEntities context = new LibraryEntities();
            Book b = new Book();

            b.Book_No = bal.BookNo;
            b.Book_Name = bal.BookName;
            b.Author = bal.Author;
            b.Category = bal.Category;

            context.Books.Add(b);
            context.SaveChanges();

        }
        public void UpdateBook(Book_BAL bal)
        {
            LibraryEntities context = new LibraryEntities();

            List<Book> booklist = context.Books.ToList();
            Book b = booklist.Find(x => x.Book_No == bal.BookNo);
            b.Book_Name = bal.BookName;
            b.Author = bal.Author;
            b.Category = bal.Category;
            context.SaveChanges();

           

        }
        public void DeleteBook(decimal bookno)
        {
            LibraryEntities context = new LibraryEntities();
            context.sp_DeleteBook(bookno);
            context.SaveChanges();
        }
        public int BookCount()
        {
            LibraryEntities context = new LibraryEntities();
            int count =context.Books.Count();
            return count;
        }
    }
}
