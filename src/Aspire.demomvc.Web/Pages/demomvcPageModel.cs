using Aspire.demomvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Aspire.demomvc.Web.Pages;

public abstract class demomvcPageModel : AbpPageModel
{
    protected demomvcPageModel()
    {
        LocalizationResourceType = typeof(demomvcResource);
    }
}
