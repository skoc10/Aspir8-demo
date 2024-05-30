using Demo.AspireMvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Demo.AspireMvc.Web.Pages;

public abstract class AspireMvcPageModel : AbpPageModel
{
    protected AspireMvcPageModel()
    {
        LocalizationResourceType = typeof(AspireMvcResource);
    }
}
