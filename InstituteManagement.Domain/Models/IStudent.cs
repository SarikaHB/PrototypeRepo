namespace InstituteManagement.Domain.Models
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string StudentName { get; set; }
        int Age { get; set; }
        bool IsDeleted { get; set; }
    }
}
