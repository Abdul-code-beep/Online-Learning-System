using System.Data.Entity;

namespace OnlineLearningSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("UserDataConnection") { }

        public DbSet<User> Users { get; set; }
    }
}
