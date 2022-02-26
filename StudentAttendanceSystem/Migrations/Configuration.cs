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

                new Student{Name = "Azza Dawoud",NameAR = "عزة داود",Address = "Shalaby",Gender = "Female",City = "Mnoufia",Email = "Azza.Dawoud@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2020 ,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928123429",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ahmed Shalaby",NameAR = "احمد شلبى",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381345676527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ahmed Ali",NameAR = "احمد علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928371234",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Abanoub Harby",NameAR = "ابانوب حربى",Address = "Mataria",Gender = "Male",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20380008376526",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "ElHussien Mohammed",NameAR = "الحسين محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20311118376525",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Fady Shafeek",NameAR = "فادى شفيق",Address = "Shobra",Gender = "Male",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928311124",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ahmed Ali",NameAR = "احمد علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20111128376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ayaa Harby",NameAR = "أيه حربى",Address = "Mataria",Gender = "Female",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20387777376526",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Alaa Mohammed",NameAR = "علاء محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381777776525",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "rabab soltan",NameAR = "رباب سلطان",Address = "Shobra",Gender = "Female",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20111128376524",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Alyaa Dawoud",NameAR = "علياء داود",Address = "Shalaby",Gender = "Female",City = "Mnoufia",Email = "Azza.Dawoud@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2020 ,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20000928376529",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ali Shalaby",NameAR = "علي شلبى",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20380008376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "mahmoud Ali",NameAR = "محمود علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20333338376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Elsayed Harby",NameAR = "السيد حربى",Address = "Mataria",Gender = "Male",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928312345",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Yousef Mohammed",NameAR = "يوسف محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381234576525",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Ragab Shafeek",NameAR = "رجب شفيق",Address = "Shobra",Gender = "Male",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928375434",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Seif Ali",NameAR = "سيف علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20666628376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Eman Harby",NameAR = "ايمان حربى",Address = "Mataria",Gender = "Female",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381333376526",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Zein Mohammed",NameAR = "زين محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381977771125",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Hager soltan",NameAR = "هاجر سلطان",Address = "Shobra",Gender = "Female",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928110024",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=1},
                new Student{Name = "Azza Dawoud",NameAR = "عزة داود",Address = "Shalaby",Gender = "Female",City = "Mnoufia",Email = "Azza.Dawoud@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2020 ,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "21100228376529",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Ahmed Shalaby",NameAR = "احمد شلبى",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "21381929876527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Ahmed Ali",NameAR = "احمد علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20698761376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Abanoub Harby",NameAR = "ابانوب حربى",Address = "Mataria",Gender = "Male",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928222111",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "ElHussien Mohammed",NameAR = "الحسين محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381110006525",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Fady Shafeek",NameAR = "فادى شفيق",Address = "Shobra",Gender = "Male",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928310024",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Ahmed Ali",NameAR = "احمد علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20311748376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Ayaa Harby",NameAR = "أيه حربى",Address = "Mataria",Gender = "Female",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20111444476526",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Alaa Mohammed",NameAR = "علاء محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381921111125",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "rabab soltan",NameAR = "رباب سلطان",Address = "Shobra",Gender = "Female",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20380008376524",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Alyaa Dawoud",NameAR = "علياء داود",Address = "Shalaby",Gender = "Female",City = "Mnoufia",Email = "Azza.Dawoud@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2020 ,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20000928376529",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Ali Shalaby",NameAR = "علي شلبى",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928370000",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "mahmoud Ali",NameAR = "محمود علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928300527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Elsayed Harby",NameAR = "السيد حربى",Address = "Mataria",Gender = "Male",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381920006526",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Yousef Mohammed",NameAR = "يوسف محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381912376525",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Ragab Shafeek",NameAR = "رجب شفيق",Address = "Shobra",Gender = "Male",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928371234",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Seif Ali",NameAR = "سيف علي",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",GradYear=2022,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20331928376527",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Eman Harby",NameAR = "ايمان حربى",Address = "Mataria",Gender = "Female",City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2019,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381928344446",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Zein Mohammed",NameAR = "زين محمد",Address = "Brket El-Sabaa",Gender = "Male",City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",GradYear=2021,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381925555525",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},
                new Student{Name = "Hager soltan",NameAR = "هاجر سلطان",Address = "Shobra",Gender = "Female",City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",GradYear=2020,MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = "20381921116524",Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia", EnrollmentID=2},




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
                 new Attend{ DailyAttendID=1, StudentID=10, Presence=true },
                 new Attend{ DailyAttendID=1, StudentID=11, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=12, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=13, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=14, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=15, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=16, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=17, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=18, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=19, Presence=true },
                 new Attend{ DailyAttendID=1, StudentID=20, Presence=true },

                 new Attend{ DailyAttendID=1, StudentID=21, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=22, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=23, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=24, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=25, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=26, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=27, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=28, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=29, Presence=true },
                 new Attend{ DailyAttendID=1, StudentID=30, Presence=true },

                 new Attend{ DailyAttendID=1, StudentID=31, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=32, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=33, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=34, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=35, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=36, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=37, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=38, Presence=true },
                new Attend{ DailyAttendID=1, StudentID=39, Presence=true },
                 new Attend{ DailyAttendID=1, StudentID=40, Presence=true },

                 



                new Attend{ DailyAttendID=2, StudentID=1, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=2, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=9, Presence=true }, new Attend{ DailyAttendID=1, StudentID=10, Presence=true },
                 new Attend{ DailyAttendID=2, StudentID=11, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=12, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=13, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=14, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=15, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=16, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=17, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=18, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=19, Presence=true },
                 new Attend{ DailyAttendID=2, StudentID=20, Presence=true },

                 new Attend{ DailyAttendID=2, StudentID=21, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=22, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=23, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=24, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=25, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=26, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=27, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=28, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=29, Presence=true },
                 new Attend{ DailyAttendID=2, StudentID=30, Presence=true },

                 new Attend{ DailyAttendID=2, StudentID=31, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=32, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=33, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=34, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=35, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=36, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=37, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=2, StudentID=38, Presence=true },
                new Attend{ DailyAttendID=2, StudentID=39, Presence=true },
                 new Attend{ DailyAttendID=2, StudentID=40, Presence=true },



                new Attend{ DailyAttendID=3, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=2, Presence=true},
                new Attend{ DailyAttendID=3, StudentID=3, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=8, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=9, Presence=true },
                 new Attend{ DailyAttendID=3, StudentID=10, Presence=true },
                 new Attend{ DailyAttendID=3, StudentID=11, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=12, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=13, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=14, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=15, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=16, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=17, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=18, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=19, Presence=true },
                 new Attend{ DailyAttendID=3, StudentID=20, Presence=true },

                 new Attend{ DailyAttendID=3, StudentID=21, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=22, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=23, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=24, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=25, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=26, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=27, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=28, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=29, Presence=true },
                 new Attend{ DailyAttendID=3, StudentID=30, Presence=true },

                 new Attend{ DailyAttendID=3, StudentID=31, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=32, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=3, StudentID=33, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=34, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=35, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=36, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=37, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=1, StudentID=38, Presence=true },
                new Attend{ DailyAttendID=3, StudentID=39, Presence=true },
                 new Attend{ DailyAttendID=3, StudentID=40, Presence=true },

                new Attend{ DailyAttendID=4, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=2, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=4, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=5, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=9, Presence=false, Excuse="Sick" },
                 new Attend{ DailyAttendID=4, StudentID=10, Presence=true },
                 new Attend{ DailyAttendID=4, StudentID=11, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=12, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=13, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=14, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=15, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=16, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=17, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=18, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=19, Presence=true },
                 new Attend{ DailyAttendID=4, StudentID=20, Presence=true },

                 new Attend{ DailyAttendID=4, StudentID=21, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=22, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=23, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=24, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=25, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=26, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=27, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=28, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=29, Presence=true },
                 new Attend{ DailyAttendID=4, StudentID=30, Presence=true },

                 new Attend{ DailyAttendID=4, StudentID=31, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=32, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=33, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=34, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=35, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=36, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=37, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=4, StudentID=38, Presence=true },
                new Attend{ DailyAttendID=4, StudentID=39, Presence=true },
                 new Attend{ DailyAttendID=4, StudentID=40, Presence=true },



                new Attend{ DailyAttendID=5, StudentID=1, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=2, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=3, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=4, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=5, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=6, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=7, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=8, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=9, Presence=true },
                 new Attend{ DailyAttendID=5, StudentID=10, Presence=true },
                 new Attend{ DailyAttendID=5, StudentID=11, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=12, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=13, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=14, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=15, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=16, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=17, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=18, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=19, Presence=true },
                 new Attend{ DailyAttendID=5, StudentID=20, Presence=true },

                 new Attend{ DailyAttendID=5, StudentID=21, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=22, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=23, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=24, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=25, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=26, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=27, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=28, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=29, Presence=true },
                 new Attend{ DailyAttendID=5, StudentID=30, Presence=true },

                 new Attend{ DailyAttendID=5, StudentID=31, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=32, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=33, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=34, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=35, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=36, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=37, Presence=false, Excuse="Sick" },
                new Attend{ DailyAttendID=5, StudentID=38, Presence=true },
                new Attend{ DailyAttendID=5, StudentID=39, Presence=true },
                 new Attend{ DailyAttendID=5, StudentID=40, Presence=true },
            };
            attends.ForEach(s => context.Attends.Add(s));
            context.SaveChanges();

        }
    }
}
