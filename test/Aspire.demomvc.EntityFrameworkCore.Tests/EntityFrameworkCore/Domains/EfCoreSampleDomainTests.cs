using Aspire.demomvc.Samples;
using Xunit;

namespace Aspire.demomvc.EntityFrameworkCore.Domains;

[Collection(demomvcTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<demomvcEntityFrameworkCoreTestModule>
{

}
