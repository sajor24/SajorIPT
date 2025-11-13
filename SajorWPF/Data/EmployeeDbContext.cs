using Microsoft.EntityFrameworkCore;
using SajorIPT101Solution.SajorWPF.Models;

namespace SajorIPT101Solution.SajorWPF.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        // Optional: configure table names / constraints here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                b.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                b.Property(e => e.Position).HasMaxLength(100);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}