using StudentAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem
{
    internal class DataContext :DbContext
    {
        public DataContext() : base("name=AttendanceDb")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<DailyAttend> DailyAttends { get; set; }
        public DbSet<Attend> Attends { get; set; }
    }
}
