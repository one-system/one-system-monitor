using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OneSystemMonitor.EntityFrameworkCore
{
    [ConnectionStringName(OneSystemMonitorDbProperties.ConnectionStringName)]
    public class OneSystemMonitorDbContext : AbpDbContext<OneSystemMonitorDbContext>, IOneSystemMonitorDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public OneSystemMonitorDbContext(DbContextOptions<OneSystemMonitorDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureOneSystemMonitor();
        }
    }
}