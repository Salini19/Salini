using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        private string _uname;

        public string UserName
        {
            get { return _uname; }
            set { _uname = value; }
        }
        private string _pass;

        public string Password
        {
            get { return _pass; }
            set { _pass = value; }
        }
        public DateTime Date { get; set; }
       


        private string _phno;

        public string PhoneNumber
        {
            get { return _phno; }
            set { _phno = value; }
        }
        public User()
        {

        }

        public User(string UserName, string Password,string PhNo, DateTime d)
        {
            
            this.UserName = UserName;
            this.Password = Password;
            this.PhoneNumber = PhNo;
            this.Date = d;
        }

        public void RegisterUser(User user, List<User> useslist)
        {
            Console.WriteLine("Enter Username");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            user.Password = Console.ReadLine();
            user.Date = DateTime.Now;
            Console.WriteLine("Enter Phone Number");
            user.PhoneNumber = Console.ReadLine();
            User check = useslist.Find(X => X.PhoneNumber == user.PhoneNumber);
            if (check == null)
            {
                useslist.Add(user);

            }
            else
            {
                Console.WriteLine("User already Registered");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have sucessfully Registered at the time " + user.Date);
            Console.WriteLine("Username : " + user.UserName);
            Console.WriteLine("Password : " + user.Password);
            Console.WriteLine("Phone : " + user.PhoneNumber);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (User u in useslist)
            {
                Console.WriteLine("Username : " + u.UserName);
                Console.WriteLine("Password : " + u.Password);
                Console.WriteLine("Phone : " + u.PhoneNumber);
                Console.WriteLine("Registered Time : " + u.Date);

            }


        }

        public void EditUserData(User user, List<User> useslist)
        {
            Console.WriteLine("Enter Phone Number");
            user.PhoneNumber = Console.ReadLine();
            User check = useslist.Find(X => X.PhoneNumber == user.PhoneNumber);
            if (check != null)
            {
                Console.WriteLine("Enter Username");
                check.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                check.Password = Console.ReadLine();
                check.Date = DateTime.Now;
                Console.WriteLine("Enter Phone Number");
                check.PhoneNumber = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User details edited sucessfully at " + check.Date);
                Console.WriteLine("Username : " + check.UserName);
                Console.WriteLine("Password : " + check.Password);
                Console.WriteLine("Phone : " + check.PhoneNumber);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (User u in useslist)
                {
                    Console.WriteLine("Username : " + u.UserName);
                    Console.WriteLine("Password : " + u.Password);
                    Console.WriteLine("Phone : " + u.PhoneNumber);
                    Console.WriteLine("Registered Time : " + u.Date);

                }

            }
            else
            {
                Console.WriteLine("User not Found");
            }

        }
    }
}
