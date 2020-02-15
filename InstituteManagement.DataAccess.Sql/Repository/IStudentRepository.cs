using InstituteManagement.DataAccess.Sql.Models;
using System.Collections.Generic;

namespace InstituteManagement.DataAccess.Sql.Repository
{
    public interface IStudentRepository
    {
        IList<Student> GetStudents();
        Student GetStudentById(int id);
    }
}
