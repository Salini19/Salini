using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
       
		private List<Product> _productlist;

		public List<Product> Products
		{
			get { return _productlist; }
			set { _productlist = value; }
		}

	}
}
