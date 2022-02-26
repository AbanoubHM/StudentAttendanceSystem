using StudentAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem
{
    public class Student
    {
        public int StudentID { get; set; }
        //Main Student Data
        public string Name { get; set; }
        public string NameAR { get; set; }
        [ForeignKey("Enrollment")]
        public int EnrollmentID { get; set; }
        public string Gender { get; set; }
        public string NID { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Moblie { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //Education
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public int GradYear { get; set; }
        public string Grade { get; set; }
        //Status
        public string MilitaryState { get; set; }
        public string MaterialState { get; set; }
        //Overall Notes
        public string Notes { get; set; }

        public ICollection<Attend> Attends { get; set; }
        public Enrollment Enrollment { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
