using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;

namespace Kreata.Backend.Converters
{
    public static class StudentConverter
    {
        public static StudentDto ToDto(Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthsDay = student.BirthsDay,
                IsWoomen = student.IsWoomen,
                EducationLevel = student.EducationLevel,
                SchoolClass = student.SchoolClass,
                SchoolYear = student.SchoolYear,
            };
        }

        public static Student ToModel(StudentDto student)
        {
            return new Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthsDay = student.BirthsDay,
                IsWoomen = student.IsWoomen,
                EducationLevel = student.EducationLevel,
                SchoolClass = student.SchoolClass,
                SchoolYear = student.SchoolYear,
            };
        }

        public static List<StudentDto> GetStudentsDtos(List<Student> students)
        {
            return students.Select(student => ToDto(student)).ToList();
        }

        public static List<Student> GetStudents(List<StudentDto> studentDtos)
        {
            return studentDtos.Select(studentDto => ToModel(studentDto)).ToList();
        }
    }
}
