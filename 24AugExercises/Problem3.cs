using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class IndexofStr
    {
        public static void IndexOF(string a,char b)
        {
            int index= a.IndexOf(b);
            Console.WriteLine("Indexof {0} is {1}", b, index);
        }
    }
}
