using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem {
    public partial class Attended : Form {

        Enrollment enrollment;

        public Attended(Enrollment e1) {
            InitializeComponent();
            enrollment = e1;
        }

      

        private void Next_Click(object sender, EventArgs e)
        {

            DateTime attendDate = dateTimePicker1.Value.Date;

            Attend_Student s = new Attend_Student(attendDate,enrollment);
            
            s.ShowDialog();

            this.Close();

        }
        //private void Add_Click(object sender, EventArgs e) {
        //    string[] arr = { textBox1.Text, radioButton1.Text,  dateTimePicker1.Text };
        //    dataGridView1.Rows.Add(arr);
        //    textBox1.Text = "";



        //}
        //private void Name_Click(object sender, EventArgs e) {

        //}

        //private void Attend_Click(object sender, EventArgs e) {

        //}

        ////private void button2_Click_1(object sender, EventArgs e)
        ////{
        ////    string[] arr = { textBox1.Text, checkedListBox1.CheckedItems.ToString(), dateTimePicker1.Text };
        ////    dataGridView1.Rows.Add(arr);
        ////    textBox1.Text = "";


        ////}

        //private void Save_Click(object sender, EventArgs e) {
        //    int index = 0;
        //    DataGridViewRow r = dataGridView1.Rows[index];
        //    r.Cells[0].Value = textBox1.Text;

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        //    index = e.RowIndex;
        //    textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
        //    radioButton1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();

        //}

        //private void groupBox1_Enter(object sender, EventArgs e) {

        //}
    }
}
