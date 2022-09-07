using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Sep7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem 1 & 2

            //Problem1 firstex = new Problem1();
            //Console.WriteLine("Enter the string to find the length");
            //string str = Console.ReadLine();
            //findlength find = new findlength(firstex.LengthString);
            //find(str);
            //find = new findlength(firstex.Greetuser);
            //find(str);


            //Problem3

            //Problem3 problem3 = new Problem3();
            //Console.WriteLine("Enter first value to perform arithmetic operations");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second value to perform arithmetic operations");
            //int b = int.Parse(Console.ReadLine());
            //arithmeticdel[] del = new arithmeticdel[3] { problem3.Add, problem3.Sub, problem3.Mul };
            //arithmeticdel del1 = (arithmeticdel)MulticastDelegate.Combine(del);
            //del1(a, b);


            //Problem4

            //Products products = new Products();
            //products.ProductId = 101;
            //products.ProductName = "Laptop";
            //displaydel del = new displaydel(products.Displaydetails);
            //del(products);


            //Problem5

            //Employee employee = new Employee();
            //employee.EmpId = 2528704;
            //employee.EmpName ="Salini S";
            //employee.JoiningDate = new DateTime(2018, 06, 24);
            //yearsdel del = new yearsdel(employee.Calyrsofexp);
            //del(employee.JoiningDate);

            //Problem6

            //Problem6 problem6 = new Problem6();
            //Console.WriteLine("Enter first string");
            //string a = Console.ReadLine();
            //Console.WriteLine("Enter Second string");
            //string b = Console.ReadLine();
            //concatdel del = new concatdel(problem6.ConcatTwoStrings);
            //del(a, b);

            //Problem7

            Problem7 problem7 = new Problem7();
            Console.WriteLine("Write a string to convert first letter to upper case");
            string a = Console.ReadLine();
            strfirst del = new strfirst(problem7.StrCap);
            del(a);


            Console.ReadLine();



        }
    }
}
