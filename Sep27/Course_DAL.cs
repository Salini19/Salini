using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Library;

namespace DAL_library
{
    public class Course_DAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public Course_DAL()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Imscnstring"].ConnectionString);
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Course", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "course");//disconnect from our database server
                                     //Single dataset object can hold multiple tables inside it
                                     //To identify each table uniquely we can use a index or name.
                                     //index starts with 0, but better to work with name.
            DataTable dt_coursedata = ds.Tables["course"];
            return dt_coursedata;
        }
        public bool UpdateCourse(int courseid, Course_BAL course)
        {
            DataTable dt_coursedata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);

            drow["CourseID"] = course.CourseID;
            drow["CourseName"]=course.CourseName;
            drow["DeptId"] = course.DeptID;
            drow["Duration"] = course.Duration;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bool InsertCourse(Course_BAL course)
        {
            DataTable dt_coursedata = Connect();

            DataRow drow = ds.Tables["course"].NewRow();//creates new row in the datatable

            drow["CourseID"] = course.CourseID;
            drow["CourseName"] = course.CourseName;
            drow["DeptId"] = course.DeptID;
            drow["Duration"] = course.Duration;

            ds.Tables["course"].Rows.Add(drow);// disconnected mode- inthe dataset

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bool DeleteCourse(int courseid)
        {

            DataTable dt_coursedata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public List<Course_BAL> ShowAllCourse()
        {
            DataTable dt_coursedata = Connect();
            List<Course_BAL> courselist = new List<Course_BAL>();
            for (int i = 0; i < dt_coursedata.Rows.Count; i++)
            {
                DataRow drow = dt_coursedata.Rows[i];
                Course_BAL course = new Course_BAL();
                course.CourseID = Convert.ToInt32(drow["CourseID"]);
                course.CourseName = drow["CourseName"].ToString();
                course.DeptID = Convert.ToInt32(drow["DeptID"]);
                course.Duration = Convert.ToInt32(drow["Duration"]);

                courselist.Add(course);
                

            }
            return courselist;


        }

        public Course_BAL FindCourse(int courseid)
        {
            DataTable dt_coursedata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            Course_BAL course = new Course_BAL();

            course.CourseID = Convert.ToInt32(drow["CourseID"]);
            course.CourseName = drow["CourseName"].ToString();
            course.DeptID = Convert.ToInt32(drow["DeptID"]);
            course.Duration = Convert.ToInt32(drow["Duration"]);


            return course;

        }
        public int RowCountCourse()
        {
            DataTable dt_coursedata = Connect();
            int coursecnt = dt_coursedata.Rows.Count;
            return coursecnt;
        }

    }
}
