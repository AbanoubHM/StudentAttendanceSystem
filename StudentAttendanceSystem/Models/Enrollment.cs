using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem
{
    public class Enrollment
    {
        public int ID { get; set; }
        public string Track { get; set; }
        public string Quarter { get; set; }
        public string Branch { get; set; }



        public List<Student> Students { get; set; }
    }
}
