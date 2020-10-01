using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(OneSystemMonitorDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class OneSystemMonitorApplicationContractsModule : AbpModule
    {

    }
}
