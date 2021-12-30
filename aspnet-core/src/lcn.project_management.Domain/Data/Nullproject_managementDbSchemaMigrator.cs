using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace lcn.project_management.Data
{
    /* This is used if database provider does't define
     * Iproject_managementDbSchemaMigrator implementation.
     */
    public class Nullproject_managementDbSchemaMigrator : Iproject_managementDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}