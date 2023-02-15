using Volo.Abp.Reflection;

namespace SampleDemoJob.Permissions;

public class SampleDemoJobPermissions
{
    public const string GroupName = "SampleDemoJob";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SampleDemoJobPermissions));
    }
}
