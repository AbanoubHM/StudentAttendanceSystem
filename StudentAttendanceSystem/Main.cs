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
            string[] Quarters = new string[] { "Quarter1", "Quarter2", "Quarter3", "Quarter4" };
            ITIQuarter_Combo.Items.AddRange(Quarters);
            string[] TrackGroup = new string[] { "Group1", "Group2" };
            TrackGroupCombo.Items.AddRange(TrackGroup);
            string[] Tracks = new string[] { " FullStack.Net", "CyperSecurity", "FendoumentalSoftWare", "FullStackUsing | Paython" };
            Track_Combo.Items.AddRange(Tracks);
           



        }
        
        private void TrackQuarterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string x= TrackGroup.Text;
            if(x== "Group1")
            {
                if (TrackGroupCombo.SelectedItem == x)
                {

                }
            }
            
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void Open_btn_Click(object sender, EventArgs e)
        {
            GroupInformation g1 = new GroupInformation();
            g1.ShowDialog();
           
        }
        private void ITIQuarter_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
          

        }
        private void Track_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if()
        }
    }
}
