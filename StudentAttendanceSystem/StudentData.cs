using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        int index;
        DataContext context=new DataContext();
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
            //NametextBox.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();//1
            //NameARtextBox.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();//3
            //GendertextBox.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();//11
            //NIDtextBox.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();//12
            //CitytextBox.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();//9
            //AddresstextBox.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();//8
            //MobiletextBox.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();//13
            //PhonetextBox.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();//14
            //EmailtextBox.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
            //UniversitytextBox.Text = dataGridView1.Rows[index].Cells[11].Value.ToString();//15
            //FacultytextBox.Text = dataGridView1.Rows[index].Cells[12].Value.ToString();//16
            //SpecializationtextBox.Text = dataGridView1.Rows[index].Cells[13].Value.ToString();
            //GradYeartextBox.Text = dataGridView1.Rows[index].Cells[14].Value.ToString();//6
            //GradetextBox.Text = dataGridView1.Rows[index].Cells[15].Value.ToString();

            //MilitaryStatetextBox.Text = dataGridView1.Rows[index].Cells[16].Value.ToString();//4
            //MaterialStatetextBox.Text = dataGridView1.Rows[index].Cells[17].Value.ToString();//7
            //textBox1.Text = dataGridView1.Rows[index].Cells[18].Value.ToString();//10





            //GradetextBox.Text = dataGridView1.Rows[index].Cells[15].Value.ToString();//5


            ///***
            // *Nid 5 city 6add 7 mobile 8 phone 9email 10uni 11fac 12 spec 13year int 14grade 15militart 16single 17 notes 18
            // */
            //GradYeartextBox.Text = dataGridView1.Rows[index].Cells[14].Value.ToString();//6
            //MaterialStatetextBox.Text = dataGridView1.Rows[index].Cells[17].Value.ToString();//7
            //AddresstextBox.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();//8
            //CitytextBox.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();//9
            //EmailtextBox.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();//10
            //NIDtextBox.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();//12
            //MobiletextBox.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();//13
            //PhonetextBox.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();//14
            //UniversitytextBox.Text = dataGridView1.Rows[index].Cells[11].Value.ToString();//15
            //FacultytextBox.Text = dataGridView1.Rows[index].Cells[12].Value.ToString();//16
            //SpecializationtextBox.Text = dataGridView1.Rows[index].Cells[13].Value.ToString();
            ////textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            ////textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }
        int i = 0;

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btndelete")
            {
                using (OleDbConnection conn = new OleDbConnection(sqlCon))
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
