using Demo.AspireMvc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Demo.AspireMvc.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AspireMvcController : AbpControllerBase
{
    protected AspireMvcController()
    {
        LocalizationResource = typeof(AspireMvcResource);
    }
}
