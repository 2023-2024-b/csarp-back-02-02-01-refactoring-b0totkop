using System.Collections.Generic;
using System;
using System.Linq;
using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public class TeacherRepo
    {
        #region Database
        List<Teacher> _teachers = new()
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Martin",
                    LastName="Magyar",
                    BirthDay=new DateTime(2000,10,10),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Miskolc",
                    IsWoman=false,
                    MathersName="Miskolci Mária"
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Mirjam",
                    LastName="Metek",
                    BirthDay=new DateTime(2000,11,11),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Eger",
                    IsWoman=true,
                    MathersName="Egri Etelka"

                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthDay=new DateTime(2000,12,12),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Szabadka",
                    IsWoman=false,
                    MathersName="Szabadkai Szabina"

                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Éva",
                    LastName="Ének",
                    BirthDay=new DateTime(2000,1,1),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Baja",
                    IsWoman=true,
                    MathersName="Bajai Betti"
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Adorján",
                    LastName="Angol",
                    BirthDay=new DateTime(2000,3,3),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Kecskemét",
                    IsWoman=false,
                    MathersName="Kecskeméti Kati"
                }
            };
        #endregion

        public List<Teacher> FindAll()
        {
            return _teachers;
        }

        public void Delete(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }
        public void Save(Teacher teacher)
        {
            if (teacher.HasId)
                Update(teacher);
            else
                Insert(teacher);
        }

        private void Insert(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        private void Update(Teacher teacher)
        {
            Teacher? teacherToUpdate = _teachers.FirstOrDefault(s => s.Id == teacher.Id);
            teacherToUpdate?.Set(teacher);
        }
    }
}
