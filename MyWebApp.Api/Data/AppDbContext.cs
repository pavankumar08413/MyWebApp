using Microsoft.EntityFrameworkCore;
using MyWebApp.Api.Models;

namespace MyWebApp.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FinOps_Requests> FinOps_Requests => Set<FinOps_Requests>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // optional model config
            modelBuilder.Entity<FinOps_Requests>().Property(p => p.FID).HasColumnType("int");
        }
    }
}