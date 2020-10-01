using OneSystemMonitor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OneSystemMonitor
{
    public abstract class OneSystemMonitorController : AbpController
    {
        protected OneSystemMonitorController()
        {
            LocalizationResource = typeof(OneSystemMonitorResource);
        }
    }
}
