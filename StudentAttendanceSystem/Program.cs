using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            #region CodeFirst Database Creation
            DateTime x = DateTime.Now;
            DataContext context = new DataContext();
            TrackInfo trackInfo = new TrackInfo()
            {
                Branch = "aaa",
                ID = 1,
                Quarter = "A",
                Track = "s"
            };

            Student student = new Student()
            {
                Address = "aaaa",
                Gender = 'm',
                City = "aa",
                Email = "Ali@dd",
                Faculty = "SS",
                Grade = "One",
                GradYear = x,
                MaterialState = "w",
                MilitaryState = "ss",
                Moblie = "00202",
                Name = "Ale",
                NameAR = "aa",
                NID = 379,
                Notes = "22",
                Phone = "1111",
                StudentID = 1,
                Specialization = "s",
                University = "ss"
            };
            Attendance attendance = new Attendance()
            {
                ADate = x,
                Excuse = "aa",
                Presence = true

            };

            context.Students.Add(student);

            context.SaveChanges();
            #endregion





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Hello Fady
            //Hello Bebo
        }
    }
}
