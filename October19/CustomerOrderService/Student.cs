using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public enum CourseName
    {
        AIML,
        DotNet,
        Java
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string StudName { get; set; }
        public CourseName course { get; set; }
    }

    public class Enrollment
    {
        public int EnrollNo { get; set; }
        public int Fees { get; set; }
    }
}
