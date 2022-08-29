using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ////Queue

            Queue q = new Queue(4);

            q.DisplayData();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enqueue:");
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);


            q.DisplayData();
            Console.WriteLine("----------------------------");
            q.Enqueue(60);

            q.DisplayData();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dequeue:");
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("after two node deletion");

            q.DisplayData();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Peek");
            q.Peek();

            //Mystack

            MyStack<int> s1 = new MyStack<int>(100);
            Console.WriteLine("IsEmpty= " + s1.isStackEmpty());
            Console.WriteLine("------------------------");
            Console.WriteLine("Push");
            s1.Push(100);
            s1.Push(90);
            s1.Push(80);
            s1.Push(70);
            s1.PrintStackElements();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pop ");
            s1.Pop();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Peek");
            s1.Peek();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Elements are:");
            s1.PrintStackElements();
            Console.WriteLine("--------------------------");
            Console.WriteLine("IsEmpty= " + s1.isStackEmpty());
           
           

            Console.ReadLine();
        }
    }
}
