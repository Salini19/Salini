using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Oct11_Core.Controllers;
using Oct11_Core.Models;


namespace Oct11_Core.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly IScopedService _scopedService3;
        private readonly IScopedService _scopedService4;

        public BookController(ILogger<BookController> logger,IScopedService s1,IScopedService s2,IScopedService s3,IScopedService s4)
        {
            _logger = logger;
            _scopedService1 = s1;
            _scopedService2 = s2;
            _scopedService3 = s3;
            _scopedService4 = s4;

        }
        // GET: Book
        public ActionResult Index()
        {
            List<BookModel> booklist = new List<BookModel>();
            booklist.Add(new BookModel { BookId = _scopedService1.GetProductId(), BookName = "SitaRaman", Author = "Manu", Price = 750 });
            booklist.Add(new BookModel { BookId = _scopedService2.GetProductId(), BookName = "Ponniyin Selvan", Author = "Manirathnam", Price = 1500 });
            booklist.Add(new BookModel { BookId = _scopedService3.GetProductId(), BookName = "Viruma", Author = "Karthick", Price = 550 });
            booklist.Add(new BookModel { BookId = _scopedService4.GetProductId(), BookName = "Sakthi", Author = "Shiva", Price = 350 });

            ViewData["MyBooklist"]=booklist;
            return View();
        }
    }
}