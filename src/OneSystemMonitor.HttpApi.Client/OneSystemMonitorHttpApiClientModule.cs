using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(OneSystemMonitorApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OneSystemMonitorHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "OneSystemMonitor";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OneSystemMonitorApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
