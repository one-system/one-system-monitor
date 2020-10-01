using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace OneSystemMonitor.MongoDB
{
    [DependsOn(
        typeof(OneSystemMonitorDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class OneSystemMonitorMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<OneSystemMonitorMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
