using Volo.Abp.Modularity;

namespace Aspire.demomvc;

/* Inherit from this class for your domain layer tests. */
public abstract class demomvcDomainTestBase<TStartupModule> : demomvcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
