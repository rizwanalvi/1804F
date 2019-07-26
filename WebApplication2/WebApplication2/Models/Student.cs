using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        private List<Student> _lst = null;
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public String Semester { get; set; }
        
        public List<Student> GetAllStudent() {
            _lst = new List<Student> ();
            _lst.Add(new Student { StudentID= 1001,StudentName="Ahmed Khan",Semester="HDSE I"});
            _lst.Add(new Student { StudentID = 1002, StudentName = "Ahmed Khan", Semester = "HDSE I" });
            _lst.Add(new Student { StudentID = 1003, StudentName = "Ahmed Khan", Semester = "HDSE I" });
            _lst.Add(new Student { StudentID = 1004, StudentName = "Ahmed Khan", Semester = "HDSE I" });
            _lst.Add(new Student { StudentID = 1005, StudentName = "Ahmed Khan", Semester = "HDSE I" });


            return _lst;
        }
    }
}