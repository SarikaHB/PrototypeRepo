namespace InstitueManagement.DataAccess.MongoDb.Models
{
    public interface IStudentData
    {
        int StudentId { get; set; }
        string StudentName { get; set; }
        int Age { get; set; }
        bool IsDeleted { get; set; }
    }
}
