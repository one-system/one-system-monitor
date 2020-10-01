using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OneSystemMonitor.EntityFrameworkCore
{
    [ConnectionStringName(OneSystemMonitorDbProperties.ConnectionStringName)]
    public interface IOneSystemMonitorDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}