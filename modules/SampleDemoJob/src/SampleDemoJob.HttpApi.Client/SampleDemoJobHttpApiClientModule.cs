using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace SampleDemoJob;

[DependsOn(
    typeof(SampleDemoJobApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class SampleDemoJobHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(SampleDemoJobApplicationContractsModule).Assembly,
            SampleDemoJobRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SampleDemoJobHttpApiClientModule>();
        });
    }
}
