using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AugExercises
{
    internal class Exercise16
    {
        static void Main(string[] args)
        {
            string userid, password;
            Console.WriteLine("Enter the FirstName");
            userid = Console.ReadLine();
            Console.WriteLine("Enter the LastName");
            password = Console.ReadLine();

            if ((string.IsNullOrEmpty(userid)) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("you are not logged in");

            }
            else
            {
                Console.WriteLine("you are successfully logged in");
                Console.WriteLine("Your Deatis:");
                Console.WriteLine("userid(firstname) : {0}", userid);
                Console.WriteLine("password(lastname) : {0}", password);
                Console.WriteLine();
                Console.WriteLine("***Welcome to my app***");
            }
            Console.ReadLine();
        }
    }
}
