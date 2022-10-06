using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using oct4_MVCapp.Models;

namespace oct4_MVCapp.Controllers
{
    public class IssuedBookController : Controller
    {
        // GET: IssuedBook
        public ActionResult Index()
        {
            List<IssuedBookModel> issuedBooks = new List<IssuedBookModel>();
            issuedBooks.Add(new IssuedBookModel { Lib_IssueId = 1, BookId = 1, MemberId = 1, IssueDate = new DateTime(2022, 05, 30), ReturnDate = new DateTime(2022, 09, 11) });
            issuedBooks.Add(new IssuedBookModel { Lib_IssueId = 2, BookId = 2, MemberId = 1, IssueDate = new DateTime(2022, 03, 11), ReturnDate = new DateTime(2022, 05, 11) });
            issuedBooks.Add(new IssuedBookModel { Lib_IssueId = 3, BookId = 3, MemberId = 2, IssueDate = new DateTime(2022, 08, 13), ReturnDate = new DateTime(2022, 10, 02) });
            TempData["IssueList"]= issuedBooks;
            return RedirectToAction("IssueBookList");
           
        }
        public ActionResult IssueBookList()
        {
            TempData["MyBag"] = TempData["IssueList"];
            return View();
        }
    }
}