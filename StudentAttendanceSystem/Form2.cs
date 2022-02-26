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
    public partial class Form2 : Form

    {
        Enrollment enrollment;
        DataContext db = new DataContext();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;

        }
    }
}
