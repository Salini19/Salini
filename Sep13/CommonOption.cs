using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModule;
using AdminModule;

namespace CommonOptions
{
    public class Coption
    {
        public void changePassword(List<User> userlist, User user1)
        {
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            User user = userlist.Find(x => user1.Password == pass);
            if (user != null)
            {
                DateTime Date = user1.Date;
                DateTime now = DateTime.Now;
                if ((now.Month - Date.Month) >= 1)
                {
                    Console.WriteLine("Enter New Password");
                    user1.Password = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("After changing Password");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(user1.UserName);
                    Console.WriteLine(user1.Password);
                    Console.WriteLine(user1.PhoneNumber);
                }
                else
                {
                    Console.WriteLine("Thank you!!");

                }

            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }
        }
        public void ViewProfile(List<User> users)
        {
            Console.WriteLine("Enter UserName");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            User sel1 = users.Find(x => x.UserName == name);

            if (sel1 != null)
            {
                User sel2 = users.Find(x => sel1.Password == pass);
                if (sel2 != null)
                {
                    Console.WriteLine("UserName : " + sel1.UserName);
                    Console.WriteLine("Password: " + sel1.Password);
                    Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                    Console.WriteLine("Added date : " + sel1.Date);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Invalid UserName");
            }
        }
        
        public void EditProfile(List<User> users)
        {
            Console.WriteLine("Enter UserName");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            User sel1 = users.Find(x => x.UserName == name);

            if (sel1 != null)
            {
                User sel2 = users.Find(x => sel1.Password == pass);
                if (sel2 != null)
                {
                    Console.WriteLine("Your Profile");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    
                    Console.WriteLine("UserName : " + sel1.UserName);
                    Console.WriteLine("Password: " + sel1.Password);
                    Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                    Console.WriteLine("Added date : " + sel1.Date);
                    Console.WriteLine();
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("Do you want to Update Details\n Yes or No");
                    string op = Console.ReadLine();
                    if (op == "Yes")
                    {
                        Console.WriteLine("Enter the Updated UserName");
                        sel1.UserName = Console.ReadLine();
                        Console.WriteLine("Enter the Updated Password");
                        sel1.Password = Console.ReadLine();
                        Console.WriteLine("Enter the Updated PhoneNumber");
                        sel1.PhoneNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Updated Details are as follows");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("UserName : " + sel1.UserName);
                        Console.WriteLine("Password: " + sel1.Password);
                        Console.WriteLine("Phone number: " + sel1.PhoneNumber);
                        Console.WriteLine("Added date : " + sel1.Date);
                        Console.WriteLine();

                    }
                    else if (op == "No")
                    {

                        
                        Console.WriteLine("ThankYou");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Invalid UserName");
            }
        }
    }
}
