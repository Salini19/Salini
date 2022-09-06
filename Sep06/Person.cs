using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep6
{
    
    public abstract class Person
    {
        public abstract void Work();
        

    }
    public class Manager : Person
    {
        public override void Work()
        {
            Console.WriteLine("The person is manager");
            //throw new NotImplementedException();
        }
    }
    public class Employee : Person
    {
        public override void Work()
        {
            Console.WriteLine("The person is Employee");
            //throw new NotImplementedException();
        }
    }

    public class Clerk : Person
    {
        public override void Work()
        {
            Console.WriteLine("The person is Clerk");
            //throw new NotImplementedException();
        }
    }

    
}
