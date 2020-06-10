using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HYPJ.Infrastructure.DesignTimeDbFactory
{
    public class StarCloudDbContextFactory : IDesignTimeDbContextFactory<StarCloudDbContext>
    {
        public StarCloudDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();
            var builder = new DbContextOptionsBuilder<StarCloudDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new StarCloudDbContext(builder.Options);
        }
    }
}
