using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OneSystemMonitorDomainSharedModule)
    )]
    public class OneSystemMonitorDomainModule : AbpModule
    {

    }
}
