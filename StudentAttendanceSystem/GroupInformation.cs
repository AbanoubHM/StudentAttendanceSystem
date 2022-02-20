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


        private void GroupInformation_Load(object sender, EventArgs e)
        {
            position(Attended);
            p1.Height = Attended.Height;
            Active(Attended);
        }
        
        private void position (Button b)
        {
            p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);    
        }

        private void Attended_Click(object sender, EventArgs e) {
            
            Attended a = new Attended();
            a.ShowDialog();
            position(Attended);
            Active(Attended);
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EditStudentData_Click(object sender, EventArgs e)
        {
            position(EditStudentData);
            Active(EditStudentData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            position(button3);
            Active(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            position(button4);
            Active(button4);
        }
        private void Active (Button b)
        {
            foreach ( Control ctr in panel1.Controls)
            {
                if(ctr.GetType()==typeof(Button))
                {
                    if(ctr.Name==b.Name)
                    {
                        b.BackColor = Color.FromArgb(76, 76, 60);
                        b.ForeColor = Color.FromArgb(242, 215, 213);
                    }
                    else
                    {
                        ctr.BackColor = Color.FromArgb(77, 86, 86);
                        b.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
