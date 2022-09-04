using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Product
    {
		private int _pid;

		public int ProductID
		{
			get { return _pid; }
			set { _pid = value; }
		}

		private string _pname;

		public string ProductName
		{
			get { return _pname; }
			set { _pname = value; }
		}

		private int _qtysold;

		public int QtySold
		{
			get { return _qtysold; }
			set { _qtysold = value; }
		}

		private int _unitprice;

		public int UnitPrice
		{
			get { return _unitprice; }
			set { _unitprice = value; }
		}

		private string _unitofmeasurement;

		public string UnitOFMeasurement
		{
			get { return _unitofmeasurement; }
			set { _unitofmeasurement = value; }
		}

		private int _qtyinhand;

		public int QtyInHand
		{ 
			get { return _qtyinhand; }
			set { _qtyinhand = value; }
		}

		private int _reoder;

		public int ReorderLevel
		{
			get { return _reoder; }
			set { _reoder = value; }
		}
		public Product()
		{

		}

		public Product(int pid,string pname,int qtysold,int unitp,string meas,int qtyinhand,int reorder)
		{
			_pname = pname;
			_pid = pid;
			_qtysold = qtysold;
			_unitprice=unitp;
			_unitofmeasurement=meas;
			_qtyinhand = qtyinhand;
			_reoder=reorder;
		}
		

		public void AddProduct(Product product ,Category category1) //,int prodid,string prodname ,int qtsold ,int unitp,int unitmeasure,int qtinhand,int reorderlvl)
		{
			
			Console.WriteLine("Enter product ID");
			int prodid = int.Parse(Console.ReadLine());
			product.ProductID = prodid;
			Console.WriteLine("enter product name");
			string prodname = Console.ReadLine();
			product.ProductName = prodname;
            Console.WriteLine("Enter amount of QunatitySold");
            int qtsold = int.Parse(Console.ReadLine());
            product.QtySold = qtsold;
            Console.WriteLine("Enter the amount of unitprice");
            int unitp = int.Parse(Console.ReadLine());
            product.UnitPrice = unitp;
            Console.WriteLine("Enter the unit of measurement");
			string unitmeasure = Console.ReadLine();
            product.UnitOFMeasurement = unitmeasure;
            Console.WriteLine("Enter the amount of quantity in hand");
            int qtinhand = int.Parse(Console.ReadLine());
            product.QtyInHand = qtinhand;
            Console.WriteLine("Enter Reorderlevel");
            int reorderlvl = int.Parse(Console.ReadLine());
            product.ReorderLevel = reorderlvl;
			Console.WriteLine("-----------------------------------------");
			
			
		}

		

	}
}
