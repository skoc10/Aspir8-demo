using Volo.Abp.Settings;

namespace Aspire.demomvc.Settings;

public class demomvcSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(demomvcSettings.MySetting1));
    }
}
