using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    public class Cart:Book
    {
		private int _custid;

		public int CustomerID
		{
			get { return _custid; }
			set { _custid = value; }
		}
		
		public static int count;

		public void AddToCart(int cid,int bid,int price)
		{
			this.CustomerID = cid;
			this.BookID = bid;
			this.Price = price;
		}
		
	}
}
