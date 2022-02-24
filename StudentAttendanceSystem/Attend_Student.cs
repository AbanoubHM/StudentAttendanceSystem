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
        //BindingList<Models.Attend> displayList = new BindingList<Models.Attend>();
        int dailyAttendId;

        public Attend_Student(DateTime date, Enrollment e1)
        {
            InitializeComponent();
            AttendDate = date;
            enrollment = e1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
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

            var l1 = db.DailyAttends.Where(x => x.ADate == AttendDate).ToList();

            if (l1.Count > 0)
            {
                dailyAttendId = l1[0].DailyAttendID;
                var l2 = db.Attends.Where(x => x.DailyAttendID == dailyAttendId).ToList();


                //foreach (var item in l2)
                for (int i = 0; i < l2.Count; i++)
                {
                    Student s1 = db.Students.ToList().Where(w => w.StudentID == (l2[i].StudentID)).FirstOrDefault();
                    if (s1.EnrollmentID != enrollment.EnrollmentID)
                    {
                        l2.Remove(l2[i--]);
                    }
                }

                BindingList<Models.Attend> l3 = new BindingList<Models.Attend>(l2);
                dataGridView1.DataSource = l3;

            }
            else
            {

            }




            //dataGridView1.DataSource = db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList();
        }
    }
}
