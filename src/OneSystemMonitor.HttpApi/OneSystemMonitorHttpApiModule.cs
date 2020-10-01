using Localization.Resources.AbpUi;
using OneSystemMonitor.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(OneSystemMonitorApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class OneSystemMonitorHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OneSystemMonitorHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<OneSystemMonitorResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
