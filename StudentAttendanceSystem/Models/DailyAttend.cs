using StudentAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentAttendanceSystem
{
    public class DailyAttend
    {
        public int ID { get; set; }
        public DateTime ADate { get; set; }
        public bool Presence { get; set; }
        public string Excuse { get; set; }

        public ICollection<Attend> Attends { get; set; }
    }
}
