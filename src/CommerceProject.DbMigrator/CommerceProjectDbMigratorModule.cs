using CommerceProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CommerceProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CommerceProjectEntityFrameworkCoreModule),
    typeof(CommerceProjectApplicationContractsModule)
    )]
public class CommerceProjectDbMigratorModule : AbpModule
{
}
