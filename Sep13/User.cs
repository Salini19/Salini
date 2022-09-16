using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class User
    {
        private string _uname;

        public string UserName
        {
            get { return _uname; }
            set { _uname = value; }
        }
        private string _pwd;

        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        private int _phno;

        public int PhoneNumber
        {
            get { return _phno; }
            set { _phno = value; }
        }
        public DateTime Date { get; set; }
        public int moviesBorrowed = 0;
        List<Movie> borrowedmovies = new List<Movie>();
        public enum Userlvl
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5

        }
        private int _userlvl;

        public int UserLevel
        {
            get { return _userlvl; }
            set { _userlvl = value; }
        }
        public User()
        {

        }
        public User(string UserName, string Password, DateTime d, string UserLevel1)
        {
            if (UserLevel1 == "Silver")
            {
                this.UserLevel = (int)Userlvl.Silver;
            }
            if (UserLevel1 == "Gold")
            {
                this.UserLevel = (int)Userlvl.Gold;
            }
            if (UserLevel1 == "Platinum")
            {
                this.UserLevel = (int)Userlvl.Platinum;
            }
            this.UserName = UserName;
            this.Password = Password;
            this.Date = d;
        }

        public void BorrowMovie(List<Movie> list)
        {
            Console.WriteLine("The movies available for you are");
            foreach (Movie items in list)
            {
                Console.Write(items.MovieName + " ");
                Console.Write(items.Language + " ");
                Console.Write(items.Genre + " ");
                Console.WriteLine(items.Price + " ");

                Console.WriteLine();
            }
            for (int i = 0; i < this.UserLevel; i++)
            {
                Console.WriteLine("Enter the movie name you want to borrow");
                string brw = Console.ReadLine();
                Console.WriteLine("Enter how many days do you want for the Rent");
                int days = int.Parse(Console.ReadLine());
                Movie search = list.Find(x => x.MovieName == brw);

                if (search != null)
                {

                    this.moviesBorrowed++;
                    borrowedmovies.Add(search);
                    list.Remove(search);
                    search.Stock--;
                    double totalCost = days * (0.10 * search.Price) * (0.18 * search.Price);
                    Console.WriteLine($"You Need to Pay {totalCost}");
                    Console.WriteLine("This movie is added to your list");

                }
                else
                {
                    Console.WriteLine("This Movie isn't Availabale");
                }
            }
            Console.WriteLine("Movies in your list");
            foreach (var item in borrowedmovies)
            {
                Console.WriteLine(item.MovieName);
                Console.WriteLine(item.Language);
                Console.WriteLine(item.Genre);
            }

        }
        public void ReturnMovie(List<Movie> list)
        {
            Console.WriteLine("Movies in your list");
            foreach (var item in borrowedmovies)
            {
                Console.WriteLine(item.MovieName);
                Console.WriteLine(item.Language);
                Console.WriteLine(item.Genre);
                Console.WriteLine();
            }
            Console.WriteLine("Enter Movie Name you want to return");
            string ret = Console.ReadLine();
            Console.WriteLine("Enter how many days you rented the movie");
            int days = int.Parse(Console.ReadLine());
            Movie returnmov = list.Find(x => x.MovieName == ret);

            if (this.borrowedmovies.Contains(returnmov))
            {

                returnmov.Stock++;
                this.moviesBorrowed--;
                borrowedmovies.Remove(returnmov);
                Console.WriteLine("Movie Returned Successfully");
                
            }
            else
            {
                Console.WriteLine("You didn't Borrow this movie..");
            }

        }
        public void ShowMyList()
        {
            foreach (var item in this.borrowedmovies)
            {
                Console.WriteLine($"Movie Name : {item.MovieName}");
                Console.WriteLine($"Language   : {item.Language}"); 
                Console.WriteLine($"Genere     : {item.Genre}");
                Console.WriteLine();
            }
        }
    }
}