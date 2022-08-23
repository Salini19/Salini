using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            
            emp.AcceptData(1920,"Sameer",56900,19);
            emp.Displaydata();
            Console.ReadLine();
        }
        struct Employee
        {
            public int EmpNo;
            public string EmpName;
            public int Sal;
            public int DeptNo;


            public void AcceptData(int empno, string empname, int sal, int deptno)
            {
                EmpNo = empno;
                EmpName = empname;
                Sal = sal;
                DeptNo = deptno;
            }

            public void Displaydata()
            {
                Console.WriteLine("The Entered details are");
                Console.WriteLine("Employe name : " + EmpNo);
                Console.WriteLine("Employe number : " + EmpName);
                Console.WriteLine("Employe salary : " + Sal);
                Console.WriteLine("Employe deptno : " + DeptNo);
            }
        }
    }
}
