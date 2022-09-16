using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ClassLibrary1;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sep14
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user1 = new User("Salini", "Abcde","637998383",new DateTime(2022, 02, 2));
            User user2 = new User("Sameer", "123456", "1234567890",new DateTime(2022, 03, 12));
            User user3 = new User("Thashwanth", "23345", "7357998947",new DateTime(2022, 01, 23));
            User user4 = new User("Rubini", "34568","9876543210", new DateTime(2022, 02, 14));
            User user5 = new User("Eswari", "12344","8765432190", new DateTime(2022, 1, 2));
            User user6 = new User("Moorthy", "R1233","7654321098", new DateTime(2022, 2, 2));
            User user7 = new User("Lavanya", "QWERTY","9765432810", new DateTime(2022, 02, 2));
            users.Add(user1); users.Add(user2); users.Add(user3); users.Add(user4); users.Add(user5); users.Add(user6); users.Add(user7);

            char ch = 'Y';
            while (ch == 'Y')
            {
                Console.WriteLine("1 for Register\n 2 for Edit Details");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {

                            User newuser = new User();
                            newuser.RegisterUser(newuser, users);
                            FileStream fs = new FileStream(@"user details.xml", FileMode.Create, FileAccess.Write);
                            XmlSerializer serial = new XmlSerializer(typeof(List<User>));
                            serial.Serialize(fs, users);
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("file added");

                            break;
                        }
                    case 2:
                        {
                            User newuser = new User();
                            newuser.EditUserData(newuser, users);
                            FileStream fs = new FileStream(@"user details.xml", FileMode.Create, FileAccess.Write);
                            XmlSerializer serial = new XmlSerializer(typeof(List<User>));
                            serial.Serialize(fs, users);
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("file added");

                            break;
                        }
                }
                Console.WriteLine("Do you want to continue ? (yes/n)");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    ch = 'Y';
                }
                else
                {
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
