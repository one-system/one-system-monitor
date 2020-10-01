using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OneSystemMonitor.EntityFrameworkCore
{
    public class OneSystemMonitorModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OneSystemMonitorModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}