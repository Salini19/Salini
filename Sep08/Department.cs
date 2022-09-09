using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public delegate void Operations(List<Employee> emplist);
    
    public class Department
    {
		private int _deptno;

		public int DeptNo
		{ 
			get { return _deptno; }
			set { _deptno = value; }
		}

		private string _dname;

		public string DeptName
		{
			get { return _dname; }
			set { _dname = value; }
		}

		private string _location;

		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}
        private List<Employee> _employees;

        public List<Employee> Emplist
        {
            get { return _employees; }
            set
            {
                if (_employees.Capacity <= 10)
                {
                    _employees = value;
                }
                else
                {
                    Console.WriteLine("List is full");
                }
            }
        }
        public void DisplayDetails(List<Employee> emplist)
        {

            foreach (var item in emplist)
            {
                if (string.IsNullOrEmpty(item.Manager))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("This Employee don't have a Reporting Manager");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Employee ID                : " + item.EmpID);
                    Console.WriteLine("Employee Name              : " + item.EmpName);
                    Console.WriteLine("Employee Dept No           : " + item.DeptNo);
                    Console.WriteLine("Employee Salary            : " + item.Salary);
                    Console.WriteLine("Employee Reporting Manager : " + item.Manager);
                    Console.WriteLine("********************************************");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("This Employee has a Reporting Manager");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Employee ID                : " + item.EmpID);
                    Console.WriteLine("Employee Name              : " + item.EmpName);
                    Console.WriteLine("Employee Dept No           : " + item.DeptNo);
                    Console.WriteLine("Employee Salary            : " + item.Salary);
                    Console.WriteLine("Employee Reporting Manager : " + item.Manager);
                    Console.WriteLine("********************************************");
                }

            }

        }
    }
}
