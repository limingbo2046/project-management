using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace lcn.project_management
{
    [Dependency(ReplaceServices = true)]
    public class project_managementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "project_management";
    }
}
