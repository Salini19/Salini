using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UserModule;

namespace Sep13
{
    internal class ProblemA
    {
        static int Stock;
        static void Main(string[] args)
        {

            List<Movie> list = new List<Movie>();
            Movie m1 = new Movie() { MovieName = "SitaRaman", Language = "Tamil", Genre = "Love" ,Price=120};

            Movie m2 = new Movie() { Genre = "Action", Language = "Kanada", MovieName = "KGF2" ,Price=140};
            Movie m3 = new Movie() { MovieName = "777 Charlie", Language = "Kannada", Genre = "Adventure",Price=120 };
            Movie m4 = new Movie() { MovieName = "Viruman", Language = "Tamil", Genre = "family" , Price = 120 };
            Movie m5 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action" , Price = 100 };
            Movie m6 = new Movie() { MovieName = "Not Reachable", Language = "Tamil", Genre = "Thriller" , Price = 150 };
            Movie m7 = new Movie() { MovieName = "Mahan", Language = "Tamil", Genre = "Action" , Price = 120 };
            Movie m8 = new Movie() { MovieName = "Sillunu Oru kadhal", Language = "Tamil", Genre = "Love" , Price = 120 };
            Movie m9 = new Movie() { MovieName = "Circus", Language = "Hindi", Genre = "Comedy" , Price = 130 };
            Movie m10 = new Movie() { MovieName = "Gully Boy", Language = "Hindi", Genre = "Drama" , Price = 180 };

            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);
            list.Add(m6);
            list.Add(m7);
            list.Add(m8);
            list.Add(m9);
            list.Add(m10);
            Stock = list.Count;

            List<User> users = new List<User>();
            User user1 = new User() { Username = "Salini", Password = "Abcde", AddedDate = new DateTime(2022, 02, 2) };
            User user2 = new User() { Username = "Sameer", Password = "123456", AddedDate = new DateTime(2022, 03, 12) };
            User user3 = new User() { Username = "Thashwanth", Password = "23345", AddedDate = new DateTime(2022, 01, 23) };
            User user4 = new User() { Username = "Rubini", Password = "34568", AddedDate = new DateTime(2022, 02, 14) };
            User user5 = new User() { Username = "Eswari", Password = "12344", AddedDate = new DateTime(2022, 1, 2) };
            User user6 = new User() { Username = "Moorthy", Password = "R1233", AddedDate = new DateTime(2022, 2, 2) };
            User user7 = new User() { Username = "Lavanya", Password = "QWERTY", AddedDate = new DateTime(2022, 02, 2) };
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
            users.Add(user7);




            Console.WriteLine("Genre :- \n 1. Family \n 2.Action \n 3.Children \n 4.Social awareness \n 5.Horror \n 6.Thriller \n 7.History");
            Console.WriteLine("Languages :- \n 1.Tamil \n 2.Hindi \n 3.kanada");
            Console.WriteLine("Enter the language or genre to search the movies");
            string search = Console.ReadLine();
            List<Movie> Searchedmovies = list.FindAll(x => x.Genre == search || x.Language == search);
            foreach (Movie movie in Searchedmovies)
            {
                Console.WriteLine(movie.MovieName);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Language);
                Console.WriteLine();
                
            }
            Console.WriteLine("Enter Username and Password");
            Action<string, string> Login = (string username, string password) =>
            {
                User Name = users.Find(x => x.Username == username);
                User Pass = users.Find(x => Name.Password == password);
                if (Name != null)
                {
                    if (Pass != null)
                    {
                        Console.WriteLine("Logged In " + Name.Username + "!!");
                        Console.WriteLine("The Top Rated Movies Rented By others are :");
                        foreach (Movie Movies in list)
                        {
                            Console.WriteLine(Movies.MovieName);
                            Console.WriteLine(Movies.Language);
                            Console.WriteLine(Movies.Genre);
                            Console.WriteLine("______________________");
                        }
                        Console.WriteLine("Choose the Badge ypu need \n Options:-\n 1.Silver - 2 Movies can be" +
                            "Rented \n 2.Gold - 3 Movies can be Rented \n 3.Platinum - 5 Movies can be Rented \n "
                            );
                        int Userchoice = int.Parse(Console.ReadLine());
                        double addtotal = 0;
                        switch (Userchoice)
                        {
                            case 1:
                                {
                                    SilverUser silverBadge = new SilverUser();
                                    silverBadge.Username = Name.Username;
                                    silverBadge.Password = Name.Password;
                                    Movie.Rent(list, Stock, addtotal, 2);
                                    break;
                                }
                            case 2:
                                {
                                    GoldUser goldBadge = new GoldUser();
                                    goldBadge.Username = Name.Username;
                                    goldBadge.Password = Name.Password;
                                    Movie.Rent(list, Stock, addtotal, 3);
                                    break;
                                }
                            case 3:
                                {
                                    PlatinumUser platinumbadge = new PlatinumUser();
                                    platinumbadge.Username = Name.Username;
                                    platinumbadge.Password = Name.Password;
                                    Movie.Rent(list, Stock, addtotal, 5);
                                    break;
                                }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Password is incorrect");
                    }
                }
                else
                {
                    Console.WriteLine("No user found");
                }

            };
            Login(Console.ReadLine(), Console.ReadLine()); 
           

            Console.ReadLine();


        }
    }
    
}
