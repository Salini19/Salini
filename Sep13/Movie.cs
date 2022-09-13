using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Movie
    {
		private string _lang;

		public string Language
		{
			get { return _lang; }
			set { _lang = value; }
		}
		private string _genre;

		public string Genre
		{
			get { return _genre; }
			set { _genre = value; }
		}
		private string _name;

		public string MovieName
		{
			get { return _name; }
			set { _name = value; }
		}
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public static void Rent(List<Movie> movielist, int Stock, double addtotal, int n)
        {
            Console.WriteLine("Accept the Deal\n 1.yes 2.No");
            int no = int.Parse(Console.ReadLine());
            if (no == 1)
            {
                List<Movie> Moviestock = new List<Movie>();
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the {0} movie you want to add", i);
                    string search1 = Console.ReadLine();
                    Movie Searchedmovies1 = movielist.Find(x => x.Genre == search1 || x.Language == search1 || x.MovieName == search1);
                    Moviestock.Add(Searchedmovies1);
                    movielist.Remove(Searchedmovies1);
                    Stock--;
                    Console.WriteLine("Enter how many days do you want for the Rent");
                    int days = int.Parse(Console.ReadLine());
                    double price = (days * (0.10 * Searchedmovies1.Price) * (0.18 * Searchedmovies1.Price));
                    addtotal += price;
                }
                Console.WriteLine("The total price of the CDs : Rs." + addtotal);
                foreach (var items in Moviestock)
                {
                    Console.WriteLine("The movies you selected are");
                    Console.WriteLine(items.MovieName);
                    Console.WriteLine(items.Language);
                    Console.WriteLine(items.Genre);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("You cannot add these Movies");
            }

        }
    }
}
