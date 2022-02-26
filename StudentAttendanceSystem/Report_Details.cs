using CrystalDecisions.CrystalReports.Engine;
using StudentAttendanceSystem.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class Report_Details : Form
    {
        Enrollment enrollment;
        public Report_Details(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;
        }
        //public Report_Details()
        //{
        //    InitializeComponent();
        //}

        private void Attendance_Btn_Click(object sender, EventArgs e)
        {
            Report_Attendance_save s6 = new Report_Attendance_save();
            s6.ShowDialog();
            this.Close();
        }

        private void Student_Data_Btn_Click(object sender, EventArgs e)
        {
        
            SqlConnection con = new SqlConnection("server =.;initial catalog=MyAttendanceDB;integrated security=True;MultipleActiveResultSets=True");

            Form2 f2 = new Form2();
            f2.Show();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand($"select s.NameAR, s.Name, s.NID, s.Email, s.Moblie, e.Track, s.City, s.MaterialState from [dbo].[Students] s inner join [dbo].[Enrollments] e on s.EnrollmentID = e.EnrollmentID where e.EnrollmentID={enrollment.EnrollmentID}", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Students");
            CrystalReport1 cr1 = new CrystalReport1();
            TextObject text1 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["ReportBranchText"];
            TextObject text2 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["ReportQuarterText"];
            TextObject text3 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["ReportTrackText"];
            text1.Text = enrollment.Branch;
            text2.Text = enrollment.Quarter;
            text3.Text = enrollment.Track;
            cr1.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource = cr1;
            f2.crystalReportViewer1.Refresh();

           

        }
    }
}
