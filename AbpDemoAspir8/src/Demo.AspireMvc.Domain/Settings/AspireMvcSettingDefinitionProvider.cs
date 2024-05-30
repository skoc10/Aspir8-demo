using Volo.Abp.Settings;

namespace Demo.AspireMvc.Settings;

public class AspireMvcSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AspireMvcSettings.MySetting1));
    }
}
