using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL_LIB;
using DAL_Lib;

namespace Helper_Lib
{
    public class EmployeeHelper
    {
        EmployeeDAL dal = null;
        public EmployeeHelper()
        {
            dal = new EmployeeDAL();
        }


        public int RowCountEmployees()
        {
            return dal.RowCountEmployees();

        }
        public bool AddNewEmployee(Employee_BAL employee)
        {
            return dal.InsertEmployee(employee);
        }
        public Employee_BAL LocateEmployee(int empid)
        {
            return dal.FindEmployee(empid);
        }

        public List<Employee_BAL> EmployeeList()
        {
            return dal.ShowAllEmps();
        }

        public bool RemoveEmployeeData(int empid)
        {
            return dal.DeleteEmployee(empid);
        }



        public bool EditEmployeeData(int empid, Employee_BAL employee)
        {
            return dal.UpdateEmployee(empid, employee);
        }



    }
}
