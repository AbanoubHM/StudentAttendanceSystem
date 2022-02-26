using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class Name : Form
        
    {
        int i = 0;
        Enrollment enrollment;
        int index;
        DataContext context=new DataContext();
        //SqlConnection sqlCon = new SqlConnection("server =DESKTOP-QJJRVLP\\HUSSAINSQL;initial catalog=MyAttendanceDB;integrated security=True;MultipleActiveResultSets=True");
        //BindingList<Student> students;
        public Name(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentData_Resize(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(this.Width,(int)(this.Height*0.7));
            Save_Btn.Location = new System.Drawing.Point(Width / 2 - 200, Height - 100);
            Back_Btn.Location = new System.Drawing.Point(Width / 2 + 50, Height - 100);
            this.Invalidate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            //asdfsadf;
        }

        private void CityLbl_Click(object sender, EventArgs e)
        {

        }

        private void NotesLbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Name_Load(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(this.Width, (int)(this.Height * 0.7));
            Save_Btn.Location = new System.Drawing.Point((Width / 2 )- 200, Height - 100);
            Back_Btn.Location = new System.Drawing.Point((Width / 2 )+ 50, Height - 100);

            BindingList<Student> students = new BindingList<Student>(context.Students.Where(w=>w.EnrollmentID==enrollment.EnrollmentID).ToList());
            dataGridView1.DataSource = students;
        }
        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }
        

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (OleDbConnection conn = new OleDbConnection("server =DESKTOP-QJJRVLP\\HUSSAINSQL;initial catalog=MyAttendanceDB;integrated security=True;MultipleActiveResultSets=True"))
                {
                    conn.Open();
                    using (OleDbCommand cmd = conn.CreateCommand())
                    {
                        int id;
                        if (this.i > 0)
                        {
                            id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        }
                        else
                        {
                            id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        }
                        cmd.CommandText = @"delete from Table1 where ID=" + id;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Deleted.");
                    }
                }
            }
            dataGridView1.DataSource = BindSource();
            i++;
        }
    }
}
