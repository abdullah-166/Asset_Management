using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Asset_Management.DataModels;
using Asset_Management.Models;

namespace Asset_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Asset> Assets {  get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DistributedAsset> DistributedAssets { get; set; }
    }
}
