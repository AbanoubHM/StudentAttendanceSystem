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
//<<<<<<< BindingList-Trials
        public Enrollment enrollment { get; set; }
        public Add_Students(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;
//=======
        public Enrollment enrollmentt { get; set; }
        DataContext dataContext = new DataContext();
        //BindingList<Student> students;
        public Add_Students(Enrollment enrollment)
        {
            InitializeComponent();
            enrollmentt = enrollment;

//>>>>>>> master
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
            bool yes = true;
            int a;
            if (int.TryParse(GradYeartextBox.Text, out a))
            {
                student.GradYear = a;

            }
            else
            { MessageBox.Show("You Entered invalid Year");yes = false; }
            //6
            student.MaterialState = MaterialStatetextBox.Text;//7
            student.Address = AddresstextBox.Text;//8
            student.City = CitytextBox.Text;//9
            student.Notes = textBox1.Text;//10
            student.Gender = GendertextBox.Text;




            student.NID = NIDtextBox.Text;
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

            else if (yes)
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
            else { MessageBox.Show("Please fixed Error Data "); }

            dataGridView.DataSource = new BindingList<Student>(dataContext.Students.Where((x) => x.EnrollmentID == enrollmentt.EnrollmentID).ToList());


        }

        private void Add_Students_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = new BindingList<Student>(dataContext.Students.Where((x) => x.EnrollmentID == enrollmentt.EnrollmentID).ToList());
        }
    }
}
