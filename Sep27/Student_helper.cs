using BLL_Library;
using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Library
{
    public class Student_helper
    {
        Student_DAL dal = null;
        public Student_helper()
        {
            dal = new Student_DAL();
        }
        public int RowCountStudent()
        {
            return dal.RowCountstudent();

        }
        public bool AddNewStudent(Student_BAL student)
        {
            return dal.InsertStudent(student);
        }
        public Student_BAL LocateStudent(int studentid)
        {
            return dal.FindStudent(studentid);
        }

        public List<Student_BAL> StudentList()
        {
            return dal.ShowAllStudent();
        }

        public bool RemoveStudentData(int studentid)
        {
            return dal.DeleteStudent(studentid);
        }

        public bool EditStudentData(int studentid, Student_BAL student)
        {
            return dal.UpdateStudent(studentid, student);
        }
    }
}
