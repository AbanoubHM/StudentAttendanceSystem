namespace StudentAttendanceSystem.Migrations
{
    using StudentAttendanceSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAttendanceSystem.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudentAttendanceSystem.DataContext context)
        {
            var enrollments = new List<Enrollment>
            {
                new Enrollment {Track="Fullstack Web Development Using .Net", Branch="Minya", Quarter= "2021 2022 Q2"},
                new Enrollment { Track = "Fullstack Web Development Using MEARN", Branch = "Minya", Quarter = "2021 2022 Q2"},
                new Enrollment { Track = "GIS", Branch = "Minya", Quarter = "2021 2022 Q3" },
                new Enrollment { Track = "Cyber Security", Branch = "Minya", Quarter = "2021 2022 Q1" }
        
               , new Enrollment { Track = "UI\\UX Design", Branch = "Minya", Quarter = "2020 2021 Q4" }
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var students = new List<Student>
                {
                new Student{Name = "Azza Dawoud",NameAR = "عزة داود",Address = "Shalaby",Gender = 'F',City = "Mnoufia",Email = "Azza.Dawoud@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2020 ,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376529,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ahmed Shalaby",NameAR = "احمد شلبى",Address = "Brket El-Sabaa",Gender = 'M',City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376527,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Abanoub Harby",NameAR = "ابانوب حربى",Address = "Mataria",Gender = 'M',City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376526,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "ElHussien Mohammed",NameAR = "الحسين محمد",Address = "Brket El-Sabaa",Gender = 'M',City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376525,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=4},
                new Student{Name = "Fady Shafeek",NameAR = "فادى شفيق",Address = "Shobra",Gender = 'M',City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376524,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=3}






                ,
                new Student{Name = "Ahmed Ali",NameAR = "احمد علي",Address = "Brket El-Sabaa",Gender = 'M',City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376527,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ayaa Harby",NameAR = "أيه حربى",Address = "Mataria",Gender = 'F',City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376526,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Alaa Mohammed",NameAR = "علاء محمد",Address = "Brket El-Sabaa",Gender = 'M',City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376525,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=4},
                new Student{Name = "rabab soltan",NameAR = "رباب سلطان",Address = "Shobra",Gender = 'F',City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376524,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=3}




                };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var dailyAttends = new List<DailyAttend> 
            { 
                new DailyAttend{ ADate= DateTime.Parse("2022-01-01")},
                new DailyAttend{ ADate= DateTime.Parse("2022-01-02")},
                new DailyAttend{ ADate= DateTime.Parse("2022-01-03")},
                new DailyAttend{ ADate= DateTime.Parse("2022-01-04")},
                new DailyAttend{ ADate= DateTime.Parse("2022-01-05")}
            };
            dailyAttends.ForEach(s => context.DailyAttends.Add(s));
            context.SaveChanges();

            var attends = new List<Attend>
            {
                new Attend{ DailyAttendID=1, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=2, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=7, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=9, Presence=true },



                new Attend{ DailyAttendID=2, StudentID=1, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=2, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=9, Presence=true },



                new Attend{ DailyAttendID=3, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=2, Presence=true},
                new Attend{ DailyAttendID=3, StudentID=3, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=8, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=9, Presence=true },

                new Attend{ DailyAttendID=4, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=2, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=4, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=9, Presence=false, Excuse="Sick" },



                new Attend{ DailyAttendID=5, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=2, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=5, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=9, Presence=true },
            };
            attends.ForEach(s => context.Attends.Add(s));
            context.SaveChanges();

        }
    }
}
