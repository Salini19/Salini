using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		private int _unitofmeasurement;

		public int UnitOFMeasurement
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



	}
}
