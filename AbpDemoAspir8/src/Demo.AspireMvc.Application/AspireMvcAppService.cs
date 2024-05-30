using Demo.AspireMvc.Localization;
using Volo.Abp.Application.Services;

namespace Demo.AspireMvc;

/* Inherit your application services from this class.
 */
public abstract class AspireMvcAppService : ApplicationService
{
    protected AspireMvcAppService()
    {
        LocalizationResource = typeof(AspireMvcResource);
    }
}
