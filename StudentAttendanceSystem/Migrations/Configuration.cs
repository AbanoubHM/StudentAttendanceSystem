namespace StudentAttendanceSystem.Migrations
{
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
            var students = new List<Student>
                {
                new Student{Name = "Azza Dawoud",NameAR = "عزة داود",Address = "Shalaby",Gender = 'F',City = "Mnoufia",Email = "Azza.Dawoud@gmail.com",Faculty = "CS",Grade = "Good",MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376529,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia"},
                new Student{Name = "Ahmed Shalaby",NameAR = "احمد شلبى",Address = "Shalaby",Gender = 'M',City = "Mnoufia",Email = "Ahmed.Shalaby@gmail.com",Faculty = "CS",Grade = "Very Good",MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376527,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia"},
                new Student{Name = "Abanoub Harby",NameAR = "ابانوب حربى",Address = "Mataria",Gender = 'M',City = "Assuit",Email = "Abanoub.harby@gmail.com",Faculty = "CS",Grade = "Good",MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376526,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia"},
                new Student{Name = "ElHussien Mohammed",NameAR = "الحسين محمد",Address = "Brket El-Sabaa",Gender = 'M',City = "Mnoufia",Email = "Elhussien@gmail.com",Faculty = "CS",Grade = "Good",MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376525,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia"},
                new Student{Name = "Fady Shafeek",NameAR = "فادى شفيق",Address = "Shobra",Gender = 'M',City = "Cairo",Email = "Fady.Shafeek.com",Faculty = "CS",Grade = "Good",MaterialState = "Single",MilitaryState = "N/A",Moblie = "01288335671",NID = 20381928376524,Notes = "Smart",Phone = "02115625",Specialization = "CS",University = "Mnoufia"}
                };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
