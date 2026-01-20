using System.Data.Entity;

namespace CodeFirstStudentApp
{
    // MUST inherit from DbContext
    public class SchoolContext : DbContext
    {
        // This is the database name
        public SchoolContext() : base("StudentDatabase")
        {
        }

        // This creates the Students table
        public DbSet<Student> Students { get; set; }
    }
}
