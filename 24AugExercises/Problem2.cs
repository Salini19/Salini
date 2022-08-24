using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class StrCopy
    {
        public static void StringCopy(string a)
        {
            
            string b=String.Copy(a);
            Console.WriteLine("Enterd string1 : "+a);
            Console.WriteLine("Copied String : " + b);
        }

    }
}
