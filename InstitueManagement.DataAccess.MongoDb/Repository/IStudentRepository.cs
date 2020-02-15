using InstitueManagement.DataAccess.MongoDb.Models;
using System.Collections.Generic;

namespace InstitueManagement.DataAccess.MongoDb.Repository
{
    public interface IStudentMongoRepository
    {
        IList<IStudentData> GetStudentDatas();
        IStudentData GetStudentDataById(int id);
    }
}
