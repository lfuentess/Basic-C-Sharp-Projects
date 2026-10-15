using Microsoft.EntityFrameworkCore;
using StudentConsole.Models;

namespace StudentConsole.DataContext
{
    //this connect C# with the SQL SERVER database
    public class StudentDbContext : DbContext
    {
        //Represents the Students table in the database.
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string connection 
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS01;Integrated Security=True;Database=eStudentDb;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=30;Encrypt=True;");
        }
    }
}
