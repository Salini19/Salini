using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Category
    {
		private int _catid;

		public int CategoryID
		{
			get { return _catid; }
			set { _catid = value; }
		}
		private string _catname;

		public string CategoryName
		{
			get { return _catname; }
			set { _catname = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public static int Count;
       
		private List<Product> _productlist;

		public List<Product> Products
		{
			get { return _productlist; }
			set { _productlist = value; }
		}
		
		public void AddCategory( Category category, int catid, string catname, string description)
		{

			
			category.CategoryID = catid;
			category.CategoryName = catname;
			category.Description = description;
			int n=2;
			Product[] product = new Product[n];
			category.Products = new List<Product>();
			for (int i = 0; i < n; i++)
			{
				product[i] = new Product();
				product[i].AddProduct(product[i],category);
				category.Products.Add(product[i]);
				Count++;
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("{0} category is updated with Products",catname);
			Console.WriteLine("Products in this category is {0}",Count);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("===============================================");
			Console.WriteLine();

		}
		public static void DisplayDetails(Category category) 
		{

			Console.WriteLine("Category Details:");
			Console.WriteLine("CategoryId : " + category.CategoryID);
			Console.WriteLine("CategoryName : " + category.CategoryName);
			Console.WriteLine("Description : " + category.Description);
			Console.WriteLine();
			Console.WriteLine("ProductList");
			Console.WriteLine();

			foreach (var p in category.Products)
			{
				Console.WriteLine("ProdctID : " + p.ProductID);
				Console.WriteLine("ProductName : " + p.ProductName);
				Console.WriteLine("QtySOld : " + p.QtySold);
				Console.WriteLine("UnitPrice : " + p.UnitPrice);
				Console.WriteLine("UnitOFMeasurement : " + p.UnitOFMeasurement);
				Console.WriteLine("QtyInHand : " + p.QtyInHand);
				Console.WriteLine("Reoderlevel : " + p.ReorderLevel);
				Console.WriteLine("--------------------------");
			}
		}
	}
}
