using DAL_BankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBank context = new MyBank();
            context.BorrowerTable.Add(new Borrower
            {
                Borrowerid = 1,
                BorrowerName = "Ranjith",
                CompanyName = "ABC",
                JobName = "Senior Executve",
                City = "Chennai",
                State = "Tamil Nadu",
                Country = "India",
                Street = "Padi"
            });
            context.SaveChanges();
            Console.WriteLine("Added");
            Console.ReadLine();
        }
    }
}
