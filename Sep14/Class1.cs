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

		public void SearchMovie(string search)
		{
            List<Movie> list = new List<Movie>();

            Movie m1 = new Movie() { MovieName = "SitaRaman", Language = "Tamil", Genre = "Love" };
            Movie m2 = new Movie() { Genre = "Action", Language = "Kanada", MovieName = "KGF2" };
            Movie m3 = new Movie() { MovieName = "777 Charlie", Language = "Kannada", Genre = "Adventure" };
            Movie m4 = new Movie() { MovieName = "Viruman", Language = "Tamil", Genre = "family" };
            Movie m5 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action" };

            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);

            List<Movie> Searchedmovies = list.FindAll(x => x.Genre == search || x.Language == search);
            foreach (Movie movie in Searchedmovies)
            {
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Language);
                Console.WriteLine();

            }
        }
	}
}
