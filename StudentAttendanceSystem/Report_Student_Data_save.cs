﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceSystem.Reports;
using System.Data.Entity;
using CrystalDecisions.CrystalReports.Engine;

namespace StudentAttendanceSystem
{
    public partial class Report_Student_Data_save : Form
    {
        Enrollment enrollment;
        DataContext db = new DataContext();

        SqlConnection con = new SqlConnection("server =.;initial catalog=MyAttendanceDB;integrated security=True;MultipleActiveResultSets=True");

        public Report_Student_Data_save(Enrollment e1)
        {
            InitializeComponent();
            enrollment = e1;

        }
        public Report_Student_Data_save()
        {
            InitializeComponent();
        }

        private void Report_Student_Data_save_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select s.NameAR, s.Name, e.Track from [dbo].[Students] s inner join [dbo].[Enrollments] e on s.EnrollmentID = e.EnrollmentID where e.EnrollmentID={enrollment.EnrollmentID}", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            if(con.State!= ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand($"select s.NameAR, s.Name, s.NID, s.Email, s.Moblie, e.Track from [dbo].[Students] s inner join [dbo].[Enrollments] e on s.EnrollmentID = e.EnrollmentID where e.EnrollmentID={enrollment.EnrollmentID}", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Students");
            CrystalReport1 cr1 = new CrystalReport1();
            TextObject text = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["ReportTrackText"];
            text.Text = enrollment.Track;
            cr1.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource = cr1;
            f2.crystalReportViewer1.Refresh();
        }
    }
}
