using Volo.Abp.Settings;

namespace lcn.project_management.Settings
{
    public class project_managementSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(project_managementSettings.MySetting1));
        }
    }
}
