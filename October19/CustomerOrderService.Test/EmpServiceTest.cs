using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderService;

namespace CustomerOrderService.Test
{
    [TestFixture]
    public class EmpServiceTest
    {
        [TestCase(16,ExpectedResult =false)]
        [TestCase(64,ExpectedResult =true)]
        [TestCase(39,ExpectedResult =false)]
        [TestCase(60,ExpectedResult =true)]
        public bool GetAge(int age)
        {
            Employee emp = new Employee();
            emp.EmployeeID = 1;
            emp.EmpName = "ABC";
            emp.Age = age;

            bool ans=emp.Issenior();
            return ans;
            //Assert.That(ans == true);
        }
    }
}
