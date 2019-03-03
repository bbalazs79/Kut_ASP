using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql;

namespace Kutatas_core.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DomainModelMySqlContext>
    {
        public DomainModelMySqlContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("config.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DomainModelMySqlContext>();

            var connectionString = configuration.GetConnectionString("DataAccessMySqlProvider");

            builder.UseMySql(connectionString);

            return new DomainModelMySqlContext(builder.Options);
        }
    }
}
