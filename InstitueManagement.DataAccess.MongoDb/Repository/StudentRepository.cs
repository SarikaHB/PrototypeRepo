using InstitueManagement.DataAccess.MongoDb.Models;
using System.Collections.Generic;

namespace InstitueManagement.DataAccess.MongoDb.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public IStudentData GetStudentDataById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<IStudentData> GetStudentDatas()
        {
            throw new System.NotImplementedException();
        }
    }
}
