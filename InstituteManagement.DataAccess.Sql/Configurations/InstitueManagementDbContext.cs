using InstituteManagement.DataAccess.Sql.Models;
using Microsoft.EntityFrameworkCore;

namespace InstituteManagement.DataAccess.Sql.Configurations
{
    public class InstitueManagementDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = InstituteManagement_Db; Integrated Security = True");
        }
    }
}
