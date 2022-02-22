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
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentData_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new System.Drawing.Size((int)(this.Width*.6), this.Height);
            this.Invalidate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            //GroupInformation b3 = new GroupInformation();
            //b3.ShowDialog();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            //gridData[rowIndex].Name = NameTextBox.Text;
            //gridData[rowIndex].Phone = int.Parse(PhoneTextBox.Text);
            //gridData[rowIndex].BirthDate = dateTimePicker1.Value;
            //dataGridView1.Invalidate();
        }
    }
}
