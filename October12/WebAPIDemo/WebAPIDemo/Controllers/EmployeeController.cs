using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;
using BAL_LIB;
using Helper_Lib;

namespace WebAPIDemo.Controllers
{
    [RoutePrefix("EMP")]
    public class EmployeeController : ApiController
    {
        EmployeeHelper obj = null;
        public EmployeeController()
        {
            obj = new EmployeeHelper();
        }
        [Route("GetEmployees")]
        public List<Employee> GetEmpList()
        {
            //return new string[] { "value1", "value2" };

            List<Employee_BAL> empbal = new List<Employee_BAL>(); empbal = obj.EmployeeList();
            List<Employee> emps = new List<Employee>();
            foreach (var item in empbal)
            {
                //Employees emp = new Employees();
                emps.Add(new Employee { EmployeeID = item.EmployeeID, FirstName = item.FirstName, LastName = item.LastName, BirthDate = item.BirthDate, Title = item.Title });
            }
            return emps;

        }
        [Route("FindEmpByID/{id}")]
        // GET api/<controller>/5
        public Employee GetEmpByID(int id)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal = obj.LocateEmployee(id);
            Employee emp = new Employee();
            emp.EmployeeID = empbal.EmployeeID;
            emp.FirstName = empbal.FirstName;
            emp.LastName = empbal.LastName;
            emp.Title = empbal.Title;
            emp.BirthDate = empbal.BirthDate;
            return emp;
            //return "value";
        }

  
        // POST api/<controller>
        public HttpResponseMessage PostProduct([FromBody] Employee empdata)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal.EmployeeID = empdata.EmployeeID;
            empbal.FirstName = empdata.FirstName;
            empbal.LastName = empdata.LastName;
            empbal.Title = empdata.Title;
            empbal.BirthDate = empdata.BirthDate;


            bool ans = obj.AddNewEmployee(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // PUT api/<controller>/5
        public HttpResponseMessage PutProduct(int id, [FromBody] Employee empdata)
        {

            Employee_BAL empbal = new Employee_BAL();
            empbal.EmployeeID = empdata.EmployeeID;
            empbal.FirstName = empdata.FirstName;
            empbal.LastName = empdata.LastName;
            empbal.Title = empdata.Title;
            empbal.BirthDate = empdata.BirthDate;

            bool ans = obj.EditEmployeeData(id, empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage DeleteProduct(int id)
        {
            bool ans = obj.RemoveEmployeeData(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }
    }
}