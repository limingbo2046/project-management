using lcn.project_management.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace lcn.project_management
{
    [DependsOn(
        typeof(project_managementEntityFrameworkCoreTestModule)
        )]
    public class project_managementDomainTestModule : AbpModule
    {

    }
}