using Microsoft.EntityFrameworkCore;

namespace EFRepro
{
    public class ReproDbContext(
        DbContextOptions options)
            : DbContext(options)
    {
        public virtual DbSet<Foo> Foos => Set<Foo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Foo>()
                .ToContainer("Foos")
                .HasPartitionKey(o => o.Bar) // Comment me - query filter becomes effective
                .HasQueryFilter(o => o.Bar == "A");

            base.OnModelCreating(modelBuilder);
        }
    }
}
