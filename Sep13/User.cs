using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminModule;

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
        List<Movie> Borrowedmovies = new List<Movie>();
        public static event Func<string, bool> Request;


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

       
        public void ShowMyList()
        {
            foreach (var item in this.Borrowedmovies)
            {
                Console.WriteLine($"Movie Name : {item.MovieName}");
                Console.WriteLine($"Language   : {item.Language}"); 
                Console.WriteLine($"Genere     : {item.Genre}");
                Console.WriteLine();
            }
        }
        public void BorrowMovie(List<Movie> list)
        {
           
            Console.WriteLine("Enter the movie name you want to borrow");
            string brw = Console.ReadLine();
            Console.WriteLine("Enter how many days do you want for the Rent");
            int days = int.Parse(Console.ReadLine());
            Movie search = list.Find(x => x.MovieName == brw);

            bool ans = Request(search.MovieName);
            if (ans)
            {

                if (search.Stock > 0)
                {
                    if (this.moviesBorrowed <= this.UserLevel)
                    {
                        search.Stock--;
                        this.moviesBorrowed++;
                        Borrowedmovies.Add(search);
                    }
                    else
                    {
                        Console.WriteLine("User Can't Borrow Anymore Movies upgrade your level");
                    }
                }
                else
                {
                    Console.WriteLine($"{search.MovieName} Movie isn't Availabale");
                }
            }
            else
            {
                Console.WriteLine("Admin Rejected....");
            }

        }
        public void ReturnMovie(List<Movie> list)

        {
            Console.WriteLine("Movies in your list");
            foreach (var item in Borrowedmovies)
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

            if (this.Borrowedmovies.Contains(returnmov))
            {

                returnmov.Stock++;
                this.moviesBorrowed--;
                Borrowedmovies.Remove(returnmov);
                double totalCost = days * (0.10 * returnmov.Price) * (0.18 * returnmov.Price);
                Console.WriteLine($"You Need to Pay {totalCost}");
                Console.WriteLine("Movie Returned Successfully");

            }
            else
            {
                Console.WriteLine("You didn't Borrow this movie..");
            }

           
        }
    }
}