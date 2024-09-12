using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CommerceProject.Data;

/* This is used if database provider does't define
 * ICommerceProjectDbSchemaMigrator implementation.
 */
public class NullCommerceProjectDbSchemaMigrator : ICommerceProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
