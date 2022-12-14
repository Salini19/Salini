using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


using ClassLibrary1;

namespace Sep14
{
    internal class Program2
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

            


            
            Console.WriteLine("Enter the language or genre to search the movies");
            
            string search = Console.ReadLine();
            List<Movie> Searchedmovies = list.FindAll(x => x.Genre == search || x.Language == search);



            FileStream fs = new FileStream(@"searchmovie.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml=new XmlSerializer(typeof(List<Movie>));
            xml.Serialize(fs, Searchedmovies);

            fs.Flush();
            fs.Close();
            fs.Dispose();

            Console.WriteLine("File Created");

            Console.ReadLine();

        }
       

        
    }
}
