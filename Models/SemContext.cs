using Microsoft.EntityFrameworkCore;

namespace semaphore_proj.Models
{
    public class SemContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public SemContext(DbContextOptions<SemContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}