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
            student.GradYear = int.Parse(GradYeartextBox.Text);//6
            student.MaterialState = MaterialStatetextBox.Text;//7
            student.Address = AddresstextBox.Text;//8
            student.City = CitytextBox.Text;//9
            student.Notes = textBox1.Text;//10
            student.Gender = char.Parse(GendertextBox.Text);//11
            student.NID = long.Parse(NIDtextBox.Text);//12
            student.Moblie = MobiletextBox.Text;//13
            student.Phone = PhonetextBox.Text;//14
            student.University = UniversitytextBox.Text;//15
            student.Faculty = FacultytextBox.Text;//16
            student.Specialization = SpecializationtextBox.Text;

            long nid=long.Parse(NIDtextBox.Text);
            var Nid = dataContext.Students.Where(x => x.NID == nid).ToList();

            if (Nid.Count() >0)
            {
                MessageBox.Show("Duplicate National ID");
            }
            else 
            {
                student.EnrollmentID = enrollmentt.EnrollmentID;
                dataContext.Students.Add(student);
                dataContext.SaveChanges();
                this.Close();



            }






        }
    }
}
