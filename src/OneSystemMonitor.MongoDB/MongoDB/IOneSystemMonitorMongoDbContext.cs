using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace OneSystemMonitor.MongoDB
{
    [ConnectionStringName(OneSystemMonitorDbProperties.ConnectionStringName)]
    public interface IOneSystemMonitorMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
