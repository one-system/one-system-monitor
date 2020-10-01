using OneSystemMonitor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OneSystemMonitor
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OneSystemMonitorEntityFrameworkCoreTestModule)
        )]
    public class OneSystemMonitorDomainTestModule : AbpModule
    {

    }
}
