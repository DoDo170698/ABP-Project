using SampleDemoJob.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SampleDemoJob.Permissions;

public class SampleDemoJobPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SampleDemoJobPermissions.GroupName, L("Permission:SampleDemoJob"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SampleDemoJobResource>(name);
    }
}
