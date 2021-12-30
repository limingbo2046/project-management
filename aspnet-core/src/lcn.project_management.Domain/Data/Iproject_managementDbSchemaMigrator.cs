using System.Threading.Tasks;

namespace lcn.project_management.Data
{
    public interface Iproject_managementDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
