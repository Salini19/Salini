using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObjLibrary
{
    public class Students
    {
        private int rollno;

        public int RollNo
        {
            get { return rollno; }
            set
            {
                if (value != 0)
                {
                    rollno = value;

                }
                else
                {

                    Console.WriteLine("RollNo couldnot be zero or null");
                }

            }
        }
        private string sname;

        public string StudentName
        {
            get { return sname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("StudentNAme couldnot be null");
                }
                else
                {
                    sname = value;
                }

            }
        }
        private char grade;

        public char Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public void AcceptDataStudent(int rollno, string sname, char grade)
        {
            RollNo = rollno;
            StudentName = sname;
            Grade = grade;
        }
        public void DisplayStudent()
        {

            Console.WriteLine("RollNo : " + RollNo);
            Console.WriteLine("StudentName : " + StudentName);
            Console.WriteLine("Grade : " + Grade);
            Console.WriteLine();

            Console.WriteLine("----------------------");
        }
    }
}
