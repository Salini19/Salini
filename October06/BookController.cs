using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using oct4_MVCapp.Models;

namespace oct4_MVCapp.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<BookModel> booklist = new List<BookModel>();
            booklist.Add(new BookModel { BookId = 1, BookName = "SitaRaman", Author = "Manu", Price = 750 });
            booklist.Add(new BookModel { BookId = 2, BookName = "Ponniyin Selvan", Author = "Manirathnam", Price = 1500 });
            booklist.Add(new BookModel { BookId = 3, BookName = "Viruma", Author = "Karthick", Price = 550 });
            booklist.Add(new BookModel { BookId = 4, BookName = "Sakthi", Author = "Shiva", Price = 350 });

            ViewData["MyBooklist"]=booklist;
            return View();
        }
    }
}