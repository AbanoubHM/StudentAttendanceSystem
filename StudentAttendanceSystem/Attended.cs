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
        int index;
        public Attended() {
            InitializeComponent();
        }

        private void Attended_Load(object sender, EventArgs e)
        {
            //dataGridView1.ColumnCount = 3;
            //dataGridView1.Columns[0].HeaderText = "Name";
            //dataGridView1.Columns[1].HeaderText = "Attend";
            //dataGridView1.Columns[2].HeaderText = "Date";
        }

        private void Next_Click(object sender, EventArgs e)
        {
          
            Attend_Student s = new Attend_Student();
            
            s.ShowDialog();
           
            

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
