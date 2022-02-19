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
    public partial class GroupInformation : Form {
       
        public GroupInformation() {
            InitializeComponent();
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }






        private void Attended_Click(object sender, EventArgs e) {
            this.Hide();
            Attended a = new Attended();
            a.ShowDialog();
            this.Show();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Main m = new Main();
            
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
