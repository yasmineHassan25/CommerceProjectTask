using System.Threading.Tasks;

namespace CommerceProject.Data;

public interface ICommerceProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
