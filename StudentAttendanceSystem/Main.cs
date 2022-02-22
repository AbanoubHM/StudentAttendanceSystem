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

namespace StudentAttendanceSystem {
    public partial class Main : Form {

        DataContext DB = new DataContext();


        public Main() {

            InitializeComponent();

            ITIQuarter_Combo.DataSource = DB.Enrollments.Select(e => e.Quarter).Distinct().ToList();


        }


        private void Close_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Open_btn_Click(object sender, EventArgs e) {



            var ee = from Enrollment in DB.Enrollments
                     where (Enrollment.Quarter == ITIQuarter_Combo.SelectedItem.ToString()) &&
                     (Enrollment.Track == Track_Combo.SelectedItem.ToString())
                     select Enrollment;

            
            GroupInformation g1 = new GroupInformation(ee.ToList()[0] as Enrollment);


            g1.ShowDialog();

        }

        private void ITIQuarter_Combo_SelectedIndexChanged(object sender, EventArgs e) {

            Track_Combo.DataSource = DB.Enrollments.Where(a => a.Quarter == ITIQuarter_Combo.SelectedItem.ToString()).Select(a => a.Track).ToList();

        }

        
        private void button1_Click(object sender, EventArgs e) {
            FirstMain firstMain = new FirstMain();
            firstMain.ShowDialog();
            ITIQuarter_Combo.DataSource = DB.Enrollments.Select(h => h.Quarter).Distinct().ToList();

        }
    }
}
