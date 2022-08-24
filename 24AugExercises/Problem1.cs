using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class CompareStr
    {
        public static void CompareString(string a,string b)
        {
            
            int len1=a.Length;
            int len2=b.Length;
            if (len1 != len2)
            {
                Console.WriteLine("{0} and {1} are Different",a,b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are Equal",a,b);
            }

        }
    }
}
