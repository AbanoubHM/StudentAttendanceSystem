using StudentAttendanceSystem.Models;
using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;


namespace StudentAttendanceSystem
{
    public class DailyAttend
    {
        public int DailyAttendID { get; set; }
        [Column(TypeName = "date")]
        public DateTime ADate { get; set; }
        public ICollection<Attend> Attends { get; set; }

        public override string ToString()
        {
            return ADate.ToString("dd-MM-yyyy");
        }
    }
}
