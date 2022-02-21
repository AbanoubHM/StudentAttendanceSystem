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
    public partial class FirstMain : Form
    {
        DataContext DB = new DataContext();
        public FirstMain()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //yearLbl.Text = dateTimePicker1.Value.AddYears(1).ToString();
            yearLbl.Text = "-  "+(dateTimePicker1.Value.Year+1).ToString();
        }

        private void FirstMain_Load(object sender, EventArgs e)
        {

        }

        private void QTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTrackBtn_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment() { Quarter = QTxtBox.SelectedItem.ToString()+" "+ (dateTimePicker1.Value.Year).ToString() +" "+ (dateTimePicker1.Value.Year + 1).ToString(),
                 Track = TrackTxtBox.SelectedItem.ToString(), Branch= "Minya"
            };
            DB.Enrollments.Add(enrollment);
            DB.SaveChanges();
            this.Close();
        }
    }
}
