using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace OneSystemMonitor
{
    [Dependency(ReplaceServices = true)]
    public class OneSystemMonitorBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OneSystemMonitor";
    }
}
