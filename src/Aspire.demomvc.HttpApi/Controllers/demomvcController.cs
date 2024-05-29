using Aspire.demomvc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Aspire.demomvc.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class demomvcController : AbpControllerBase
{
    protected demomvcController()
    {
        LocalizationResource = typeof(demomvcResource);
    }
}
