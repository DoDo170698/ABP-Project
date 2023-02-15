using SampleDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SampleDemo.Permissions;

public class SampleDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SampleDemoPermissions.GroupName);

        myGroup.AddPermission(SampleDemoPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(SampleDemoPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(SampleDemoPermissions.MyPermission1, L("Permission:MyPermission1"));

        var categoryPermission = myGroup.AddPermission(SampleDemoPermissions.Categories.Default, L("Permission:Categories"));
        categoryPermission.AddChild(SampleDemoPermissions.Categories.Create, L("Permission:Create"));
        categoryPermission.AddChild(SampleDemoPermissions.Categories.Edit, L("Permission:Edit"));
        categoryPermission.AddChild(SampleDemoPermissions.Categories.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SampleDemoResource>(name);
    }
}