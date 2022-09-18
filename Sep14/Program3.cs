using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Sep14
{
    internal class Program3
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

            List<Movie> Seenmovies = new List<Movie>();
            foreach (Movie item in list)
            {

                Console.WriteLine(item.MovieName);
                Console.WriteLine();
                Console.WriteLine("Have you seen that Movie  Y or N");
                char opt = Convert.ToChar(Console.ReadLine());

                if (opt == 'Y' || opt=='y')
                {
                   Seenmovies.Add(item);

                }

            }
            Movie[] seen = Seenmovies.ToArray();
            FileStream fs = new FileStream(@"seenmovie.json", FileMode.Create, FileAccess.Write);
            JavaScriptSerializer serial = new JavaScriptSerializer();
            StringBuilder sb = new StringBuilder();
            StreamWriter sw = new StreamWriter(fs); 
            
            Console.WriteLine(sb);
            serial.Serialize(seen, sb);
            sw.WriteLine(sb);
            Console.WriteLine(sb);



            sw.Flush();
            fs.Flush();
            sw.Close();
            fs.Close();
            sw.Dispose();
            fs.Dispose();
            Console.WriteLine("file added");
            Console.ReadLine();



        }
    }
}
