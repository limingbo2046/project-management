using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using lcn.project_management.Data;
using Volo.Abp.DependencyInjection;

namespace lcn.project_management.EntityFrameworkCore
{
    public class EntityFrameworkCoreproject_managementDbSchemaMigrator
        : Iproject_managementDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreproject_managementDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the project_managementDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<project_managementDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
