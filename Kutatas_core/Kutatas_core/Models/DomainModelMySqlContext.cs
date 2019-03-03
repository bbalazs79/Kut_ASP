using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    public class DomainModelMySqlContext : DbContext
    {
        public DomainModelMySqlContext(DbContextOptions<DomainModelMySqlContext> options) : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
    }
}
