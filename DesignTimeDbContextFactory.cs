using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Redoak.Domain.Model.Models;

namespace Redoak.Domain.Model
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RedoakContext>
    {
        public RedoakContext CreateDbContext(string[] args)
        {

            Console.WriteLine(Directory.GetCurrentDirectory());
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RedoakContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new RedoakContext(builder.Options);
        }
    }
}
