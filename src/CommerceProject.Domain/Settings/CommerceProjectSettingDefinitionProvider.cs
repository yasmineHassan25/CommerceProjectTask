using Volo.Abp.Settings;

namespace CommerceProject.Settings;

public class CommerceProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CommerceProjectSettings.MySetting1));
    }
}
