using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem {
    public partial class GroupInformation : Form {

        Enrollment enrollment;
        DataContext db=new DataContext();

        public GroupInformation(Enrollment e1) {
            InitializeComponent();
            enrollment = e1;
            
        }




        private void GroupInformation_Load(object sender, EventArgs e) {
            position(Attended);
            p1.Height = Attended.Height;
            Active(Attended);

            dataGridView.DataSource = db.Students.Where(a => a.EnrollmentID == enrollment.EnrollmentID).ToList();
        }

        private void position(Button b) {
            p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);
        }

        private void Attended_Click(object sender, EventArgs e) {

            Attended a = new Attended();
            a.ShowDialog();
            position(Attended);
            Active(Attended);
        }



        private void Enrollment_Btn_Click(object sender, EventArgs e) {
            position(Enrollment_Btn);
            Active(Enrollment_Btn);
        }

        private void Reports_Click(object sender, EventArgs e) {
            position(Reports);
            Active(Reports);
        }
        private void Active(Button b) {
            foreach (Control ctr in panel1.Controls) {
                if (ctr.GetType() == typeof(Button)) {
                    if (ctr.Name == b.Name) {
                        b.BackColor = Color.FromArgb(76, 76, 60);
                        b.ForeColor = Color.FromArgb(242, 215, 213);
                    } else {
                        ctr.BackColor = Color.FromArgb(77, 86, 86);
                        b.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditStudent_Btn_Click(object sender, EventArgs e) {
            position(EditStudent_Btn);
            Active(EditStudent_Btn);
        }


        private void EditStudent_Btn_Click_1(object sender, EventArgs e) {
            position(EditStudent_Btn);
            Active(EditStudent_Btn);
        }



    }
}
