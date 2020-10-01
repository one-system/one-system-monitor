using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OneSystemMonitor.EntityFrameworkCore
{
    [DependsOn(
        typeof(OneSystemMonitorDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class OneSystemMonitorEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OneSystemMonitorDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}