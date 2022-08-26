using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayObjLibrary;

namespace Aug26
{
    public class Problem2
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
}
