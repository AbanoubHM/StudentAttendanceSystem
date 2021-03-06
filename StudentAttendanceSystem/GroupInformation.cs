using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class GroupInformation : Form
    {

        Enrollment enrollment;
        DataContext db = new DataContext();

        public GroupInformation(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;

        }


        private void GroupInformation_Load(object sender, EventArgs e)
        {
            position(Attended);
            p1.Height = Attended.Height;
            Active(Attended);

            label1.Text = $"{enrollment.Quarter} \n{enrollment.Track}";
             
            label1.Location = new System.Drawing.Point((this.Width/2)-100, this.Height-100);
            dataGridView.DataSource = new BindingList<Student>(db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList());
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[3].Visible = false;


        }

        private void position(Button b)
        {
            p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);
        }

        private void Attended_Click(object sender, EventArgs e)
        {
            position(Attended);
            Active(Attended);
            Attended a = new Attended(enrollment);
            a.ShowDialog();

        }


        private void Enrollment_Btn_Click(object sender, EventArgs e)
        {
            position(Enrollment_Btn);
            Active(Enrollment_Btn);
            FirstMain firstMain = new FirstMain();
            firstMain.ShowDialog();

        }


        private void Reports_Click(object sender, EventArgs e)
        {
            position(AddStudent_Btn);
            Active(AddStudent_Btn);
            Report_Details r4 = new Report_Details(enrollment);
            r4.ShowDialog();
        }
        private void Active(Button b)
        {
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    if (ctr.Name == b.Name)
                    {
                        b.BackColor = Color.FromArgb(2, 62, 138);
                        // b.ForeColor = Color.FromArgb(173, 232, 244);
                    }
                    else
                    {
                        ctr.BackColor = Color.FromArgb(3, 4, 94);
                        b.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void EditStudent_Btn_Click_1(object sender, EventArgs e)
        {
            position(EditStudent_Btn);
            Active(EditStudent_Btn);
            Name s1 = new Name(enrollment);
            s1.ShowDialog();

            dataGridView.DataSource = new BindingList<Student>(db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList());
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[3].Visible = false;
        }

        private void Report_Btn_Click(object sender, EventArgs e)
        {
            position(Report_Btn);
            Active(Report_Btn);
            Report_Details r4 = new Report_Details(enrollment);
            r4.ShowDialog();
        }

        private void AddStudent_Btn_Click_1(object sender, EventArgs e)
        {
            position(AddStudent_Btn);
            Active(AddStudent_Btn);
            Add_Students a4 = new Add_Students(enrollment);

            a4.ShowDialog();
            dataGridView.DataSource = new BindingList<Student>(db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList());
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[3].Visible = false;

        }

        private void GroupInformation_ResizeEnd(object sender, EventArgs e)
        {
            label1.Location = new System.Drawing.Point((this.Width / 2) - 100, this.Height - 100);

        }
    }
}
