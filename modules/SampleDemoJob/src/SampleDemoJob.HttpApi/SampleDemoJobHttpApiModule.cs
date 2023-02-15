using Localization.Resources.AbpUi;
using SampleDemoJob.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SampleDemoJob;

[DependsOn(
    typeof(SampleDemoJobApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SampleDemoJobHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SampleDemoJobHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<SampleDemoJobResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
