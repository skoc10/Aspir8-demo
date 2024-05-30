using Volo.Abp.Modularity;

namespace Demo.AspireMvc;

[DependsOn(
    typeof(AspireMvcApplicationModule),
    typeof(AspireMvcDomainTestModule)
)]
public class AspireMvcApplicationTestModule : AbpModule
{

}
