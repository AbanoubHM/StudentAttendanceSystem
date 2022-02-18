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
        public DbSet<TrackInfo> TrackInfos { get; set; }
        public DbSet<Attendance> attendances { get; set; }
    }
}
