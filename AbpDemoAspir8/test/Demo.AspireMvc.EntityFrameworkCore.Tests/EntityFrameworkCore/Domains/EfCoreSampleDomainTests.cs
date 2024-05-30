using Demo.AspireMvc.Samples;
using Xunit;

namespace Demo.AspireMvc.EntityFrameworkCore.Domains;

[Collection(AspireMvcTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AspireMvcEntityFrameworkCoreTestModule>
{

}
