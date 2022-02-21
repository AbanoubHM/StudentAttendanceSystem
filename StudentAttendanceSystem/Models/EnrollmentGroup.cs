using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem.Models
{
    public class EnrollmentGroup
    {
        public int EnrollmentGroupID { get; set; }
        public int GNumber { get; set; }
        public virtual Enrollment Enrollment { get; set; }
    }
}
