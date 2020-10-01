using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace OneSystemMonitor.Pages
{
    public class IndexModel : OneSystemMonitorPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}