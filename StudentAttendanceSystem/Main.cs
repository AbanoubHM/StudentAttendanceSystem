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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void TrackQuarterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            GroupInformation g1 = new GroupInformation();
            this.Hide();
            g1.ShowDialog();
            this.Show();
        }
    }
}
