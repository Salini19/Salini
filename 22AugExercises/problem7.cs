using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class problem7
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(45);
            q.Enqueue(4567.45f);
            q.Enqueue(33);
            object a2=q.Dequeue();
            Console.WriteLine("Dequeue:" +a2) ;
            Console.WriteLine("items in Queue:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
