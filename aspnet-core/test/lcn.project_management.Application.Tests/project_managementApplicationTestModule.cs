using Volo.Abp.Modularity;

namespace lcn.project_management
{
    [DependsOn(
        typeof(project_managementApplicationModule),
        typeof(project_managementDomainTestModule)
        )]
    public class project_managementApplicationTestModule : AbpModule
    {

    }
}