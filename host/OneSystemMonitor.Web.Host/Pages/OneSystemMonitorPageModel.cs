using OneSystemMonitor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OneSystemMonitor.Pages
{
    public abstract class OneSystemMonitorPageModel : AbpPageModel
    {
        protected OneSystemMonitorPageModel()
        {
            LocalizationResourceType = typeof(OneSystemMonitorResource);
        }
    }
}