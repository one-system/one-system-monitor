using OneSystemMonitor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OneSystemMonitor.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class OneSystemMonitorPageModel : AbpPageModel
    {
        protected OneSystemMonitorPageModel()
        {
            LocalizationResourceType = typeof(OneSystemMonitorResource);
            ObjectMapperContext = typeof(OneSystemMonitorWebModule);
        }
    }
}