using lcn.project_management.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace lcn.project_management.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(project_managementEntityFrameworkCoreModule),
        typeof(project_managementApplicationContractsModule)
        )]
    public class project_managementDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
