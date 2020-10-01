using OneSystemMonitor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OneSystemMonitor.Permissions
{
    public class OneSystemMonitorPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OneSystemMonitorPermissions.GroupName, L("Permission:OneSystemMonitor"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OneSystemMonitorResource>(name);
        }
    }
}