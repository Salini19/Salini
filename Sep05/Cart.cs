using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
	public class Cart : Book
	{
		private int _custid;

		public int CustomerID
		{
			get { return _custid; }
			set { _custid = value; }
		}
		


		public static int count;

		//public void AddToCart(int cid,int bid,int price)
		//{
		//	this.CustomerID = cid;
		//	this.BookID = bid;
		//	this.Price = price;

		//}
	

		public void AddToCart(int cid,Book[] books)
		{
			this.CustomerID = cid;
			List<Book> BookList = new List<Book>();	
			
			for (int i = 0; i < books.Length; i++)
			{
				
				books[i]=new Book();

				Console.WriteLine("Enter the BookID");
				books[i].BookID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the BookName");
                books[i].BookName = Console.ReadLine();
                Console.WriteLine("Enter the Book Price ");
                books[i].Price = int.Parse(Console.ReadLine());
				Console.WriteLine("-----------------------");

				books[i].InsertBook(books[i].BookID, books[i].BookName, books[i].Price);
				BookList.Add(books[i]);

            }
			
		}
        private List<Book> _books;

        public List<Book> BookList
        {
            get { return _books; }
            set { _books = value; }
        }

        public void DisplayDetails(Cart cart, Book[] book)
		{
			//Console.WriteLine("CustomerID : " + cart.CustomerID);
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("list of books in Cart:");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine();

			foreach (var item in book)
			{
				
				Console.WriteLine("BookID     : " + item.BookID);
                Console.WriteLine("BookName   : " + item.BookName);
                Console.WriteLine("Price      : $ {0} " , item.Price);
				Console.WriteLine("-----------------------------");
				Cart.count++;
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Number of books added to cart : " + Cart.count);
			Console.ForegroundColor = ConsoleColor.White;
		}


    }
}
