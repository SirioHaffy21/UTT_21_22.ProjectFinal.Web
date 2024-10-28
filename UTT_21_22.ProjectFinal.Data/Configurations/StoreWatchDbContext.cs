using Microsoft.EntityFrameworkCore;
using UTT_21_22.ProjectFinal.Data.Databases;

namespace UTT_21_22.ProjectFinal.Data.Configurations
{
    public class StoreWatchDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2017;Database=StoreWatchInformationDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreWatch>().HasKey(sw => new { sw.StoreId, sw.WatchId });

            modelBuilder.Entity<StoreWatch>()
                .HasOne<Watch>(sw => sw.Watch)
                .WithMany(s => s.StoreWatches)
                .HasForeignKey(sw => sw.WatchId);

            modelBuilder.Entity<StoreWatch>()
                .HasOne<Store>(sw => sw.Store)
                .WithMany(s => s.StoreWatches)
                .HasForeignKey(sw => sw.StoreId);
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<StoreWatch> StoreWatches { get; set; }
    }
}