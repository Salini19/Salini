using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Employee
    {
		private int _empid;

		public int EmpID
		{
			get { return _empid; }
			set { _empid = value; }
		}
		private string _empname;

		public string EmpName
		{
			get { return _empname; }
			set { _empname = value; }
		}

		private float _sal;

		public float Salary
		{
			get { return _sal; }
			set { _sal = value; }
		}

		private int _deptno;

		public int DeptNo
		{
			get { return _deptno; }
			set { _deptno = value; }
		}


		private string _mgr;

		public string Manager
		{
			get { return _mgr; }
			set { _mgr = value; }
		}
		

	}
}
