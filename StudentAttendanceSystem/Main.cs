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

namespace StudentAttendanceSystem
{
    public partial class Main : Form
    {

        DataContext DB = new DataContext();

    


        public Main()
        {
           
            InitializeComponent();

           // var Quarters = DB.Enrollments;
            ITIQuarter_Combo.DataSource= DB.Enrollments.Select(e=>e.Quarter).Distinct().ToList();

            
           



        }
        
      
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void Open_btn_Click(object sender, EventArgs e)
        {
            GroupInformation g1 = new GroupInformation();

            
            g1.ShowDialog();
            
        }

        private void ITIQuarter_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboBox comboBox = (ComboBox)sender ;
            string search=  comboBox.SelectedItem.ToString();
            var Trackes = DB.Enrollments.Where(a=>a.Quarter== search).Select(a => a.Track).ToList();
            Track_Combo.DataSource = Trackes;

          

           

        }
       
        private void Track_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if()
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstMain firstMain = new FirstMain();
            firstMain.ShowDialog();
        }
    }
}
