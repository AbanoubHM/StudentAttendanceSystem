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
    public partial class FirstMain : Form
    {
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
    }
}
