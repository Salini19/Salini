using ArrayObjLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Archery");
            mylist.AddLast("Soccer");
            mylist.AddAfter(mylist.First, "Boxing");
            mylist.AddBefore(mylist.Last, "Table Tennis");
            mylist.AddBefore(mylist.Last.Previous, "Throw Ball");
            mylist.AddBefore(mylist.Last.Previous.Previous, "Volleyball");
            mylist.AddAfter(mylist.First.Next, "Cricket");
            mylist.AddAfter(mylist.First.Next.Next, "Golf");
            mylist.AddAfter(mylist.First.Next.Next.Next, "Fencing");

            LinkedListNode<string> foundnode = mylist.Find("Boxing");
            foundnode.Value = "Badminton";

            string empF=mylist.ElementAt(3);
            mylist.Remove(empF);

            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
