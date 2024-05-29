using Aspire.demomvc.Samples;
using Xunit;

namespace Aspire.demomvc.EntityFrameworkCore.Applications;

[Collection(demomvcTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<demomvcEntityFrameworkCoreTestModule>
{

}
