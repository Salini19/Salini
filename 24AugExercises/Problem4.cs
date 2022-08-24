using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Splitstr
    {
        public static void Spilt()
        {
            string newStr = "Welcome, to the world, of C# ,Programming";
            string[] sep = { "C#" };
            //char[] sep = { ' ' };
            int cnt = 2;
            string[] result = newStr.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
