﻿using System;
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
            //TrackGroupCombo.Items.AddRange(TrackGroup);
            string[] Tracks = new string[] { " FullStack.Net", "CyperSecurity", "FendoumentalSoftWare", "FullStackUsing | Paython" };
            Track_Combo.Items.AddRange(Tracks);
           



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
