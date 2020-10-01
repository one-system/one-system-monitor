using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace OneSystemMonitor.MongoDB
{
    public class OneSystemMonitorMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OneSystemMonitorMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}