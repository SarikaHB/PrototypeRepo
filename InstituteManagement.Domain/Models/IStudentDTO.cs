namespace InstituteManagement.Domain.Models
{
    public interface IStudentDTO
    {
        int StudentId { get; set; }
        string StudentName { get; set; }
        int Age { get; set; }
    }
}
