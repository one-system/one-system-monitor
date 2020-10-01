using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace OneSystemMonitor.MongoDB
{
    public static class OneSystemMonitorMongoDbContextExtensions
    {
        public static void ConfigureOneSystemMonitor(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OneSystemMonitorMongoModelBuilderConfigurationOptions(
                OneSystemMonitorDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}