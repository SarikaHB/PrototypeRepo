namespace InstituteManagement.Domain.Models
{
    public class Student : IStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
    }
}
