using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace StudentAttendanceSystem.Models
{
    public class Attend
    {
        public int AttendID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        [ForeignKey("DailyAttend")]
        public int DailyAttendID { get; set; }

        public bool Presence { get; set; }
        public string Excuse { get; set; }
        public virtual Student Student { get; set; }
        public virtual DailyAttend DailyAttend { get; set; }


    }
}
