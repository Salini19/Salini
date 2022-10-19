using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class StudEnrollment
    {
        public bool EnrollStudent(Student s,Enrollment e)
        {
            bool status;
            if (e.Fees >0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
