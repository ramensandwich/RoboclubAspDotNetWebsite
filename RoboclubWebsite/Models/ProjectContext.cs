using System.Data.Entity;

namespace RoboclubWebsite.Models
{
    public class ProjectContext : DbContext
    {


        public DbSet<Project> Projects { get; set; }
    }
}