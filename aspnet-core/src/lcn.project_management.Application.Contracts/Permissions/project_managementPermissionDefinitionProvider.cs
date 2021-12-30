using lcn.project_management.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace lcn.project_management.Permissions
{
    public class project_managementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(project_managementPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(project_managementPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<project_managementResource>(name);
        }
    }
}
