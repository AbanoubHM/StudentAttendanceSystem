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
    public partial class Report_Details : Form
    {
        public Report_Details()
        {
            InitializeComponent();
        }

        private void Attendance_Btn_Click(object sender, EventArgs e)
        {
            Report_Attendance_save s6 = new Report_Attendance_save();
            s6.ShowDialog();
        }

        private void Student_Data_Btn_Click(object sender, EventArgs e)
        {
            Report_Attendance_save s6 = new Report_Attendance_save();
            s6.ShowDialog();
        }
    }
}
