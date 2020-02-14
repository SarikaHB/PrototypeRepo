namespace InstitueManagement.DataAccess.MongoDb.Models
{
    public class StudentData : IStudentData
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
    }
}
