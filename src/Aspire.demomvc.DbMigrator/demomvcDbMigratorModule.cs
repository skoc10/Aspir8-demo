using Aspire.demomvc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Aspire.demomvc.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(demomvcEntityFrameworkCoreModule),
    typeof(demomvcApplicationContractsModule)
)]
public class demomvcDbMigratorModule : AbpModule
{
}
