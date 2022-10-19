using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderService;
using NUnit.Framework;

namespace CustomerOrderService.Test
{
    [TestFixture]
    public class StudEnrollTest
    {
        [TestCase(1000,ExpectedResult =true)]
        [TestCase(0,ExpectedResult =false)]
        public bool Enroll(int fees)
        {
            Student s = new Student();
            Enrollment e = new Enrollment();
            s.RollNo = 1;
            s.StudName = "Abc";
            s.course = CourseName.DotNet;
            e.EnrollNo = 2;
            e.Fees = fees;
            StudEnrollment en = new StudEnrollment();
            bool ans= en.EnrollStudent(s, e);
            return ans;
        }
    }
}
