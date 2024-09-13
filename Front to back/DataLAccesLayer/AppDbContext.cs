using Front_to_back.DataLAccesLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Front_to_back.DataLAccesLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
