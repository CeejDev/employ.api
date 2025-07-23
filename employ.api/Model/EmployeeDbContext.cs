using Microsoft.EntityFrameworkCore;

namespace employ.api.Model
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
    }
}
