using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLvalidation;
using DAL_libarary;

namespace HelperLibrary
{
    public class Helper_prod
    {
        public List<Bl_products> GetProducts()
        {
            Dal_prod products = new Dal_prod();
            List<Bl_products> prods=new List<Bl_products>();
            prods=products.ShowAllProducts();
            return prods;
        }
    }
}
