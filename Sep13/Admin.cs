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

        public List<User> Users
        {
            get { return _userslist; }
            set { _userslist = value; }
        }

        public void AddUsers(List<User> users)
        {

            Console.WriteLine("Enter the number of Users to add");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                User user = new User();
                Console.WriteLine("Enter Username");
                user.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                user.Password = Console.ReadLine();
                Console.WriteLine("Enter Phone Number");
                user.PhoneNumber = int.Parse(Console.ReadLine());
                users.Add(user);

            }
            foreach (User user in users)
            {
                Console.WriteLine("USerName : "+user.UserName);
                Console.WriteLine("Password : "+user.Password);
                Console.WriteLine("Phone Number : "+user.PhoneNumber);
                Console.WriteLine("Added Date : "+user.Date);
                Console.WriteLine();
            }

            
        }
        public void AddMovies(List<Movie> list)
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
                list.Add(movie);
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Movie movies in list)
                {
                    Console.WriteLine(movies.MovieName);
                    Console.WriteLine(movies.Language);
                    Console.WriteLine(movies.Genre);
                    Console.WriteLine(movies.Price);
                }
            }
            
            
        }
        public void UpdateMovies(List<Movie> list)
        {

            Console.WriteLine("Enter the Movie Name or Language or genre to update");
            string search = Console.ReadLine();
            Movie Name = list.Find(x => x.MovieName == search || x.Language == search || x.Genre == search);
            Console.WriteLine("Enter the Updated Movie Name");
            Name.MovieName = Console.ReadLine();
            Console.WriteLine("Enter the Updated Movie Language");
            Name.Language = Console.ReadLine();
            Console.WriteLine("Enter the Updated Movie Genre");
            Name.Genre = Console.ReadLine();
            Console.WriteLine("Enter the Updated Movie Price");
            Name.Price = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Movie movie in list)
            {
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Language);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Price);
            }


        }
        public void DeleteMovies(List<Movie> list)
        {

            Console.WriteLine("Enter the Movie Name or Language or genre to Delete");
            string search = Console.ReadLine();
            Movie Name = list.Find(x => x.MovieName == search || x.Language == search || x.Genre == search);
            list.Remove(Name);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Movie movie in list)
            {
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Language);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Price);
            }
            

        }
        public Admin()
        {
            User.Request += UserRequest;
        }
        public static bool UserRequest(string s)
        {
            Console.WriteLine($"Admin : Enter yes or no to approve {s}");
            string ans = Console.ReadLine();
            if (ans == "yes" || ans == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
