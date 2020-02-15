using InstituteManagement.DataAccess.Sql.Models;
using InstituteManagement.DataAccess.Sql.Repository;
using InstituteManagement.Domain.Models;
using System;
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
            return Map_StudentToStudentDTO(student);
        }

        public IList<IStudentDTO> GetStudents()
        {
            var students = _studentRepository.GetStudents();
            return Map_StudentsToStudentDTOs(students);
        }

        private IList<IStudentDTO> Map_StudentsToStudentDTOs(IList<Student> students)
        {
            if (students == null)
            {
                return new List<IStudentDTO>();
            }
            IList<IStudentDTO> studentDTOs = new List<IStudentDTO>();
            foreach (var student in students)
            {
                studentDTOs.Add(Map_StudentToStudentDTO(student));
            }
            return studentDTOs;
        }

        private IStudentDTO Map_StudentToStudentDTO(Student student)
        {
            if (student == null) { return new StudentDTO(); }

            return new StudentDTO
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Age = student.Age
            };
        }
    }
}
