using Volo.Abp.Modularity;

namespace Aspire.demomvc;

[DependsOn(
    typeof(demomvcApplicationModule),
    typeof(demomvcDomainTestModule)
)]
public class demomvcApplicationTestModule : AbpModule
{

}
