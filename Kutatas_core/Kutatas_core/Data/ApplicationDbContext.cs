using Kutatas_core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kutatas_core.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Food> Food { get; set; }

        //public DbSet<OrderCount> OrderCount { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }
}
