using Aspire.demomvc.Localization;
using Volo.Abp.Application.Services;

namespace Aspire.demomvc;

/* Inherit your application services from this class.
 */
public abstract class demomvcAppService : ApplicationService
{
    protected demomvcAppService()
    {
        LocalizationResource = typeof(demomvcResource);
    }
}
