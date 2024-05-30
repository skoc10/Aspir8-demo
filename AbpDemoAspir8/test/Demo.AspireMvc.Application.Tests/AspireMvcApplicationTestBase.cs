using Volo.Abp.Modularity;

namespace Demo.AspireMvc;

public abstract class AspireMvcApplicationTestBase<TStartupModule> : AspireMvcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
