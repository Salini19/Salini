using BLL_Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_library
{
    public class Student_DAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public Student_DAL()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Imscnstring"].ConnectionString);
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Student", cn);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Student");
            DataTable dt_studentdata = ds.Tables["Student"];
            return dt_studentdata;
        }
        public bool UpdateStudent(int studentid, Student_BAL student)
        {
            DataTable dt_studentdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studentid);

            drow["StudentID"] = student.StudentID;
            drow["Name"] = student.StudentName;
            drow["CourseID"] = student.CourseId;


            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bool InsertStudent(Student_BAL student)
        {
            DataTable dt_studentdata = Connect();

            DataRow drow = ds.Tables["student"].NewRow();

            drow["StudentID"] = student.StudentID;
            drow["Name"] = student.StudentName;
            drow["CourseID"] = student.CourseId;

            ds.Tables["student"].Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bool DeleteStudent(int studentid)
        {

            DataTable dt_studentdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studentid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public List<Student_BAL> ShowAllStudent()
        {
            DataTable dt_studentdata = Connect();
            List<Student_BAL> studentlist = new List<Student_BAL>();    
            for (int i = 0; i < dt_studentdata.Rows.Count; i++)
            {
                DataRow drow = dt_studentdata.Rows[i];
                Student_BAL student = new Student_BAL();
                student.StudentID= Convert.ToInt32(drow["StudentID"]);
                student.StudentName= drow["Name"].ToString();
                student.CourseId = Convert.ToInt32(drow["CourseID"]);
                

                studentlist.Add(student);


            }
            return studentlist;


        }

        public Student_BAL FindStudent(int studentid)
        {
            DataTable dt_studentdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studentid);
            Student_BAL student = new Student_BAL();

            student.StudentID = Convert.ToInt32(drow["StudentID"]);
            student.StudentName = drow["Name"].ToString();
            student.CourseId = Convert.ToInt32(drow["CourseID"]);

            return student;

        }
        public int RowCountstudent()
        {
            DataTable dt_studentdata = Connect();
            int studentcnt = dt_studentdata.Rows.Count;
            return studentcnt;
        }
    }
}
