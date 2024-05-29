using Volo.Abp.Modularity;

namespace Aspire.demomvc;

[DependsOn(
    typeof(demomvcDomainModule),
    typeof(demomvcTestBaseModule)
)]
public class demomvcDomainTestModule : AbpModule
{

}
