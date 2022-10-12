using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL_Library;
using DAL_Library;
using LibraryWebApi.Models;

namespace LibraryWebApi.Controllers
{
    
    public class BookController : ApiController
    {
        BookOperations op = null;
        public BookController()
        {
            op = new BookOperations();
        }
        // GET api/<controller>
        public List<BookModel> GetBookList()
        {
            var list = op.GetBooks();
            List<BookModel> books = new List<BookModel>();
            foreach (var item in list)
            {
                books.Add(new BookModel {BookNo=item.BookNo ,BookName=item.BookName,Author=item.Author,Cost=item.Cost,Category=item.Category});
            }
            return books;
        }

        // GET api/<controller>/5
        //public BookModel GetBookById(int id)
        //{
        //    Book_BAL bal = new Book_BAL();
        //    op.FindBook(id);
        //    BookModel book = new BookModel();
        //    bal.BookNo = book.BookNo;
        //    bal.BookName = book.BookName;
        //    bal.Author = book.Author;
        //    bal.Category = book.Category;
        //    bal.Cost = book.Cost;

        //    return book;
        //}

        // POST api/<controller>
        public void Post([FromBody] BookModel book)
        {
            Book_BAL bal = new Book_BAL();

            bal.BookNo = book.BookNo;
            bal.BookName = book.BookName;
            bal.Author = book.Author;
            bal.Category = book.Category;
            bal.Cost = book.Cost;

            op.InsertBook(bal);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] BookModel book)
        {
            Book_BAL bal = new Book_BAL();

            bal.BookNo = book.BookNo;
            bal.BookName = book.BookName;
            bal.Author = book.Author;
            bal.Category = book.Category;
            bal.Cost = book.Cost;

            op.UpdateBook(bal);

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            op.DeleteBook(id);
        }
    }
}