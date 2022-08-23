using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem6
    {
        static void Main(string[] args)
        {
            Stack s= new Stack();
            s.Push(34);
            s.Push(33.45f);
            s.Push(78);
            s.Push(444);
            s.Push(3);
            var topmost = s.Peek();
            Console.WriteLine("topmost : " + topmost);

            Console.WriteLine("before pop:" + s.Count);
            s.Pop();
            s.Pop();
            Console.WriteLine("after pop:" + s.Count);
            

            Console.ReadLine();

        }
    }
}
