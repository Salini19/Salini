using AdminModule;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UserModule;
using CommonOptions;


namespace Handsonproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> list = new List<Movie>();
            Movie m1 = new Movie() { MovieName = "SitaRaman", Language = "Tamil", Genre = "Love", Price = 120 };

            Movie m2 = new Movie() { Genre = "Action", Language = "Kanada", MovieName = "KGF2", Price = 140 };
            Movie m3 = new Movie() { MovieName = "777 Charlie", Language = "Kannada", Genre = "Adventure", Price = 120 };
            Movie m4 = new Movie() { MovieName = "Viruman", Language = "Tamil", Genre = "family", Price = 120 };
            Movie m5 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action", Price = 100 };
            Movie m6 = new Movie() { MovieName = "Not Reachable", Language = "English", Genre = "Thriller", Price = 150 };
            Movie m7 = new Movie() { MovieName = "Mahan", Language = "Tamil", Genre = "Action", Price = 120 };
            Movie m8 = new Movie() { MovieName = "Sillunu Oru kadhal", Language = "Tamil", Genre = "Love", Price = 120 };
            Movie m9 = new Movie() { MovieName = "Circus", Language = "Hindi", Genre = "Comedy", Price = 130 };
            Movie m10 = new Movie() { MovieName = "Gully Boy", Language = "Hindi", Genre = "Drama", Price = 180 };

            list.Add(m1); list.Add(m2); list.Add(m3); list.Add(m4); list.Add(m5); list.Add(m6); list.Add(m7); list.Add(m8);
            list.Add(m9);
            list.Add(m10);


            List<User> users = new List<User>();
            User user1 = new User("Salini", "Abcde", new DateTime(2022, 02, 2), "Silver");
            User user2 = new User("Sameer", "123456", new DateTime(2022, 03, 12), "Gold");
            User user3 = new User("Thashwanth", "23345", new DateTime(2022, 01, 23), "Platinum");
            User user4 = new User("Rubini", "34568", new DateTime(2022, 02, 14), "Gold");
            User user5 = new User("Eswari", "12344", new DateTime(2022, 1, 2), "Silver");
            User user6 = new User("Moorthy", "R1233", new DateTime(2022, 2, 2), "Platinum");
            User user7 = new User("Lavanya", "QWERTY", new DateTime(2022, 02, 2), "Gold");
            users.Add(user1);  users.Add(user2); users.Add(user3); users.Add(user4); users.Add(user5); users.Add(user6);users.Add(user7);


            Console.WriteLine("Enter 1 for UserModule  2 for AdminModule  3 for Common Options");
            int ch=int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Username and Password");
                    Action<string, string> Login = (string username, string password) =>
                    {
                        User name = users.Find(x => x.UserName == username);
                        User Pass = users.Find(x => name.Password == password);
                        if (name != null)
                        {
                            if (Pass != null)
                            {
                                Console.WriteLine(" Successfully Logged In ");
                                Console.WriteLine($"Hello {name.UserName} ");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Top Rated Movies  :");
                                Console.ForegroundColor = ConsoleColor.White;
                                foreach (Movie Movies in list)
                                {
                                    Console.WriteLine(Movies.MovieName);                                  
                                }
                                Console.WriteLine();
                                string input;
                                do
                                {
                                    Console.WriteLine("Enter 1 for SearchList 2 for Borrow Movie 3 for Return Movie 4 for Show Your retnted List");
                                    int option = int.Parse(Console.ReadLine());
                                    switch (option)
                                    {
                                        case 1:
                                            Console.WriteLine("Enter 1 to SearchMovie ByLanguage 2 to SearchMovie by Genre");
                                            int choice = int.Parse(Console.ReadLine());

                                            switch (choice)
                                            {
                                                case 1:
                                                    Movie movie = new Movie();
                                                    movie.Searchbylanguage(list);
                                                    break;

                                                case 2:
                                                    Movie movie1 = new Movie();
                                                    movie1.SearchByGenre(list);
                                                    break;

                                                default:
                                                    Environment.Exit(1);
                                                    break;
                                            }
                                            break;
                                        case 2:

                                            User user = new User();
                                            user.BorrowMovie(list);
                                            break;
                                        case 3:

                                           
                                            User u1 = new User();
                                            u1.ReturnMovie(list);
                                            break;
                                        case 4:
                                            User u2 = new User();
                                            u2.ShowMyList();
                                            break;
                                        default:
                                            Environment.Exit(1);
                                            break;
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("If you want to continue Yes/No");
                                    input = Console.ReadLine();

                                }
                                while (input == "yes" || input == "yes");
                            }

                            else
                            {
                                Console.WriteLine("Password is incorrect");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Username doesnot exists");
                        }
                    };
                    Login(Console.ReadLine(), Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter Admin Operation to perform");
                    Console.WriteLine("1.Add User 2.Movie Modifications");
                    int Opt = int.Parse(Console.ReadLine());
                    Admin admin = new Admin();
                    switch (Opt)
                    {
                        case 1:
                            {
                                admin.AddUsers(users);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter 1 for Add Movie \n 2 for Update Movie \n 3 for delete Movie");
                                int ch2 = int.Parse(Console.ReadLine());
                                if (ch2 == 1)
                                {
                                    admin.AddMovies(list);
                                }
                                else if (ch2 == 2)
                                {
                                    admin.UpdateMovies(list);
                                }
                                else if (ch2 == 3)
                                {
                                    admin.DeleteMovies(list);
                                }
                                break;
                            }

                    }
                    break;
                case 3:
                    Console.WriteLine("Enter 1 to Change Password  2  to ViewProfile 3 to EditProfile");
                    Coption opt = new Coption();
                    
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        Console.WriteLine("Enter Username");
                        string name = Console.ReadLine();
                        User sel1 = users.Find(x => x.UserName == name);

                        if (sel1 != null)
                        {
                            opt.changePassword(users, sel1);

                        }

                    }
                    else if (n == 2)
                    {
                        opt.ViewProfile(users);

                    }
                    else if (n == 3)
                    {
                        opt.EditProfile(users);
                    }
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }


           

           
            Console.ReadLine();
        }
    }
}
