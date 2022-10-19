using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SpecFlowProject1
{
    public class Class1
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public double Sqrroot(double i)
        {

            return i != 0 ? Math.Sqrt(i) : 0;
        }
    }
    public class Login
    {
        public string? Userid { get; set; }
        public string? Passwrod { get; set; }

        public string login()
        {
            string s;
            if (Userid=="Salini" && Passwrod=="Shalu@123")
            {
               s = "Successfully Loggedin";
            }
            else
            {
                s = "Invalid Credentials";
            }
            return s;
        }
    }
    public class Product
    {
        //AddProductToCart--- prodname not null or empty and qty >0
        public int ProdId { get; set; }
        public string? ProdName { get; set; }
        public int Quantity { get; set; }

        public string AddProduct(Product p)
        {
            List<Product> products = new List<Product>();   
            string s;
            if (!string.IsNullOrEmpty(ProdName) && Quantity > 0)
            {
                products.Add(p);
            }
            if (products.Count > 0)
            {
                s = "Added to Cart";
            }
            else
            {
                s = "Enter valid details";
            }
            return s;
        }
        
    }

}
