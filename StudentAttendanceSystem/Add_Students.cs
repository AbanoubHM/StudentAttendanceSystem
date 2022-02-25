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
        public Enrollment enrollmentt { get; set; }
        DataContext dataContext = new DataContext();
        //BindingList<Student> students;
        public Add_Students(Enrollment enrollment)
        {
            InitializeComponent();
            enrollmentt = enrollment;

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            //check NID  71 
            Student student = new Student();
            student.Name = NametextBox.Text;//1
            student.Email = EmailtextBox.Text;//2
            student.NameAR = NameARtextBox.Text;//3
            student.MilitaryState = MilitaryStatetextBox.Text;//4
            student.Grade = GradetextBox.Text;//5
            bool res;
            int a=1;
            
            res = int.TryParse(GradYeartextBox.Text, out a);
            student.GradYear = a;//6
            student.MaterialState = MaterialStatetextBox.Text;//7
            student.Address = AddresstextBox.Text;//8
            student.City = CitytextBox.Text;//9
            student.Notes = textBox1.Text;//10
            char ch = 'M';
            res = char.TryParse(GendertextBox.Text,out ch);//11
            student.Gender=ch;

            long L = 12345678910;
            res = long.TryParse(NIDtextBox.Text,out L);//12
            student.NID = L;
            student.Moblie = MobiletextBox.Text;//13
            student.Phone = PhonetextBox.Text;//14
            student.University = UniversitytextBox.Text;//15
            student.Faculty = FacultytextBox.Text;//16
            student.Specialization = SpecializationtextBox.Text;

            var Nid = dataContext.Students.Where(x => x.NID == student.NID).ToList();

            if (Nid.Count() > 0)
            {
                MessageBox.Show("Duplicate National ID");
            }
            else
            {
                student.EnrollmentID = enrollmentt.EnrollmentID;
                dataContext.Students.Add(student);
                dataContext.SaveChanges();
                //this.Close();
                foreach (var ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        TextBox txt = (TextBox)ctr;
                        txt.Clear();
                    }

                }

                MessageBox.Show("Student Added");



            }

            dataGridView.DataSource = new BindingList<Student>(dataContext.Students.Where((x) => x.EnrollmentID == enrollmentt.EnrollmentID).ToList());


        }

        private void Add_Students_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = new BindingList<Student>(dataContext.Students.Where((x) => x.EnrollmentID == enrollmentt.EnrollmentID).ToList());
        }
    }
}
