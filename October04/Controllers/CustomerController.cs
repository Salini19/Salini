using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oct4_MVCapp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddCustomer()
        {
            return View();
        }
        public ActionResult DeleteCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteCustomer(int id)
        {
            return View();
            //return Content("Customer deleted");
            //return Redirect("https://www.google.com");
            //return RedirectToAction("Index");
            //return RedirectToAction("Index", "Home");
        }

    }
}