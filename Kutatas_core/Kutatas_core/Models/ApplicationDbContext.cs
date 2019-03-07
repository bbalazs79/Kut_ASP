using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Food> Food { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=donfamilia.hu;userid=Kutatas_ASP;password=MarkBalazs96!;database=Kutatas_ASP;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.PhoneNumber).IsUnique();
            });

            modelBuilder.Entity<Employee>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}
