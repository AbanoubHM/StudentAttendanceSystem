using StudentAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentAttendanceSystem
{
    public class DailyAttend
    {
        public int DailyAttendID { get; set; }
        [Column(TypeName = "date")]
        public DateTime ADate { get; set; }
        public ICollection<Attend> Attends { get; set; }
    }
}
