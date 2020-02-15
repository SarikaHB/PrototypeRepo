using InstituteManagement.DataAccess.Sql.Configurations;
using InstituteManagement.DataAccess.Sql.Models;
using System.Collections.Generic;
using System.Linq;

namespace InstituteManagement.DataAccess.Sql.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private  InstitueManagementDbContext _institueManagementDbContext = new InstitueManagementDbContext();

        //public StudentRepository(InstitueManagementDbContext institueManagementDbContext)
        //{
        //    _institueManagementDbContext = institueManagementDbContext;
        //}

        public IList<Student> GetStudents()
        {
            return _institueManagementDbContext.Students.ToList();
        }
        public Student GetStudentById(int id)
        {
            return _institueManagementDbContext.Students.Where(s => s.StudentId == id).FirstOrDefault();
        }
    }
}
