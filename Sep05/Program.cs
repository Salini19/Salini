using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InheritanceandPolymorphism;

namespace Sep5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Cart cart = new Cart();
            cart.AddToCart(1, 1920, 250);
            Cart cart2 = new Cart();
            cart2.AddToCart(2, 2019, 300);
            Cart cart3 = new Cart();
            cart3.AddToCart(3, 37, 450);
            Cart cart4=new Cart();
            cart4.AddToCart(4, 162, 500);

            List<Cart> list = new List<Cart>();
            list.Add(cart);
            list.Add(cart2);
            list.Add(cart3);
            list.Add(cart4);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("list of books in Cart:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine("CustomerID : "+item.CustomerID);
                Console.WriteLine("BookID     : " + item.BookID);
                Console.WriteLine("Price      : " + item.Price);
                Console.WriteLine("-----------------------------");
                Cart.count++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Number of books added to cart : " + Cart.count);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
        }
    }
}
