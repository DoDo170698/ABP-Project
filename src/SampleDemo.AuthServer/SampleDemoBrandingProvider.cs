using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SampleDemo;

[Dependency(ReplaceServices = true)]
public class SampleDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SampleDemo";
}
