using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Aspire.demomvc.Pages;

[Collection(demomvcTestConsts.CollectionDefinitionName)]
public class Index_Tests : demomvcWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
