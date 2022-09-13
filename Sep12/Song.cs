using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep12
{
    public class Song
    {
        [StereoDisc("name", SongName = "ThenMozhi", Language = "Tamil", Lyrics = "Dhanush")]
        public static void ThenMozhi()
        {
            Console.WriteLine("ThenMozhi Kanimozhi Maripochae en Mozhi");
        }
        [StereoDisc("name", SongName = "Megham Karukada", Language = "Tamil", Lyrics = "Dhanush")]
        public static void MeghamKarukada()
        {
            Console.WriteLine("Meham karukada pennae pennnae \n    saral adikada pennae pennae..");
        }
        [StereoDisc("name", SongName = "MeriJaan", Language = "Hindi", Lyrics = "Kumar")]
        public static void MeriJaan()
        {
            Console.WriteLine("Meri Jaan Meri Jaan Meri Jaan \n    Meri Jaan Meri Jaan Meri Jaan");
        }
        [StereoDisc("name", SongName = "PonniNadi", Language = "Tamil", Lyrics = "Ilango Krishanan")]
        public static void PonniNadhi()
        {
            Console.WriteLine("kanni Pengal Kannanumey Theeyari Esamaari \n   Kaatraipola Theeyari Esamaari \n      Pottal kadanthu Theeyari Esamaari ");
        }

        static void Main(string[] args)
        {
            ThenMozhi();
            MeghamKarukada();
            MeriJaan();
            PonniNadhi();


            Console.ReadLine();

        }
    }
}
