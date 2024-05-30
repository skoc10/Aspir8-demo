using Volo.Abp.Modularity;

namespace Demo.AspireMvc;

/* Inherit from this class for your domain layer tests. */
public abstract class AspireMvcDomainTestBase<TStartupModule> : AspireMvcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
