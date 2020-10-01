using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OneSystemMonitor.EntityFrameworkCore
{
    public class OneSystemMonitorHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OneSystemMonitorHttpApiHostMigrationsDbContext>
    {
        public OneSystemMonitorHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OneSystemMonitorHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("OneSystemMonitor"));

            return new OneSystemMonitorHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
