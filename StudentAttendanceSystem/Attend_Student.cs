using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StudentAttendanceSystem
{
    public partial class Attend_Student : Form
    {
        DateTime AttendDate;
        Enrollment enrollment;
        DataContext db = new DataContext();
        BindingList<Models.Attend> displayList = new BindingList<Models.Attend>();

        public Attend_Student(DateTime date,Enrollment e1)
        {
            InitializeComponent();
            AttendDate = date;
            enrollment = e1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void Attend_Student_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = AttendDate;
            
            
            
            //if (db.DailyAttends.Find(AttendDate) != null){
            //    MessageBox.Show("Founddddd");
            //}
            
            
            
            
            //dataGridView1.DataSource = db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList();
        }
    }
}
