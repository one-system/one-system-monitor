using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(OneSystemMonitorHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OneSystemMonitorConsoleApiClientModule : AbpModule
    {
        
    }
}
