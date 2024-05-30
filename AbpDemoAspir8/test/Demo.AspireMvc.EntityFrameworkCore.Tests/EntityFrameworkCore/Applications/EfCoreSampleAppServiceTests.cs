using Demo.AspireMvc.Samples;
using Xunit;

namespace Demo.AspireMvc.EntityFrameworkCore.Applications;

[Collection(AspireMvcTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AspireMvcEntityFrameworkCoreTestModule>
{

}
