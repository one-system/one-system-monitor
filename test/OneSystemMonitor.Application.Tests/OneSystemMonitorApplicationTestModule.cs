using Volo.Abp.Modularity;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(OneSystemMonitorApplicationModule),
        typeof(OneSystemMonitorDomainTestModule)
        )]
    public class OneSystemMonitorApplicationTestModule : AbpModule
    {

    }
}
