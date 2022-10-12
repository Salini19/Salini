using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Oct11_Core.Models;

namespace Oct11_Core.Controllers
{
    public class MemberController : Controller
    {

        static List<MemberModel> memlist = new List<MemberModel>();
        private readonly ITransientService _transientService;

        public MemberController(ITransientService t1)
        {
            _transientService = t1;
        }


        // GET: Member
        static MemberController()
        {
            memlist.Add(new MemberModel { MemberId = 1, MemberName = "Sameer", AccountOpenDate = new DateTime(2022, 05, 11), MaxBooksAllowed = 7, Penalty = 100 });
            memlist.Add(new MemberModel { MemberId = 2, MemberName = "Salini", AccountOpenDate = new DateTime(2022, 11, 11), MaxBooksAllowed = 4, Penalty = 250 });
            memlist.Add(new MemberModel { MemberId = 3, MemberName = "Thashwanth", AccountOpenDate = new DateTime(2022, 09, 10), MaxBooksAllowed = 5, Penalty = 500 });
            memlist.Add(new MemberModel { MemberId = 4, MemberName = "Rubini", AccountOpenDate = new DateTime(2022, 01, 19), MaxBooksAllowed = 3, Penalty = 780 });
        }
      
        public ActionResult Index()
        {
            HttpContext.Session.SetInt32("MemberID", 10);
            HttpContext.Session.SetString("MemberName", "Shalini");
           
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Members", memlist);
            //ViewBag.Members=memlist;
            return View();
        }
        public ActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(MemberModel model)
        {
            model.MemberId = _transientService.GetProductId();
            memlist.Add(model);
            return RedirectToAction("Index");
        }
        public ActionResult RemoveMember(int id)
        {
            MemberModel foundmem= memlist.Find(x => x.MemberId == id)!;
            return View(foundmem);
        }
        [HttpPost]
        public ActionResult RemoveMember(int id,MemberModel m)
        {
            MemberModel foundmem = memlist.Find(x => x.MemberId == id)!;
            memlist.Remove(foundmem);
            return View();
        }
        public ActionResult EditMemberDetails(int id)
        {
            MemberModel foundmem = memlist.Find(x => x.MemberId == id)!;
            return View(foundmem);
        }
        [HttpPost]
        public ActionResult EditMemberDetails(int id,MemberModel m)
        {
            MemberModel foundmem = memlist.Find(x => x.MemberId == id)!;
            memlist.Remove(foundmem);
            memlist.Add(m);
            return View();
        }
        public ActionResult GetAlMembers()
        {
            return View(memlist);
           
        }
        public ActionResult Details( int id)
        {
            MemberModel foundmem = memlist.Find(x => x.MemberId == id)!;
            return View(foundmem);
        }
    }
}
