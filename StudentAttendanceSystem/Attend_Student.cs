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
            MessageBox.Show("SAVED!!!!");
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
            quarterLbl.Text = enrollment.Quarter;
            trackLbl.Text = enrollment.Track;
            List<Student> students = new List<Student>();
            var atends1 = db.Attends.Select(x => x.StudentID).Distinct().ToList();
            for (int i = 0; i < atends1.Count; i++)
            {
                Student s1 = db.Students.ToList().Where(w => w.StudentID == (atends1[i])).FirstOrDefault();
                if (s1.EnrollmentID != enrollment.EnrollmentID)
                {
                    atends1.Remove(atends1[i--]);
                }
                else { students.Add(s1); }
            }

            var l1 = db.DailyAttends.Where(x => x.ADate == AttendDate).ToList();

            if (l1.Count > 0)
            {   
                dailyAttendId = l1[0].DailyAttendID;

                if (db.Attends.ToList().Where(x => x.DailyAttendID == dailyAttendId && x.StudentID == students[0].StudentID).Count() > 0)
                {


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
                else {
                    foreach (var item in students)
                    {
                        db.Attends.Add(new Models.Attend() { StudentID = item.StudentID, DailyAttendID = dailyAttendId, Presence = false });
                    }
                    db.SaveChanges();
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
                    BindingList<Models.Attend> l4 = new BindingList<Models.Attend>(l2);
                    dataGridView1.DataSource = l4;

                }
            }
            else
            {
                DailyAttend newDate = new DailyAttend() { ADate = AttendDate};
                db.DailyAttends.Add(newDate);
                db.SaveChanges();
                l1 = db.DailyAttends.Where(x => x.ADate == AttendDate).ToList();

                dailyAttendId = l1[0].DailyAttendID;

                var l2 = db.Students.Where(x => x.EnrollmentID == enrollment.EnrollmentID);
                foreach (var item in l2)
                {
                    db.Attends.Add(new Models.Attend() { StudentID = item.StudentID, DailyAttendID = dailyAttendId, Presence = false });
                }
                //var l2 = db.Attends.Where(x => x.DailyAttendID == dailyAttendId).ToList();

                db.SaveChanges();

                var l3 = db.Attends.Where(x => x.DailyAttendID == dailyAttendId).ToList();


                //foreach (var item in l2)
                for (int i = 0; i < l3.Count; i++)
                {
                    Student s1 = db.Students.ToList().Where(w => w.StudentID == (l3[i].StudentID)).FirstOrDefault();
                    if (s1.EnrollmentID != enrollment.EnrollmentID)
                    {
                        l3.Remove(l3[i--]);
                    }
                }

                BindingList<Models.Attend> l4 = new BindingList<Models.Attend>(l3);
                dataGridView1.DataSource = l4;


            }
            dataGridView1.Columns[0].Visible= false;
            dataGridView1.Columns[1].Visible= false;
            dataGridView1.Columns[2].Visible= false;
            dataGridView1.Columns[3].HeaderText = "حضور";
            dataGridView1.Columns[4].HeaderText = "عذر";
            dataGridView1.Columns[5].HeaderText = "الاسم";
            dataGridView1.Columns[6].HeaderText = "التاريخ";
            dataGridView1.Columns[5].DisplayIndex = 0;






            //dataGridView1.DataSource = db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList();
        }
    }
}
