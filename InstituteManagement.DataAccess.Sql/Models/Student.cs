namespace InstituteManagement.DataAccess.Sql.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
    }
}
