using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace OneSystemMonitor.MongoDB
{
    [DependsOn(
        typeof(OneSystemMonitorTestBaseModule),
        typeof(OneSystemMonitorMongoDbModule)
        )]
    public class OneSystemMonitorMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}