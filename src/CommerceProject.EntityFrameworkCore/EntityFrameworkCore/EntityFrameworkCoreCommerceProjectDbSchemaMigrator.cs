using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CommerceProject.Data;
using Volo.Abp.DependencyInjection;

namespace CommerceProject.EntityFrameworkCore;

public class EntityFrameworkCoreCommerceProjectDbSchemaMigrator
    : ICommerceProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCommerceProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CommerceProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CommerceProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
