namespace InstituteManagement.Domain.Models
{
    public class StudentDTO : IStudentDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
