using InstituteManagement.DataAccess.Sql.Models;
using InstituteManagement.DataAccess.Sql.Repository;
using InstituteManagement.Domain.Models;
using System.Collections.Generic;

namespace InstituteManagement.Domain.Logics
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IStudentDTO GetStudentById(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return null;
        }

        public IList<IStudentDTO> GetStudents()
        {
            var students = _studentRepository.GetStudents();
            return Map_StudentToStudentDTO(students);
        }

        private IList<IStudentDTO> Map_StudentToStudentDTO(IList<Student> students)
        {
            if (students == null)
            {
                return new List<IStudentDTO>();
            }
            IList<IStudentDTO> studentDTOs = new List<IStudentDTO>();
            foreach (var student in students)
            {
                studentDTOs.Add(new StudentDTO
                {
                    StudentId = student.StudentId,
                    StudentName = student.StudentName,
                    Age = student.Age
                });
            }
            return studentDTOs;
        }
    }
}
