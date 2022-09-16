using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable()]
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
        public void Searchbylanguage(List<Movie> list)
        {
            Console.WriteLine("These language movies are available Hindi,English,Tamil,Telugu,Kanada");
            Console.WriteLine("Enter languae to search Movie");
            string lang = Console.ReadLine();
            List<Movie> search = list.FindAll(x => x.Language == lang);
            if (search != null)
            {
                for (int i = 0; i < search.Count; i++)
                {
                    Console.WriteLine("Movie    : " + search[i].MovieName);
                    Console.WriteLine("Genre    : " + search[i].Genre);
                    Console.WriteLine("Language : " + search[i].Language);
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("This language is not available");
            }
        }
        public void SearchByGenre(List<Movie> list)
        {
            Console.WriteLine("These Genres are available..Action.Comedy,Drama,Romance,Thriller,Adventure");
            Console.WriteLine("Enter Genre to search Movie");
            string genre = Console.ReadLine();
            List<Movie> search1 = list.FindAll(x => x.Genre == genre);
            if (search1 != null)
            {
                foreach (Movie item in search1)
                {
                    Console.WriteLine("Movie    : " + item.MovieName);
                    Console.WriteLine("Genre    : " + item.Genre);
                    Console.WriteLine("Language : " + item.Language);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("This genre is not available");
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
