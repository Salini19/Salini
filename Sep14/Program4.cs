using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Sep14
{
    internal class Program4
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

            list.Add(m1); list.Add(m2); list.Add(m3); list.Add(m4); list.Add(m5); list.Add(m6); list.Add(m7); list.Add(m8); list.Add(m9); list.Add(m10);

            List<Movie> Moviestock = new List<Movie>();
            Movie sam = new Movie(); char op = 'y';
            while (op == 'y')
            {

                Console.WriteLine("Enter  1 to rent Movie CDs  2 to Return Movie CD");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {

                    case 1:
                        {
                            sam.RentCD(list, Moviestock);
                            FileStream fs = new FileStream("RentedMovies.soap", FileMode.Create, FileAccess.Write);
                            SoapFormatter form = new SoapFormatter();
                            Movie[] rent = Moviestock.ToArray();
                            form.Serialize(fs, rent);
                            Console.WriteLine("File created Sucessfully");
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            break;
                        }
                    case 2:
                        {
                            sam.ReturnCD(list, Moviestock);
                            FileStream fs = new FileStream("ReturnedMovies.soap", FileMode.Create, FileAccess.Write);
                            SoapFormatter form = new SoapFormatter();
                            Movie[] rent = Moviestock.ToArray();
                            form.Serialize(fs, rent);
                            Console.WriteLine("File created Sucessfully");
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            break;
                        }
                }
                Console.Write("Do you want to continue (Y/N) ? ");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    op = 'y';
                }
                else
                {
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
