using oct4_MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace oct4_MVCapp.Controllers
{
    public class CustomerController : Controller
    {
        static List<CustModel> clist = new List<CustModel>();
        static CustomerController()
        {
            clist.Add(new CustModel { Custid = 1, Custname = "Salini", City = "pune", RegistrationTime = new DateTime(2022, 02, 05) });
            clist.Add(new CustModel { Custid = 2, Custname = "Sameer", City = "Bangalore", RegistrationTime = new DateTime(2022, 05, 05) });
            clist.Add(new CustModel { Custid = 3, Custname = "Thaswanth", City = "Chennai", RegistrationTime = new DateTime(2022, 09, 03) });
        }
        // GET: Customer
        public ActionResult Index()
        {
          
            return View(clist);

        }
        //public ActionResult AddCustomer()
        //{
        //    return View();
        //}
        //public ActionResult DeleteCustomer()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult DeleteCustomer(int id)
        //{
        //    return View();
            //return Content("Customer deleted");
            //return Redirect("https://www.google.com");
            //return RedirectToAction("Index");
            //return RedirectToAction("Index", "Home");
        //}
        public ActionResult CustData()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CustData(int id, string name, string city)
        {
            CustModel c = new CustModel();
            c.Custid = id;
            c.Custname = name;
            c.City = city;
            //passing the values using the route parameter
            //route parameter is declared in Route.config(App_Start Folder)

            return RedirectToAction("FindCust", new { id = c.Custid, name = c.Custname });
        }


        public ActionResult FindCust(int id, string cname)
        {
            string s = null;
            string gotname = cname;
            if (id != 0)
            {
                s = "trying to find customer by its id";
            }
            return Content(s);
        }
        public ActionResult AcceptData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AcceptData(CustModel model)
        {
            //CustModel c = new CustModel();
            //c.Custid = model.Custid;
            //c.Custname = model.Custname;
            //c.City = model.City;
            //c.RegistrationTime = model.RegistrationTime;

            clist.Add(model);
            return View();
        }
        public ActionResult AddData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddData(FormCollection customer)
        {
            CustModel c = new CustModel();
            c.Custid = Convert.ToInt32(customer["Custid"]);
            c.Custname = Request.Form["Custname"].ToString();
            c.City = customer["City"].ToString();
            c.RegistrationTime = Convert.ToDateTime(customer["RegistrationTime"]);
            return View();
        }
        public ActionResult DeleteData(int id)
        {
            CustModel founddata = clist.Find(x => x.Custid == id);
            return View(founddata);
        }
        [HttpPost]
        public ActionResult DeleteData(int id,CustModel model)
        {
            CustModel founddata = clist.Find(x => x.Custid == id);
            clist.Remove(founddata);
            return View(founddata);
        }
        public ActionResult CustDetails(int id)
        {
            CustModel founddata = clist.Find(x => x.Custid == id);
            return View(founddata);
        }
        public ActionResult NowEditOrderDetails(int id)
        {
            CustModel foundData = clist.Find(customer => customer.Custid == id);


            return View(foundData);
        }

        [HttpPost]

        public ActionResult NowEditOrderDetails(int id, CustModel m)
        {
            CustModel foundData = clist.Find(customer => customer.Custid == id);
            clist.Remove(foundData);
            clist.Add(m);
            return RedirectToAction("Index");
        }
    }
}