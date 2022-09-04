using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Sep2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Category category1 = new Category();   
            category1.AddCategory(category1 ,1, "Table", "Wooden type tables are available");
            Category category2 = new Category();
            category2.AddCategory(category2, 2, "snacks", "all types of snacks are available");
            
            Category.DisplayDetails(category1);
            Category.DisplayDetails(category2);

            //using object
            Console.WriteLine("**************************************");
            Console.WriteLine("using Object");
            Product product1 = new Product(1,"Sofa",650,7906,"kg",79,90);
            Console.WriteLine("ProdctID : " + product1.ProductID);
            Console.WriteLine("ProductName : " + product1.ProductName);
            Console.WriteLine("QtySOld : " + product1.QtySold);
            Console.WriteLine("UnitPrice : " + product1.UnitPrice);
            Console.WriteLine("UnitOFMeasurement : " + product1.UnitOFMeasurement);
            Console.WriteLine("QtyInHand : " + product1.QtyInHand);
            Console.WriteLine("Reoderlevel : " + product1.ReorderLevel);
            Console.WriteLine("*****************************************");




            Console.ReadLine();
        }
    }
}
