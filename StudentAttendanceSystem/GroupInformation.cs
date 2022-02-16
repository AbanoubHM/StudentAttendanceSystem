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
    public partial class GroupInformation : Form
    {
        public GroupInformation()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     
        private void attendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Attended A = new Attended();
            A.Show();
         //   A.MdiParent = this;
            
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
