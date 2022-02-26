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
    public partial class Name : Form
    {
        Enrollment enrollment;
        DataContext context=new DataContext();
        public Name(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;
        }

        

        private void StudentData_Resize(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(this.Width,(int)(this.Height*0.7));
            Save_Btn.Location = new System.Drawing.Point(Width / 2 - 200, Height - 100);
            Back_Btn.Location = new System.Drawing.Point(Width / 2 + 50, Height - 100);
            this.Invalidate();
        }

       
        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            
        }

        
        private void Name_Load(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(this.Width, (int)(this.Height * 0.7));
            Save_Btn.Location = new System.Drawing.Point((Width / 2 )- 200, Height - 100);
            Back_Btn.Location = new System.Drawing.Point((Width / 2 )+ 50, Height - 100);

            BindingList<Student> students = new BindingList<Student>(context.Students.Where(w=>w.EnrollmentID==enrollment.EnrollmentID).ToList());
            dataGridView1.DataSource = students;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
        }
        
    }
}
