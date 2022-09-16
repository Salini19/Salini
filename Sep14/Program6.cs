using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sep14
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            List<Movie> list = new List<Movie>();
            Movie m1 = new Movie() { MovieName = "SitaRaman", Language = "Tamil", Genre = "Love", Price = 120,exetime=DateTime.Now };

            Movie m2 = new Movie() { Genre = "Action", Language = "Kanada", MovieName = "KGF2", Price = 140, exetime = DateTime.Now };
            Movie m3 = new Movie() { MovieName = "777 Charlie", Language = "Kannada", Genre = "Adventure", Price = 120, exetime = DateTime.Now };
            Movie m4 = new Movie() { MovieName = "Viruman", Language = "Tamil", Genre = "family", Price = 120, exetime = DateTime.Now };
            Movie m5 = new Movie() { MovieName = "Vikram", Language = "Tamil", Genre = "Action", Price = 100 , exetime = DateTime.Now};
            Movie m6 = new Movie() { MovieName = "Not Reachable", Language = "English", Genre = "Thriller", Price = 150, exetime = DateTime.Now };
            Movie m7 = new Movie() { MovieName = "Mahan", Language = "Tamil", Genre = "Action", Price = 120, exetime = DateTime.Now };
            Movie m8 = new Movie() { MovieName = "Sillunu Oru kadhal", Language = "Tamil", Genre = "Love", Price = 120, exetime = DateTime.Now };
            Movie m9 = new Movie() { MovieName = "Circus", Language = "Hindi", Genre = "Comedy", Price = 130 , exetime = DateTime.Now };
            Movie m10 = new Movie() { MovieName = "Gully Boy", Language = "Hindi", Genre = "Drama", Price = 180, exetime = DateTime.Now };

            list.Add(m1); list.Add(m2); list.Add(m3); list.Add(m4); list.Add(m5); list.Add(m6); list.Add(m7); list.Add(m8);
            list.Add(m9);
            list.Add(m10);


            FileStream fs = new FileStream(@"Rent amount details.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            m2.Amount(m2);
            formatter.Serialize(fs, m2);
            FileStream fs1 = new FileStream(@"Rent amount details1.xml", FileMode.Create, FileAccess.Write);
            m1.Amount(m10);
            XmlSerializer serial = new XmlSerializer(typeof(Movie));
            serial.Serialize(fs1, m10);
            Console.WriteLine("File Added");
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();


        }
    }
}
