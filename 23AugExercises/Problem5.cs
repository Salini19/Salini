using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            Employee[] employees = { new Employee(), new Employee(), new Employee(), new Employee() };
            employees[0].AcceptData(1920, "Sameer", 56900, 19);
            employees[1].AcceptData(1921, "Salini", 66900, 20);
            employees[2].AcceptData(1922, "Rubini", 76900, 21);
            employees[3].AcceptData(1923, "Thashwanth", 86900, 22);

            employees[0].Displaydata();
            employees[1].Displaydata();
            employees[2].Displaydata();
            employees[3].Displaydata();

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
                
                Console.WriteLine("Employe name : " + EmpNo);
                Console.WriteLine("Employe number : " + EmpName);
                Console.WriteLine("Employe salary : " + Sal);
                Console.WriteLine("Employe deptno : " + DeptNo);
                Console.WriteLine();
            }
        }
    }
}
