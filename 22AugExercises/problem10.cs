using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Dheeran");
            dic.Add(2, "Paiya");
            dic.Add(3, "viruman");
          
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadLine();
        }
    }
}
