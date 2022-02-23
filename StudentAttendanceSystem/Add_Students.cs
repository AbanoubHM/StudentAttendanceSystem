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
    public partial class Add_Students : Form
    {
        public Enrollment enrollment { get; set; }
        public Add_Students(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
