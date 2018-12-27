using AtlasCompanyTracker.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace AtlasCompanyTracker.Database.Contexts
{
    public class ResourceContext : DbContext
    {
        public DbSet<ResourceModel> Resources { get; set; }

        public ResourceContext() { }
        public ResourceContext(DbContextOptions<ResourceContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AtlasCompanyTracker;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResourceModel>(entity =>
            {
                // Set key for entity
                entity.HasKey(x => x.ID);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
