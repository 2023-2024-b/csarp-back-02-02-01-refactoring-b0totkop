using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;

namespace Kreata.Backend.Converters
{
    public static class TeacherConverter
    {
        public static TeacherDto ToDto(Teacher teacher)
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

        public static Teacher ToModel(TeacherDto teacher)
        {
            return new Teacher
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

        public static List<TeacherDto> GetTeachersDtos(List<Teacher> teachers)
        {
            return teachers.Select(teacher => ToDto(teacher)).ToList();
        }

        public static List<Teacher> GetTeachers(List<TeacherDto> teacherDtos)
        {
            return teacherDtos.Select(teacherDto => ToModel(teacherDto)).ToList();
        }
    }
}
