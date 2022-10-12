using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oct11_Core.Models;
using System.Reflection;
using System.Security.Cryptography;

namespace Oct11_Core.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransientService _transientservice1;
        private readonly ITransientService _transientservice2;
        private readonly ITransientService _transientservice3;
        private readonly ISingletonService _singletonService;
       

        public ProductController(ILogger<HomeController> logger,ISingletonService s1, ITransientService t1 ,ITransientService t2,ITransientService t3)
          
        {
            _logger = logger;
            _transientservice1 = t1;
            _transientservice2 = t2;
            _transientservice3 = t3;
            _singletonService = s1;
            prodlist.Add(new Product { ProductId = _transientservice1.GetProductId(), ProductName = "Table", ManufacturedDate = new DateTime(2022, 05, 21) });
            prodlist.Add(new Product { ProductId = _transientservice2.GetProductId(), ProductName = "Chair", ManufacturedDate = new DateTime(2022, 02, 05) });
            prodlist.Add(new Product { ProductId = _transientservice3.GetProductId(), ProductName = "Bench", ManufacturedDate = new DateTime(2022, 09, 11) });
            prodlist.Add(new Product { ProductId = 1, ProductName = "mobile", ManufacturedDate = new DateTime(2022, 10, 02) });

        }
        public List<Product> prodlist = new List<Product>();
       
        // GET: ProductController
        public ActionResult Index()
        {
            
           
            return View(prodlist);
        }
        

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            //List<Product> prodlist = new List<Product>();
            Product foundproduct1 = new Product();
            if (id != null)
            {
                foundproduct1 = prodlist.Find(x => x.ProductId == id)!;
                return View(foundproduct1);
            }
            else {
                foundproduct1 = prodlist.Find(x => x.ProductId == _singletonService.DefaultID())!;
                return View(foundproduct1); 
            }


                //Product 



            }

            // GET: ProductController/Create
            public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {
            try
            {
                prodlist.Add(model);
              
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            Product foundprod = prodlist.Find(x => x.ProductId == id)!;
            return View(foundprod);
            
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {
            try
            {
                Product foundprod = prodlist.Find(x => x.ProductId == id)!;
                prodlist.Remove(foundprod);
                prodlist.Add(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            Product foundprod = prodlist.Find(x => x.ProductId == id)!;
            return View(foundprod);
            
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Product foundprod = prodlist.Find(x => x.ProductId == id)!;
                prodlist.Remove(foundprod);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
