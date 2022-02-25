using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class Report_Attendance_save : Form
    {
        Enrollment enrollment;
        public Report_Attendance_save(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
