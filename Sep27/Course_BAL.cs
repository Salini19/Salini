using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL_Library
{
    public class Course_BAL
    {
        
        private int _crid;

        public int CourseID
        {
            get { return _crid; }
            set { _crid = value; }
        }
        private string _cname;

        public string CourseName
        {
            get { return _cname; }
            set { _cname = value; }
        }
        private int _detid;

        public int DeptID
        {
            get { return _detid; }
            set { _detid = value; }
        }
        public int Duration { get; set; }
    }
    public class Student_BAL
    {
        //        stuid int primary key,
        //name varchar(40),
        //crsid
        private int _sid;

        public int StudentID
        {
            get { return _sid; }
            set { _sid = value; }
        }
        private string _sname;

        public string StudentName
        {
            get { return _sname; }
            set { _sname = value; }
        }
        public int CourseId { get; set; }

    }
    public class Exam_BAL
    {
        private int _eid;

        public int ExamID
        {
            get { return _eid; }
            set { _eid = value; }
        }

        private int _sid;

        public int StudentID
        {
            get { return _sid; }
            set { _sid = value; }
        }
        private int _crid;

        public int CourseID
        {
            get { return _crid; }
            set { _crid = value; }
        }
        public int Marks { get; set; }
    }
}
