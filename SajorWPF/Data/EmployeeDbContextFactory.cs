using Microsoft.EntityFrameworkCore;

namespace SajorIPT101Solution.SajorWPF.Data
{
    public class EmployeeDbContextFactory
    {
        private readonly DbContextOptions<EmployeeDbContext> _options;

        public EmployeeDbContextFactory(DbContextOptions<EmployeeDbContext> options)
        {
            _options = options;
        }

        public EmployeeDbContext CreateDbContext()
        {
            return new EmployeeDbContext(_options);
        }
    }
}