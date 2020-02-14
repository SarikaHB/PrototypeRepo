using InstituteManagement.Domain.Models;
using System.Collections.Generic;

namespace InstituteManagement.Domain.Logics
{
    public interface IStudentServices
    {
        IList<IStudent> GetStudents();
        IStudent GetStudentById(int id);
    }
}
