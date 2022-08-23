using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

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


        struct Employee
        {
            public int Sal;

            int deptno;
            public int DeptNo
            {
                get
                {

                    return deptno;
                }
                set
                {
                    if (value == 0)
                    {
                        Console.WriteLine("deptno cannot be zero");

                    }
                    else
                    {
                        deptno = value;
                    }

                }
            }

            int empno;
            public int EmpNo
            {
                get
                {

                    return empno;
                }
                set
                {
                    if (value == 0)
                    {
                        Console.WriteLine("EmpNo cannot be zero");

                    }
                    else
                    {
                        empno = value;
                    }

                }
            }
            string empname;
            public string EmpName
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Name cannot be null or empty");

                    }
                    else
                    {
                        empname = value;
                    }
                }
                get
                {

                    return empname;

                }

            }
        }

    }
}

