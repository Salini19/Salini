using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUDwithLibDB.Models;

namespace CRUDwithLibDB.Controllers
{
    public class IssuesController : Controller
    {
        private LibraryEntities db = new LibraryEntities();

        // GET: Issues
        public ActionResult Index()
        {
            var issues = db.Issues.Include(i => i.Book).Include(i => i.Member);
            return View(issues.ToList());
        }

        // GET: Issues/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue issue = db.Issues.Find(id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            return View(issue);
        }

        // GET: Issues/Create
        public ActionResult Create()
        {
            ViewBag.Book_No = new SelectList(db.Books, "Book_No", "Book_Name");
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "Member_Name");
            return View();
        }

        // POST: Issues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Lib_Issue_Id,Book_No,MemberId,Issue_Date,Return_Date,status")] Issue issue)
        {
            if (ModelState.IsValid)
            {
                db.Issues.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Book_No = new SelectList(db.Books, "Book_No", "Book_Name", issue.Book_No);
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "Member_Name", issue.MemberId);
            return View(issue);
        }

        // GET: Issues/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue issue = db.Issues.Find(id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            ViewBag.Book_No = new SelectList(db.Books, "Book_No", "Book_Name", issue.Book_No);
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "Member_Name", issue.MemberId);
            return View(issue);
        }

        // POST: Issues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Lib_Issue_Id,Book_No,MemberId,Issue_Date,Return_Date,status")] Issue issue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Book_No = new SelectList(db.Books, "Book_No", "Book_Name", issue.Book_No);
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "Member_Name", issue.MemberId);
            return View(issue);
        }

        // GET: Issues/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issue issue = db.Issues.Find(id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            return View(issue);
        }

        // POST: Issues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            Issue issue = db.Issues.Find(id);
            db.Issues.Remove(issue);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
