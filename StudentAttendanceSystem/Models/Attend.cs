using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Models
{
    public class Attend
    {
        public int ID { get; set; }
        public virtual Student Student { get; set; }
        public virtual DailyAttend DailyAttend { get; set; }


    }
}
