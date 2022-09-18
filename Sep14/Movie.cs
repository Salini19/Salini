using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable()]
    public class Movie
    {
        public static int Stock;
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

        private string _mname;

        public string MovieName
        {
            get { return _mname; }
            set { _mname = value; }
        }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public DateTime exetime { get; set; }

        public DateTime Rented_time { get; set; }

        public double addtotal { get; set; }
          
        

        public void RentCD(List<Movie> movielist, List<Movie> Moviestock)
        {
            double addtotal = 0;
            Console.WriteLine("Accept the Deal\n 1.yes 2.No");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("The movies available for you are");
            foreach (Movie items in movielist)
            {

                Console.Write(items.MovieName + " ");
                Console.Write(items.Language + " ");
                Console.Write(items.Genre + " ");
                Console.WriteLine(items.Price + " ");
                Console.Write(items.exetime + " ");
                Console.WriteLine();
            }
            if (no == 1)
            {

                Console.WriteLine("Enter the number of movies to Rent");
                int n = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the {0} movie you want to add", i);
                    string search1 = Console.ReadLine();
                    Movie Searchedmovies1 = movielist.Find(x => x.Genre == search1 || x.Language == search1 || x.MovieName
                == search1);
                    Moviestock.Add(Searchedmovies1);
                    movielist.Remove(Searchedmovies1);
                    Stock--;
                    Console.WriteLine("Enter how many days do you want for the Rent");
                    int days = int.Parse(Console.ReadLine());
                    double price = (days * (0.10 * Searchedmovies1.Price) * (0.18 * Searchedmovies1.Price));
                    addtotal += price;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The total price of the CDs : Rs." + addtotal);
                foreach (var items in Moviestock)
                {
                    Console.WriteLine("The movies you rented are");
                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movielist)
                {

                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You cannot add these Movies");
            }

        }

        public void ReturnCD(List<Movie> movielist, List<Movie> Moviestock)
        {
            foreach (Movie items in Moviestock)
            {
                Console.WriteLine("The movies you Rented are");
                Console.Write(items.MovieName + " ");
                Console.Write(items.Language + " ");
                Console.Write(items.Genre + " ");
                Console.Write(items.exetime + " ");
                Console.WriteLine();
            }
            char op = 'Y';
            while (op == 'Y')
            {
                Console.WriteLine("Enter the movie name you want to return");
                string mov = Console.ReadLine();
                Movie rem = Moviestock.Find(x => x.MovieName == mov);
                Moviestock.Remove(rem);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movie returned sucessfully");
                foreach (Movie items in Moviestock)
                {
                    Console.WriteLine("The movies you Rented are");
                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();

                }
                movielist.Add(rem);
                Stock++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
                Console.WriteLine();
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movielist)
                {

                    Console.Write(items.MovieName + " ");
                    Console.Write(items.Language + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.exetime + " ");
                    Console.WriteLine();
                }
                Console.Write("Do you want to return another movie (Y/N) ? ");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    op = 'Y';
                }
                else
                {
                    break;
                }

            }
        }
        public double Amount(Movie movie)
        {

            Console.WriteLine("Enter the Number of the days to rent the film");
            int day = int.Parse(Console.ReadLine());
            movie.addtotal = (day * (0.10 * movie.Price) * (0.18 * movie.Price));
            movie.Rented_time = DateTime.Now;
            Console.WriteLine("rented amount :" + movie.addtotal + " at " + movie.Rented_time);
            return movie.addtotal;
        }
    }
}
