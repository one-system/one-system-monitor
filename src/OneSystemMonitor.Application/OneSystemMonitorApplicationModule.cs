using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(OneSystemMonitorDomainModule),
        typeof(OneSystemMonitorApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class OneSystemMonitorApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<OneSystemMonitorApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<OneSystemMonitorApplicationModule>(validate: true);
            });
        }
    }
}
