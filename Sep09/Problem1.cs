using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sep9
{
    internal class Problem1
    {
        //Create a thread class and call a method  using and without ParameterizedthreadStart Delegate.
          //Print numbers.

        static void Mythread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadName : "+Thread.CurrentThread.Name);
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Mythread ends");
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(Mythread);
            t1.Name = "numbers";
            t1.Start();
            
            Console.ReadLine();
        }
    }
}
