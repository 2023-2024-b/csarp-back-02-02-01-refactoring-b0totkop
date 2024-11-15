using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;

namespace Kreata.Backend.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthDay = teacher.BirthDay,
                PlaceOfBirth = teacher.PlaceOfBirth,
                IsWoman = teacher.IsWoman,
                IsHeadTeacher = teacher.IsHeadTeacher,
                MathersName = teacher.MathersName,
            };
        }

        public static Teacher ToTeacher(this TeacherDto teacherdto)
        {
            return new Teacher
            {
                Id = teacherdto.Id,
                FirstName = teacherdto.FirstName,
                LastName = teacherdto.LastName,
                BirthDay = teacherdto.BirthDay,
                PlaceOfBirth = teacherdto.PlaceOfBirth,
                IsWoman = teacherdto.IsWoman,
                IsHeadTeacher = teacherdto.IsHeadTeacher,
                MathersName = teacherdto.MathersName,
            };
        }
    }

}