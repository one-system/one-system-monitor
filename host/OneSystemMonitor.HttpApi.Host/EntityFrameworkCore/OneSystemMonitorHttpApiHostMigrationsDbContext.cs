using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OneSystemMonitor.EntityFrameworkCore
{
    public class OneSystemMonitorHttpApiHostMigrationsDbContext : AbpDbContext<OneSystemMonitorHttpApiHostMigrationsDbContext>
    {
        public OneSystemMonitorHttpApiHostMigrationsDbContext(DbContextOptions<OneSystemMonitorHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOneSystemMonitor();
        }
    }
}
