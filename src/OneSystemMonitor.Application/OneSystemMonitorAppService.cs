using OneSystemMonitor.Localization;
using Volo.Abp.Application.Services;

namespace OneSystemMonitor
{
    public abstract class OneSystemMonitorAppService : ApplicationService
    {
        protected OneSystemMonitorAppService()
        {
            LocalizationResource = typeof(OneSystemMonitorResource);
            ObjectMapperContext = typeof(OneSystemMonitorApplicationModule);
        }
    }
}
