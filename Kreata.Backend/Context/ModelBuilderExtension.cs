using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Márton",
                    LastName="Fontos",
                    BirthDay=new DateTime(2000,1,10),
                    IsWoman=false,
                    IsHeadTeacher=false
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Tamás",
                    LastName="Tanár",
                    BirthDay=new DateTime(1997,4,4),
                    IsWoman=false,
                    IsHeadTeacher=true
                }
            };

            // Teacher
            modelBuilder.Entity<Teacher>().HasData(teachers);

            List<Janitor> janitors = new List<Janitor>
            {
                new Janitor
                {
                    Id=Guid.NewGuid(),
                    FirstName="Béla",
                    LastName="Bence",
                    BirthsDay=new DateTime(2000,6,11),
                    IsWoomen=false,
                    IsAdministrator=true
                },
                new Janitor
                {
                    Id=Guid.NewGuid(),
                    FirstName="Áron",
                    LastName="Takács",
                    BirthsDay=new DateTime(1995,3,21),
                    IsWoomen=false,
                    IsAdministrator=false
                }
            };

            // Janitor
            modelBuilder.Entity<Janitor>().HasData(janitors);
        }
    }
}
