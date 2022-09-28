using BLL_Library;
using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Library
{
    public class course_helper
    {
        Course_DAL dal = null;
        public course_helper()
        {
            dal = new Course_DAL();
        }
        public int RowCountCourse()
        {
            return dal.RowCountCourse();

        }
        public bool AddNewCourse(Course_BAL course)
        {
            return dal.InsertCourse(course);
        }
        public Course_BAL LocateCourse(int courseid)
        {
            return dal.FindCourse(courseid);
        }

        public List<Course_BAL> CourseList()
        {
            return dal.ShowAllCourse();
        }

        public bool RemoveCourseData(int courseid)
        {
            return dal.DeleteCourse(courseid);
        }

        public bool EditCourseData(int courseid, Course_BAL course)
        {
            return dal.UpdateCourse(courseid, course);
        }

    }
}
