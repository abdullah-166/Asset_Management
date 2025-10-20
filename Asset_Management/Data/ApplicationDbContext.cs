using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Asset_Management.DataModels;

namespace Asset_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Component> Components { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
    }
}
