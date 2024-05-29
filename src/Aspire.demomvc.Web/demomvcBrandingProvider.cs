using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Aspire.demomvc.Web;

[Dependency(ReplaceServices = true)]
public class demomvcBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "demomvc";
}
