using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<Users> Users { get; set; }

        public DbSet<Tasks> Tasks { get; set; }
    }
}
