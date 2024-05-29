using Xunit;

namespace Aspire.demomvc.EntityFrameworkCore;

[CollectionDefinition(demomvcTestConsts.CollectionDefinitionName)]
public class demomvcEntityFrameworkCoreCollection : ICollectionFixture<demomvcEntityFrameworkCoreFixture>
{

}
