using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using OneSystemMonitor.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace OneSystemMonitor
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class OneSystemMonitorDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<OneSystemMonitorDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<OneSystemMonitorResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/OneSystemMonitor");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("OneSystemMonitor", typeof(OneSystemMonitorResource));
            });
        }
    }
}
