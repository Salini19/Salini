using ArrayObjLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug26
{
    public class Problem1

    {
        static void Main(string[] args)
        {
            Students[] student = new Students[2];



            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Students();
                Console.WriteLine("Enter RollNo");
                student[i].RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student name");
                student[i].StudentName = Console.ReadLine();
                Console.WriteLine("Eneter Grade");
                student[i].Grade = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("Student Details:");
            student[0].DisplayStudent();
            student[1].DisplayStudent();

            Console.ReadLine();
        }
    }
    struct Students
    {
        
        public char Grade;

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


        int rollno;

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
        string sname;

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
    }

}
