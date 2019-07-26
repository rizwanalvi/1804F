using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webmvc01.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public String Semester { get; set; }


        private List<Student> _lst = null;

        public List<Student> GetAllStudent() {
            _lst = new List<Student>();
            _lst.Add(new Student {StudentID =1000,StudentName="Ahmed Khan",Semester="HDSEI" });
            _lst.Add(new Student { StudentID = 1001, StudentName = "Salman Khan", Semester = "HDSEI" });
            _lst.Add(new Student { StudentID = 1002, StudentName = "Imran Khan", Semester = "HDSEI" });
            _lst.Add(new Student { StudentID = 1003, StudentName = "Zohaib Khan", Semester = "HDSEI" });
            _lst.Add(new Student { StudentID = 1004, StudentName = "Sara Khan", Semester = "HDSEI" });
            return _lst;
        }

    }
}