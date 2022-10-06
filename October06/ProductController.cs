using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using oct4_MVCapp.Models;

namespace oct4_MVCapp.Controllers
{
    public class ProductController : Controller
    {
        static List<ProductModel> prodlist = new List<ProductModel>();
        static ProductController()
        {
            prodlist.Add(new ProductModel { ProductId = 1, ProductName = "Table", ManufacturedDate = new DateTime(2022, 05, 21) });
            prodlist.Add(new ProductModel { ProductId = 2, ProductName = "Chair", ManufacturedDate = new DateTime(2022, 02, 05) });
            prodlist.Add(new ProductModel { ProductId = 3, ProductName = "Bench", ManufacturedDate = new DateTime(2022, 09, 11) });
        }
        // GET: Product

       

        public ActionResult Index()
        {
            return View(prodlist);
        }
        public ActionResult SearchProd(int id)
        {
            ProductModel foundproduct = prodlist.Find(x => x.ProductId == id);
            return View(foundproduct);
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(ProductModel model)
        {
            prodlist.Add(model);
            return View();
        }
        public ActionResult EditProdDetails(int id)
        {
            ProductModel foundprod=prodlist.Find(x => x.ProductId == id);
            return View(foundprod);
        }
        [HttpPost]
        public ActionResult EditProdDetails(int id,ProductModel model)
        {
            ProductModel foundprod = prodlist.Find(x => x.ProductId == id);
            prodlist.Remove(foundprod);
            prodlist.Add(model);
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteProd(int id)
        {
            ProductModel foundprod = prodlist.Find(x => x.ProductId == id);
            prodlist.Remove(foundprod);
            return View();
        }
        public ActionResult ProdInsert(FormCollection Product)
        {
            ProductModel p = new ProductModel();
            p.ProductId = Convert.ToInt32(Product["ProductId"]);
            p.ProductName = Product["ProductName"].ToString();
            p.ManufacturedDate = Convert.ToDateTime(Product["ManufaturedDate"]);

            prodlist.Add(p);
            return View();
        }
    }
}