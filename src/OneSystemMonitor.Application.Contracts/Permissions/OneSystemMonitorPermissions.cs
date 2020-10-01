using Volo.Abp.Reflection;

namespace OneSystemMonitor.Permissions
{
    public class OneSystemMonitorPermissions
    {
        public const string GroupName = "OneSystemMonitor";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OneSystemMonitorPermissions));
        }
    }
}