using BLL_Library;
using Helper_Library;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Institue Management System");
            Console.WriteLine("-------------------------------");
            course_helper helper = new course_helper();
            string c = null;
            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1 Course Table 2 Student Table 3 Exam table 4 Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Menu");
                        Console.WriteLine();

                        Console.WriteLine("1 AddCourse 2 UpdateCourse 3 Find Course 4 Showall 5 Delete 6 Course count 7 exit");
                        int userchoice = Convert.ToInt32(Console.ReadLine());
                        Course_BAL course = new Course_BAL();

                        switch (userchoice)
                        {
                            case 1:
                                bool queryStatus;
                                Addcourse(helper, course);

                                break;
                            case 2:
                                queryStatus = Updatecourse(helper, course);
                                break;
                            case 3:
                                FindCourse(helper, course);

                                break;
                            case 4:
                                Showallcourse(helper);
                                break;
                            case 5:
                                queryStatus = Deletecourse(helper, course);
                                break;
                            case 6:
                                int empcnt = helper.RowCountCourse();
                                Console.WriteLine(empcnt);
                                break;
                            case 7:
                                Environment.Exit(1);
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }

                        break;
                    case 2:

                        Console.WriteLine("Menu");
                        Console.WriteLine();

                        Console.WriteLine("1 AddStudent 2 UpdateStudent 3 Find Student 4 ShowallStudents 5 Delete student 6 student count 7 exit");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        Student_BAL student = new Student_BAL();
                        Student_helper helper1 = new Student_helper();

                        switch (ch1)
                        {
                            case 1:
                                bool queryStatus;
                                AddStudent(student, helper1);

                                break;
                            case 2:
                                queryStatus = Updatestudent(student, helper1);
                                break;
                            case 3:
                                FindStudent(student, helper1);

                                break;
                            case 4:
                                showstudentlist(helper1);
                                break;
                            case 5:

                                queryStatus = DeleteStudent(student, helper1);
                                break;
                            case 6:
                                int studentcnt = helper1.RowCountStudent();
                                Console.WriteLine(studentcnt);
                                break;
                            case 7:
                                Environment.Exit(1);
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }


                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Do you want to perform other options (Yes/No) ?");
                string ch = Console.ReadLine();
                if (ch == "Yes" || ch == "yes")
                {
                    c = "yes";
                }
                else
                {
                    Console.WriteLine("Thank You");

                }
            } while (c == "yes");




            Console.ReadLine();
        }

        private static bool DeleteStudent(Student_BAL student, Student_helper helper1)
        {
            bool queryStatus;
            Console.WriteLine("Enter  StudentID");
            student.StudentID = int.Parse(Console.ReadLine());
            queryStatus = helper1.RemoveStudentData(student.StudentID);
            if (queryStatus)
            {
                Console.WriteLine("Student details Deleted successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }

            return queryStatus;
        }

        private static void showstudentlist(Student_helper helper1)
        {
            List<Student_BAL> studentlist = new List<Student_BAL>();
            studentlist = helper1.StudentList();
            foreach (var item in studentlist)
            {
                Console.WriteLine(item.StudentID);
                Console.WriteLine(item.StudentName);
                Console.WriteLine(item.CourseId);

                Console.WriteLine();

            }
        }

        private static void FindStudent(Student_BAL student, Student_helper helper1)
        {
            Console.WriteLine("Enter new StudentID");
            student.StudentID = int.Parse(Console.ReadLine());
            Student_BAL data = helper1.LocateStudent(student.StudentID);

            if (data != null)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(data.StudentID);
                Console.WriteLine(data.StudentName);
                Console.WriteLine(data.CourseId);

            }
            else
            {
                Console.WriteLine("Invalid Studentid");
            }
        }

        private static bool Updatestudent(Student_BAL student, Student_helper helper1)
        {
            bool queryStatus;
            Console.WriteLine("Enter Studenid");
            int studid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter new studentid");
            student.StudentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter studentName");
            student.StudentName = Console.ReadLine().Trim();
            Console.WriteLine("enter Courseid");
            student.CourseId = int.Parse(Console.ReadLine());
            queryStatus = helper1.EditStudentData(studid, student);
            if (queryStatus)
            {
                Console.WriteLine("Student details updated successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }

            return queryStatus;
        }

        private static void AddStudent(Student_BAL student, Student_helper helper1)
        {
            Console.WriteLine("Enter studentid");
            student.StudentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter studentName");
            student.StudentName = Console.ReadLine();
            Console.WriteLine("enter Courseid");
            student.CourseId = int.Parse(Console.ReadLine());
            bool queryStatus = helper1.AddNewStudent(student);
            if (queryStatus)
            {
                Console.WriteLine("Student added successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }
        }

        private static bool Deletecourse(course_helper helper, Course_BAL course)
        {
            bool queryStatus;
            Console.WriteLine("Enter new CourseID");
            course.CourseID = int.Parse(Console.ReadLine());
            queryStatus = helper.RemoveCourseData(course.CourseID);
            if (queryStatus)
            {
                Console.WriteLine("Course Deleted successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }

            return queryStatus;
        }

        private static void Showallcourse(course_helper helper)
        {
            List<Course_BAL> courselist = new List<Course_BAL>();
            courselist = helper.CourseList();
            foreach (var item in courselist)
            {
                Console.WriteLine(item.CourseID);
                Console.WriteLine(item.CourseName);
                Console.WriteLine(item.DeptID);
                Console.WriteLine(item.Duration);
                Console.WriteLine();

            }
        }

        private static void FindCourse(course_helper helper, Course_BAL course)
        {
            Console.WriteLine("Enter new CourseID");
            course.CourseID = int.Parse(Console.ReadLine());
            Course_BAL data = helper.LocateCourse(course.CourseID);

            if (data != null)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(data.CourseID);
                Console.WriteLine(data.CourseName);
                Console.WriteLine(data.DeptID);
                Console.WriteLine(data.Duration);
            }
            else
            {
                Console.WriteLine("Invalid COurseid");
            }
        }

        private static bool Updatecourse(course_helper helper, Course_BAL course)
        {
            bool queryStatus;
            Console.WriteLine("Enter CourseID");
            int CourseID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new CourseID");
            course.CourseID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coursename");
            course.CourseName = Console.ReadLine().Trim();
            Console.WriteLine("Enter deptId");
            course.DeptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DUration");
            course.Duration = int.Parse(Console.ReadLine());

            queryStatus = helper.EditCourseData(CourseID,course);
            if (queryStatus)
            {
                Console.WriteLine("Course updates successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }

            return queryStatus;
        }

        private static void Addcourse(course_helper helper, Course_BAL course)
        {
            Console.WriteLine("Enter CourseID");
            course.CourseID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coursename");
            course.CourseName = Console.ReadLine().Trim();
            Console.WriteLine("Enter deptId");
            course.DeptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DUration");
            course.Duration = int.Parse(Console.ReadLine());

            bool queryStatus = helper.AddNewCourse(course);
            if (queryStatus)
            {
                Console.WriteLine("Course added successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }
        }
    }
}
