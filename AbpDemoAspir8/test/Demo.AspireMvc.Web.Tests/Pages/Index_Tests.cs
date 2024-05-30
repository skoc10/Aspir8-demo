using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Demo.AspireMvc.Pages;

[Collection(AspireMvcTestConsts.CollectionDefinitionName)]
public class Index_Tests : AspireMvcWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
