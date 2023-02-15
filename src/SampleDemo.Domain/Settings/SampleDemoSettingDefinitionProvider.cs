using Volo.Abp.Settings;

namespace SampleDemo.Settings;

public class SampleDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SampleDemoSettings.MySetting1));
        context.Add(
            new SettingDefinition(name: "Smtp.Host", defaultValue: "smtp.gmail.com"),
            new SettingDefinition(name: "Smtp.Port", defaultValue: "587"),
            new SettingDefinition(name: "Smtp.UserName", defaultValue: "datkhongchan2020@gmail.com"),
            new SettingDefinition(name: "Smtp.Password", defaultValue: "sbgpzxajlhtchcel", isEncrypted: true),
            new SettingDefinition(name: "Smtp.EnableSsl", defaultValue: "true")
        );
    }
}
