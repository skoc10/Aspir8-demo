using Volo.Abp.Modularity;

namespace Aspire.demomvc;

public abstract class demomvcApplicationTestBase<TStartupModule> : demomvcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
