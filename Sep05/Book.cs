using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    public class Book
    {
		private int _bid;

		public int BookID
		{
			get { return _bid; }
			set { _bid = value; }
		}
		private string _bname;

		public string BookName
		{
			get { return _bname; }
			set { _bname = value; }
		}
		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public Book()
		{
			
		}
		public Book(int bid, string bname,  int price,  string author)
		{
			_bid = bid;			
			_bname = bname;			
			_price = price;
			_author = author;			
		}

		public void InsertBook(int bookid,string bookname,int price)
		{
			this.BookID=bookid;
			this.BookName=bookname;
			this.Price = price;
		}
		public void InsertBook(int bookid,string bookname,int price,string author)
		{
			this.BookID= bookid;
			this.BookName= bookname;
			this.Price= price;
			this.Author = author;
		}
		public void InsertBook(int bookid,string bookname)
		{
			this.BookID= bookid;
			this.BookName = bookname;
		}
	}
}
