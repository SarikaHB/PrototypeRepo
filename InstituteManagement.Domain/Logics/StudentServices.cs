using System.Collections.Generic;
using InstitueManagement.DataAccess.MongoDb.Repository;
using InstituteManagement.Domain.Models;

namespace InstituteManagement.Domain.Logics
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IStudent GetStudentById(int id)
        {
            var student = _studentRepository.GetStudentDataById(id);
            return null;
        }

        public IList<IStudent> GetStudents()
        {
            var students = _studentRepository.GetStudentDatas();
            return null;
        }
    }
}
