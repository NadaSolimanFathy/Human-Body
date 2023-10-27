using Human_Body.Model;
using Microsoft.EntityFrameworkCore;

namespace Human_Body.Context
{
    public class HumanBodyDbContext:DbContext
    {

        public HumanBodyDbContext(DbContextOptions<HumanBodyDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<HumanBody> humanBodyOrgans { get; set; }
    }
}
