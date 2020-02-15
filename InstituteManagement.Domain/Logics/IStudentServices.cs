using InstituteManagement.Domain.Models;
using System.Collections.Generic;

namespace InstituteManagement.Domain.Logics
{
    public interface IStudentServices
    {
        IList<IStudentDTO> GetStudents();
        IStudentDTO GetStudentById(int id);
    }
}
