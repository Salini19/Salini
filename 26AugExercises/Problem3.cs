using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ArrayObjLibrary;

namespace Aug26
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
           List<Product> productlist = new List<Product>();

            productlist.Add(new Product { ProductID = 1, ProductName = "Table", ProductPrice = 1900 });
            productlist.Add(new Product { ProductID = 2, ProductName = "Aircooler", ProductPrice = 13000 });
            Console.WriteLine("Enter  1.ShowProductList  2.Add Product 3.Remove Product ");
            int options= Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Product Details:");
                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.ProductID);
                        Console.WriteLine("ProductName : " + item.ProductName);
                        Console.WriteLine("ProductPrice : " + item.ProductPrice);
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("enter the length of Product list you want to add");
                    int n = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = 0; i < n; i++)
                    {
                        Product products = new Product();
                        Console.WriteLine("Enter the ProductID");
                        products.ProductID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Product Name");
                        products.ProductName = Console.ReadLine();
                        Console.WriteLine("Enter the Price of the product");
                        products.ProductPrice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------");
                        productlist.Add(products);
                    }
                    Console.WriteLine("Product Details:");

                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.ProductID);
                        Console.WriteLine("ProductName : " + item.ProductName);
                        Console.WriteLine("ProductPrice : " + item.ProductPrice);
                        Console.WriteLine();
                    }
                    break;
                 
                case 3:
                    Console.WriteLine("Product List:");
                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.ProductID);
                        Console.WriteLine("ProductName : " + item.ProductName);
                        Console.WriteLine("ProductPrice : " + item.ProductPrice);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Enter the index of product You want to remove");
                    int num=Convert.ToInt32(Console.ReadLine());
                    productlist.RemoveAt(num);

                    Console.WriteLine("Product is successfully deleted");
                    Console.WriteLine("Edited Product Details");
                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.ProductID);
                        Console.WriteLine("ProductName : " + item.ProductName);
                        Console.WriteLine("ProductPrice : " + item.ProductPrice);
                        Console.WriteLine();
                    }
                   
                    break;
            }
            
           

            
            Console.ReadLine();          
        }      
        
    }
}
