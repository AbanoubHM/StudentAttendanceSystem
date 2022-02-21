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
                new Student{Name = "Azza Dawoud",NameAR = "عزة داود",Address = "Shalaby",Gender = 'F',City = "Mnoufia",Email = "Ali@dd",Faculty = "SS",Grade = "One",MaterialState = "w",MilitaryState = "ss",Moblie = "00202",NID = 379,Notes = "22",Phone = "1111",ID = 1,Specialization = "s",University = "ss"},
                };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
