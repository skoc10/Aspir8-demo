using Xunit;

namespace Demo.AspireMvc.EntityFrameworkCore;

[CollectionDefinition(AspireMvcTestConsts.CollectionDefinitionName)]
public class AspireMvcEntityFrameworkCoreCollection : ICollectionFixture<AspireMvcEntityFrameworkCoreFixture>
{

}
