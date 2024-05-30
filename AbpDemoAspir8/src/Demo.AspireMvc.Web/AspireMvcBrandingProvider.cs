using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Demo.AspireMvc.Web;

[Dependency(ReplaceServices = true)]
public class AspireMvcBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AspireMvc";
}
