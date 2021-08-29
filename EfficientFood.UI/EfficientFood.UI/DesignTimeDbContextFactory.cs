using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EfficientFood.UI
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            string mySQLConnection = configuration["ConnectionStrings:DefaultConnection"].ToString();
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 23));

            builder.UseMySql(mySQLConnection, serverVersion);

            return new ApplicationDbContext(builder.Options);
        }
    }
}