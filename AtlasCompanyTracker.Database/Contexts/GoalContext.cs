using AtlasCompanyTracker.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace AtlasCompanyTracker.Database.Contexts
{
    public class GoalContext : DbContext
    {
        public DbSet<GoalModel> Goals { get; set; }

        public GoalContext() { }
        public GoalContext(DbContextOptions<GoalContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AtlasCompanyTracker;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GoalModel>(entity =>
            {
                // Set key for entity
                entity.HasKey(x => x.ID);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
