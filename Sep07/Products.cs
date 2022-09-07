using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Products;

namespace ClassLibrary1
{
    public delegate void displaydel(Products p);
    public class Products
    {


        private int _productid;

        public int ProductId
        {
            get { return _productid; }
            set { _productid = value; }
        }

        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }

        public void Displaydetails(Products product)
        {
            Console.WriteLine("ProductID   : " + product.ProductId);
            Console.WriteLine("ProductName : " + product.ProductName);
        }
    }
}
