using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;


namespace TestSolution.DBContext
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DbContext>
    {
        public DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configurationRoot.GetConnectionString("TestSolutionDb");
            var optionBuilder = new DbContextOptionsBuilder<DbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new DbContext(optionBuilder.Options);
           
        }
    }
}
