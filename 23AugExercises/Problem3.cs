using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            Employee emp;
            

            Console.WriteLine("Enter the Employee number");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            emp.EmpName = (Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            emp.Sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Department number");
            emp.DeptNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************");
            Console.WriteLine("The Entered details are");
            Console.WriteLine("Employe name : " + emp.EmpNo);
            Console.WriteLine("Employe number : " + emp.EmpName);
            Console.WriteLine("Employe salary : " + emp.Sal);
            Console.WriteLine("Employe deptno : " + emp.DeptNo);

            Console.ReadLine();
        }
    }

    struct Employee
    {
        public int EmpNo;
        public string EmpName;
        public int Sal;
        public int DeptNo;
    }
}
    

