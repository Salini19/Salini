using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModule; 

namespace AdminModule
{
    public class Admin
    {   
        private List<User> _userslist;

        public List<User> UsersList
        {
            get { return _userslist; }
            set { _userslist = value; }
        }

        public void AddUsers(List<User> userlist)
        {
           
                Console.WriteLine("Enter the number of Users to add");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    User user = new User();
                    Console.WriteLine("Enter Username");
                    user.Username = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    user.Password = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number");
                    user.PhoneNumber = int.Parse(Console.ReadLine());
                    userlist.Add(user);

                }
                foreach (User user in userlist)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(user.Username);
                    Console.WriteLine(user.Password);
                    Console.WriteLine(user.PhoneNumber);
                    Console.WriteLine(user.AddedDate);
                    Console.WriteLine();
                }

            
        }
        public void AddMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want add a Movie \n Yes or No");
            string ans = Console.ReadLine();
            if (ans == "Yes")
            {
                Console.WriteLine("Enter the number of movies to add");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Movie movie = new Movie();
                    Console.WriteLine("Enter MovieName");
                    movie.MovieName = Console.ReadLine();
                    Console.WriteLine("Enter Language");
                    movie.Language = Console.ReadLine();
                    Console.WriteLine("Enter Genre");
                    movie.Genre = Console.ReadLine();
                    Console.WriteLine("Enter Movie price");
                    movie.Price = int.Parse(Console.ReadLine());
                    movielist.Add(movie);
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (Movie movies in movielist)
                    {
                        Console.WriteLine(movies.MovieName);
                        Console.WriteLine(movies.Language);
                        Console.WriteLine(movies.Genre);
                        Console.WriteLine(movies.Price);
                    }
                }
            }
            
        }
        public void UpdateMovies(List<Movie> movielist)
        {

            Console.WriteLine("Enter the Movie Name or Language or genre to update");
            string search = Console.ReadLine();
            Movie Name = movielist.Find(x => x.MovieName == search || x.Language == search || x.Genre == search);
            Console.WriteLine("Enter the Updated Movie Name");
            Name.MovieName = Console.ReadLine();
            Console.WriteLine("Enter the Updated Movie Language");
            Name.Language = Console.ReadLine();
            Console.WriteLine("Enter the Updated Movie Genre");
            Name.Genre = Console.ReadLine();
            Console.WriteLine("Enter the Updated Movie Price");
            Name.Price = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Movie movie in movielist)
            {
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Language);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Price);
            }


        }
        public void DeleteMovies(List<Movie> movielist)
        {
            
                Console.WriteLine("Enter the Movie Name or Language or genre to Delete");
                string search = Console.ReadLine();
                Movie Name = movielist.Find(x => x.MovieName == search || x.Language == search || x.Genre == search);
                movielist.Remove(Name);
                Console.ForegroundColor = ConsoleColor.Red;
            foreach (Movie movie in movielist)
            {
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Language);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Price);
            }
            

        }
    }
}
