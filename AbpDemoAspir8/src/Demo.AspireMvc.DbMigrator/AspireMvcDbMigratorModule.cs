using Demo.AspireMvc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Demo.AspireMvc.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AspireMvcEntityFrameworkCoreModule),
    typeof(AspireMvcApplicationContractsModule)
)]
public class AspireMvcDbMigratorModule : AbpModule
{
}
