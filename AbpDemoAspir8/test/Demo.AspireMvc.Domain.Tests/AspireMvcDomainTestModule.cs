using Volo.Abp.Modularity;

namespace Demo.AspireMvc;

[DependsOn(
    typeof(AspireMvcDomainModule),
    typeof(AspireMvcTestBaseModule)
)]
public class AspireMvcDomainTestModule : AbpModule
{

}
